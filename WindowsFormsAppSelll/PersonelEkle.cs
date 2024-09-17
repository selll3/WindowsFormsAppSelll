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

namespace WindowsFormsAppSelll
{
    public partial class PersonelEkle : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-99R82DT;Initial Catalog=_HASTANE;Integrated Security=True;Encrypt=False");
        SqlDataAdapter daPE;
        DataTable dtPE;
        public PersonelEkle()
        {
            InitializeComponent();
            LoadDatapE();
        }
        private void LoadDatapE()
        {
            dtPE = new DataTable();
            string readQuery = "SELECT PERSONELID, PersonelAdi,PersonelSoyadi, PersonelGorev from PERSONEL WHERE PERSONELID = 0";
            daPE = new SqlDataAdapter(readQuery, con);
            daPE.Fill(dtPE);
            _personelekle_dataGridView.DataSource = dtPE;

            // DOKTORID sütununu gizle
            if (_personelekle_dataGridView.Columns.Contains("PERSONELID"))
            {
                _personelekle_dataGridView.Columns["PERSONELID"].Visible = false;
            }
        }
        private void _vazgec_button_Click(object sender, EventArgs e)
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

        private void PersonelEkle_Load(object sender, EventArgs e)
        {

        }

        private void _kaydet_button_Click(object sender, EventArgs e)
        {
            con.Open();
            foreach (DataGridViewRow row in _personelekle_dataGridView.Rows)
            {
                //dataGridView1.Columns["DOKTORID"].Visible = false;
                if (!row.IsNewRow) // Yeni satır değilse
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO PERSONEL ( PersonelAdi,PersonelSoyadi, PersonelGorev) VALUES (@Padi, @Psoyadi, @PGorev)", con);
                    cmd.Parameters.AddWithValue("@Padi", row.Cells["PersonelAdi"].Value ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Psoyadi", row.Cells["PersonelSoyadi"].Value ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@PGorev", row.Cells["PersonelGorev"].Value ?? (object)DBNull.Value);


                    cmd.ExecuteNonQuery();
                }
            }
            con.Close();

            // İlk formu güncelle ve göster
            Personeller formp = Application.OpenForms.OfType<Personeller>().FirstOrDefault();
            if (formp != null)
            {
                formp.LoadDataIntoGridp(); // İlk formun veri yükleme metodunu çağır
            }

            this.Close();
        }
    }
}
