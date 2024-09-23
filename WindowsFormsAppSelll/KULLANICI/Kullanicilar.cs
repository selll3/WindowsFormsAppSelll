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
using WindowsFormsAppSelll.ENTITY;

namespace WindowsFormsAppSelll.KULLANICI
{
    public partial class Kullanicilar : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-99R82DT;Initial Catalog=_HASTANE;Integrated Security=True;Encrypt=False");
        SqlDataAdapter da;
        DataTable dt;
        public Kullanicilar()
        {
            InitializeComponent();
            LoadDatakullanici();
        }

       

        public void LoadDatakullanici()
        {
            Hastanedb dk = new Hastanedb();
       
           _kullanicilar_dataGridView.DataSource = dk.GIRIS
                .Select(r => new
                {
                    r.KULLANICIID,  // İstediğin sütunları buraya ekleyebilirsin
                    r.KullaniciAdi,
                    r.Parola
                    
                    // r.Bulgu gibi başka sütunlar da ekleyebilirsin
                }).ToList();

            // DOKTORID sütununu gizle
            if (_kullanicilar_dataGridView.Columns.Contains("KULLANICIID"))
            {
                _kullanicilar_dataGridView.Columns["KULLANICIID"].Visible = false;
            }
}

        private void Kullanicilar_Load(object sender, EventArgs e)
        {

        }

        private void _kullanicilar_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

        private void _EKLE_button_Click(object sender, EventArgs e)
        {
            KullaniciEkle kullaniciEkle = new KullaniciEkle();
            kullaniciEkle.Show();
        }

        private void _Guncelle_button_Click(object sender, EventArgs e)
        {
            KullaniciGuncelle kullaniciGuncelle = new KullaniciGuncelle();
            kullaniciGuncelle.Show();
        }
        private void verileriyükle()
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    control.Visible = false;
                }
                else if (control is NumericUpDown)
                {
                    control.Visible = false;
                }
                else if (control is Label)
                {
                    control.Visible = false;
                }
                else
                {
                    control.Visible = true;
                }
            }
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-99R82DT;Initial Catalog=_HASTANE;Integrated Security=True;Encrypt=False");
            string readQuery = "Select KullaniciAdi,Parola from GIRIS";
            SqlDataAdapter sdh = new SqlDataAdapter(readQuery, con);
            SqlCommandBuilder cmd = new SqlCommandBuilder();
            DataTable dth = new DataTable();
            sdh.Fill(dth);
            _kullanicilar_dataGridView.DataSource = dth;

        }
        private void _SIL_button_Click(object sender, EventArgs e)
        {

            if (_kullanicilar_dataGridView.SelectedRows.Count > 0)
            {
                int selectedRowId = Convert.ToInt32(_kullanicilar_dataGridView.SelectedRows[0].Cells["KULLANICIID"].Value); // ID sütununu kullanarak silme işlemi yapacağız
                string connectionString = "Data Source=DESKTOP-99R82DT;Initial Catalog=_HASTANE;Integrated Security=True;Encrypt=False";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "DELETE FROM GIRIS WHERE KULLANICIID = @KULLANICIID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@KULLANICIID", selectedRowId);
                        command.ExecuteNonQuery();
                        MessageBox.Show("SİLME İŞLEMİ BAŞARIYLA TAMAMLANDI", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

            }
            else
            {
                MessageBox.Show("Lütfen silinecek satırı seçin.");
            }
            verileriyükle();
        }

        public void _Yetkilerigor_button_Click(object sender, EventArgs e)
        {

            if (_kullanicilar_dataGridView.SelectedRows.Count > 0)
            {
                int selectedUserID = Convert.ToInt32(_kullanicilar_dataGridView.SelectedRows[0].Cells["KULLANICIID"].Value);
                YetkileriGor form2 = new YetkileriGor(selectedUserID);
                form2.ShowDialog();
            }
            else
            {
                MessageBox.Show("Lütfen bir kullanıcı seçin.");
            }


        }
    private YetkileriGor yetkileriGorForm;
        private void _kullanicilar_dataGridView_SelectionChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ForeignKeyCheckForm fkcForm = new ForeignKeyCheckForm();
            fkcForm.ShowDialog();
        }
    }

}
