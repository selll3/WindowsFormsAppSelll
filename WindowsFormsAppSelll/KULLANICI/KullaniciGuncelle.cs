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

namespace WindowsFormsAppSelll.KULLANICI
{
    public partial class KullaniciGuncelle : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-99R82DT;Initial Catalog=_HASTANE;Integrated Security=True;Encrypt=False");
        SqlDataAdapter daHG;
        DataTable dtHG;
        int selectedDoctorID;
        public KullaniciGuncelle()
        {
            InitializeComponent();
            LoadDataK();
        }
        private void LoadDataK()
        {
            dtHG = new DataTable();
            string readQuery = "Select KULLANICIID,KullaniciAdi,Parola from GIRIS";
            daHG = new SqlDataAdapter(readQuery, con);
            daHG.Fill(dtHG);
            _kullaniciGüncelle_dataGridView.DataSource = dtHG;

            // DataGridView verileri yüklendikten sonra sütunları gizle
            if (_kullaniciGüncelle_dataGridView.Columns.Contains("KULLANICIID"))
            {
                _kullaniciGüncelle_dataGridView.Columns["KULLANICIID"].Visible = false;
            }
        }
        private void KullaniciGuncelle_Load(object sender, EventArgs e)
        {
            _kullaniciGüncelle_dataGridView.RowHeadersVisible = false;
        }

        private void _KAYDET_button_Click(object sender, EventArgs e)
        {

            if (selectedDoctorID == 0) // ID seçilmemişse
            {
                MessageBox.Show("Lütfen bir doktor seçin.");
                return;
            }

            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE GIRIS SET KullaniciAdi = @Kadi, Parola=@Parola WHERE KULLANICIID = @Gid", con);

            // Sütunlardaki verileri güncelle
            foreach (DataGridViewRow row in _kullaniciGüncelle_dataGridView.Rows)
            {
                if (Convert.ToInt32(row.Cells["KULLANICIID"].Value) == selectedDoctorID)
                {
                    cmd.Parameters.AddWithValue("@Kadi", row.Cells["KullaniciAdi"].Value ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Parola", row.Cells["Parola"].Value ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Gid", selectedDoctorID);

                    cmd.ExecuteNonQuery();
                    break;
                }
            }

            con.Close();

            // İlk formu güncelle ve göster
            Kullanicilar formK = (Kullanicilar)Application.OpenForms["Kullanicilar"];
            formK.LoadDatakullanici(); // İlk formun veri yükleme metodunu çağır
            this.Close();
        }

        private void _Vazgec_Click(object sender, EventArgs e)
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

        private void _kullaniciGüncelle_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && _kullaniciGüncelle_dataGridView.Rows.Count > 0)
            {
                selectedDoctorID = Convert.ToInt32(_kullaniciGüncelle_dataGridView.Rows[e.RowIndex].Cells["KULLANICIID"].Value);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
