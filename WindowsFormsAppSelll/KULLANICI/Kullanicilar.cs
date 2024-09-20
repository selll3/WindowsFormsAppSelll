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

        private void LoadKullanicilar()
        {
            //using (var context = new Hastanedb())
            //{
            //    var kullaniciList = context.GIRIS.ToList();
            //   _kullanicilar_dataGridView.DataSource = kullaniciList;
            //}
        }

        public void LoadDatakullanici()
        {
            //    dt = new DataTable();
            //    string readQuery = "SELECT KULLANICIID, KullaniciAdi,Parola FROM GIRIS";
            //    da = new SqlDataAdapter(readQuery, con);
            //    da.Fill(dt);
            //    _kullanicilar_dataGridView.DataSource = dt;

            //    // DOKTORID sütununu gizle
            //    if (_kullanicilar_dataGridView.Columns.Contains("KULLANICIID"))
            //    {
            //        _kullanicilar_dataGridView.Columns["KULLANICIID"].Visible = false;
            //    }
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
                int kullaniciId = (int)_kullanicilar_dataGridView.SelectedRows[0].Cells["KULLANICIID"].Value;
                YetkileriGor yetkileriGorForm = new YetkileriGor(kullaniciId);
                yetkileriGorForm.ShowDialog(); // Modals form açmak için ShowDialog kullanıyoruz
            }


        }
        private YetkileriGor yetkileriGorForm;
        private void _kullanicilar_dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (_kullanicilar_dataGridView.SelectedRows.Count > 0)
            {
                int kullaniciId = (int)_kullanicilar_dataGridView.SelectedRows[0].Cells["KULLANICIID"].Value;

                // Eğer yetkileriGorForm açık ise sadece yetkileri yükle
                if (yetkileriGorForm != null && !yetkileriGorForm.IsDisposed)
                {
                    yetkileriGorForm.ReloadYetkiler(kullaniciId); // Kullanıcıyı güncelle
                }
                else
                {
                    yetkileriGorForm = new YetkileriGor(kullaniciId);
                    yetkileriGorForm.Show(); // Yeni form açılır
                }
            }
        }


        //// DataGridView'den seçili satırdaki KullaniciID'yi alıyoruz
        //if (_kullanicilar_dataGridView.SelectedRows.Count > 0)
        //{
        //    int kullaniciId = Convert.ToInt32(_kullanicilar_dataGridView.SelectedRows[0].Cells["KULLANICIID"].Value);

        //    // YetkileriGor formunu açıyoruz ve seçilen kullanıcının ID'sini geçiyoruz
        //    YetkileriGor yetkileriGorForm = new YetkileriGor(kullaniciId);
        //    yetkileriGorForm.ShowDialog();  // Formu modal olarak açıyoruz
        //}
        //else
        //{
        //    MessageBox.Show("Lütfen bir kullanıcı seçin.");
        //}


        //if (_kullanicilar_dataGridView.SelectedRows.Count > 0)
        //{
        //    // Seçilen kullanıcıyı al
        //    int kullaniciId = Convert.ToInt32(_kullanicilar_dataGridView.SelectedRows[0].Cells["KULLANICIID"].Value);

        //    // Yeni formu aç ve KULLANICIID'yi gönder
        //    YetkileriGor yetkileriGorForm = new YetkileriGor(kullaniciId);
        //    yetkileriGorForm.Show();
        //}
        //else
        //{
        //    MessageBox.Show("Lütfen bir kullanıcı seçiniz.");
        //}




        // int selectedKullaniciID = (int)_kullanicilar_dataGridView.SelectedRows[0].Cells["KULLANICIID"].Value;


        //YetkileriGor yg = new YetkileriGor();

        //// DataGridView  dgv = new DataGridView();
        //yg.ShowDialog();

        // SqlConnection conn = new SqlConnection("Data Source=DESKTOP-99R82DT;Initial Catalog=_HASTANE;Integrated Security=True;Encrypt=False");
        // //string insertQuery = "SELECT PERSONELFORMYETKILERI.*, FORM.* FROM PERSONELFORMYETKILERI INNER JOIN FORM ON PERSONELFORMYETKILERI.PERSONELID = FORM.PERSONELID";
        // SqlCommand cmd = new SqlCommand("SELECT F.FormAdi, COALESCE(PFY.Yetki, 0) AS Yetki FROM FORMLAR F "+"LEFT JOIN PERSONELFORMYETKILERI PFY ON F.FormID = PFY.FormID AND PFY.KULLANICIID = @SelectedKullaniciID;", conn);
        // conn.Open();

        // SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        // DataTable table = new DataTable();
        // adapter.Fill(table);

        // // DataGridView'e veri bağlama
        // YetkileriGor yt = new YetkileriGor();
        //yt._yetkilerigor_dataGridView.DataSource = table;


        // yg.Controls.Add(dgv);


        //// Seçilen personelin ID'sini al
        //int selectedPersonelID = // Bu fonksiyon seçilen personelin ID'sini alır

        //// Yeni formu aç ve PersonelID'yi gönder
        //YetkileriGor formYetkileri = new YetkileriGor(selectedPersonelID);
        //formYetkileri.Show();


    }

}
