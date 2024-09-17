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
    public partial class HastaEkle : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-99R82DT;Initial Catalog=_HASTANE;Integrated Security=True;Encrypt=False");
        SqlDataAdapter daHE;
        DataTable dtHE;
        public HastaEkle()
        {
            InitializeComponent();
            LoadDataHE();
        }
        private void LoadDataHE()
        {
            dtHE = new DataTable();
            string readQuery = "SELECT HASTAID, HastaAdi,HastaSoyadi, HastaYasi from HASTALAR WHERE HASTAID = 0";
            daHE = new SqlDataAdapter(readQuery, con);
            daHE.Fill(dtHE);
            _hastaekle_dataGridView.DataSource = dtHE;

            // DOKTORID sütununu gizle
            if (_hastaekle_dataGridView.Columns.Contains("HASTAID"))
            {
                _hastaekle_dataGridView.Columns["HASTAID"].Visible = false;
            }
        }
        private void HastaEkle_Load(object sender, EventArgs e)
        {

        }

        private void _kaydet_button_Click(object sender, EventArgs e)
        {
            con.Open();
            foreach (DataGridViewRow row in _hastaekle_dataGridView.Rows)
            {
                //dataGridView1.Columns["DOKTORID"].Visible = false;
                if (!row.IsNewRow) // Yeni satır değilse
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO HASTALAR ( HastaAdi,HastaSoyadi, HastaYasi) VALUES (@Hadi, @Hsoyadi, @HYasi)", con);
                    cmd.Parameters.AddWithValue("@Hadi", row.Cells["HastaAdi"].Value ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Hsoyadi", row.Cells["HastaSoyadi"].Value ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@HYasi", row.Cells["HastaYasi"].Value ?? (object)DBNull.Value);
                   

                    cmd.ExecuteNonQuery();
                }
            }
            con.Close();

            // İlk formu güncelle ve göster
            Hastalar formh = Application.OpenForms.OfType<Hastalar>().FirstOrDefault();
            if (formh != null)
            {
                formh.LoadDataIntoGridh(); // İlk formun veri yükleme metodunu çağır
            }

            this.Close();
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
    }
}
