using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Database.Entity;

namespace WindowsFormsAppSelll.KULLANICI
{
    public partial class KullaniciGuncelle : Form
    {
        public int KullaniciID { get; set; }
        int selectedDoctorID;
        public KullaniciGuncelle(int kullaniciID)
        {
            InitializeComponent();
            KullaniciID = kullaniciID;
            //LoadDataK();
            LoadUserData();
        }

        private void LoadUserData()
        {
            using (Hastanedb dbContext = new Hastanedb()) // using bloğu ile context yönetimi
            {
                var kullanici = dbContext.GIRIS.SingleOrDefault(g => g.KULLANICIID == KullaniciID);
                if (kullanici != null)
                {
                    kullaniciAdi_textBox.Text = kullanici.KullaniciAdi;
                    _Parola_textBox.Text = kullanici.Parola; // Şifreyi gösterirken dikkatli olun
                }
                else
                {
                    MessageBox.Show("Kullanıcı bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
        }
       
        private void KullaniciGuncelle_Load(object sender, EventArgs e)
        {
            //_kullaniciGüncelle_dataGridView.RowHeadersVisible = false;
        }

        private void _KAYDET_button_Click(object sender, EventArgs e)
        {
           
                var kullanici = Database.Model.Kullanicilar.dbk.GIRIS.SingleOrDefault(g => g.KULLANICIID == KullaniciID);
            if (kullanici != null)
            {
                kullanici.KullaniciAdi = kullaniciAdi_textBox.Text;
                kullanici.Parola = _Parola_textBox.Text;
                var kullanicigunc = Database.Model.Kullanicilar.KullaniciGuncelle(kullanici);
                    if (kullanicigunc)
                    {
                      MessageBox.Show("Kullanıcı bilgileri başarıyla güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                      this.Close(); // Formu kapat
                    }
                     else
                      {
                       MessageBox.Show("Kullanıcı bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                     }
                /*dbContext.SaveChanges(); */// Değişiklikleri kaydet

               
            }
           

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

            //if (e.RowIndex >= 0 && _kullaniciGüncelle_dataGridView.Rows.Count > 0)
            //{
            //    selectedDoctorID = Convert.ToInt32(_kullaniciGüncelle_dataGridView.Rows[e.RowIndex].Cells["KULLANICIID"].Value);
            //}
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                _Parola_textBox.PasswordChar = '\0'; // Şifreyi görünür yap
            }
            else
            {
                _Parola_textBox.PasswordChar = '*'; // Şifreyi tekrar gizle
            }
        }
    }
}
