using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Database.Entity;

namespace WindowsFormsAppSelll.MUAYENE
{
    public partial class DMuayeneleriAyrinti : Form
    {
        private int hastaID;
        public DMuayeneleriAyrinti(int _hastaID)
        {
            InitializeComponent();
            hastaID = _hastaID; // Hasta ID'sini form yüklenirken alıyoruz
            LoadHastaBilgileri();
            LoadHastaMuayeneGecmisi();
        }
        private void LoadHastaMuayeneGecmisi()
        {
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-99R82DT;Initial Catalog=_HASTANE;Integrated Security=True;Encrypt=False"))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT MuayeneID, MuayeneTarihi, Aciklama FROM MUAYENE WHERE HASTAID = @hastaID ", con);
                cmd.Parameters.AddWithValue("@hastaID", hastaID);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt; // Geçmiş muayeneleri DataGridView'e bağla
            }
        }

        private void LoadHastaBilgileri()
        {
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-99R82DT;Initial Catalog=_HASTANE;Integrated Security=True;Encrypt=False"))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM HASTALAR WHERE HASTAID = @hastaID", con);
                cmd.Parameters.AddWithValue("@hastaID", hastaID);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    _hastaAdi_textBox.Text = reader["HastaAdi"].ToString();
                    _hastaSoyadi_textBox.Text = reader["HastaSoyadi"].ToString();
                   
                    _hastaYasi_textBox.Text = reader["HastaYasi"].ToString();

                }
            }
        }
        private void DMuayeneleriAyrinti_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns["MuayeneID"].Visible = false;
            dataGridView1.Columns["MuayeneTarihi"].HeaderText = "Muayene Tarihi";
           dataGridView1.Columns["Aciklama"].HeaderText = "Açıklama";

        }

        private void _Vazgec_button_Click(object sender, EventArgs e)
        {

            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    control.Text = string.Empty;
                }
            }

            // Formu kapat
            this.Close();
        }
    }
}
