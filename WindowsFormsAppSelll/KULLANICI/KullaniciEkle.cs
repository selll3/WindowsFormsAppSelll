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
    public partial class KullaniciEkle : Form
    {
        public KullaniciEkle()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            KullaniciGiris klnc = new KullaniciGiris();
            klnc.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool isAnyEmpty = false;
            foreach (Control control in this.Controls)
            {
                // Sadece TextBox'ları kontrol et
                if (control is TextBox && string.IsNullOrWhiteSpace(control.Text))
                {
                    isAnyEmpty = true;
                    break;
                }
            }

            if (isAnyEmpty)
            {
                MessageBox.Show("Doldurmalısın!!", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Yeni kullanıcıyı ekle
                GIRIS newUser = new GIRIS
                {
                    KullaniciAdi = kullaniciAdi_textBox.Text,
                    Parola = _Parola_textBox.Text
                };

                // Model katmanındaki KullaniciEkle yöntemini çağır
                bool userAdded = Database.Model.Kullanicilar.KullaniciEkle(newUser);

                if (userAdded)
                {
                    // Yetkileri ekleme
                    List<int> formIDs = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

                    foreach (var formID in formIDs)
                    {
                        PERSONELFORMYETKILERI yetki = new PERSONELFORMYETKILERI
                        {
                            KULLANICIID = newUser.KULLANICIID, // KULLANICIID yeni kullanıcının ID'si
                            FormID = formID,
                            Yetki = false // 0 yerine false
                        };

                        // Model katmanındaki YetkiEkle yöntemini çağır
                        Database.Model.Yetkiler.YetkiEkle(yetki);
                    }

                    MessageBox.Show("KAYIT BAŞARIYLA TAMAMLANDI", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Kullanicilar formh = Application.OpenForms.OfType<Kullanicilar>().FirstOrDefault();
                    if (formh != null)
                    {
                        formh.LoadDatakullanici(); // İlk formun veri yükleme metodunu çağır
                    }

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Kullanıcı eklenirken bir hata oluştu.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }

        private void KullaniciEkle_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
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

        private void kullaniciAdi_textBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
                //string insertquery = "INSERT INTO PERSONELFORMYETKILERI(YetkiID,Yetki,KULLANICIID,FormID) VALUES(@Yid,@Yetki,@Kid,@Fid);