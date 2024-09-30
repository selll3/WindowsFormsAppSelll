using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
//using WindowsFormsAppSelll.PERSONEL;
//using WindowsFormsAppSelll.Muhasebe;
//using WindowsFormsAppSelll.DOKTOR;
using System.Runtime.InteropServices;
//using WindowsFormsAppSelll.ENTITY;
using Database.Entity;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Data.Entity;
using WindowsFormsAppSelll.MUAYENE;

namespace WindowsFormsAppSelll.KULLANICI
{
    public partial class KullaniciGiris : Form
    {
        // Kullanıcı ID'sini tutacak alan
        // Kullanıcı ID'yi alır (LINQ veya SQL sorgusu ile)
        private Hastanedb dbContext = new Hastanedb();
        private DateTime randevuTarihi;
        DataTable dt;
        DataTable dt2;
        public int KULLANICIID { get; set; }
        public KullaniciGiris()
        {
            InitializeComponent();
        }

        private void Kullanıcılar_Load(object sender, EventArgs e)
        {

        }

        private void Login_button_Click(object sender, EventArgs e)
        {

            //string username = kullaniciAdi_textBox.Text;
            //string password = _Parola_textBox.Text;

            //// Kullanıcı bilgilerini veritabanından kontrol ediyoruz
            //var user = dbContext.GIRIS
            //                    .FirstOrDefault(u => u.KullaniciAdi == username && u.Parola == password);

            //if (user != null)  // Eğer kullanıcı varsa
            //{
            //    // KULLANICIID'yi ve kullanıcının yetkilerini Ana Forma taşıyoruz
            //    Main mainForm = new Main(user.KULLANICIID);
            //    this.Hide();  // Login formunu gizliyoruz
            //    mainForm.Show();  // Ana formu gösteriyoruz
            //}
            //else
            //{
            //    MessageBox.Show("Kullanıcı adı veya şifre hatalı.");
            //}
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-99R82DT;Initial Catalog=_HASTANE;Integrated Security=True;Encrypt=False"))
            {
                string query = "SELECT * FROM GIRIS WHERE KullaniciAdi COLLATE Latin1_General_CS_AS = @KullaniciAdi AND Parola COLLATE Latin1_General_CS_AS = @Parola";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@KullaniciAdi", kullaniciAdi_textBox.Text);
                cmd.Parameters.AddWithValue("@Parola", _Parola_textBox.Text);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    int kullaniciID = Convert.ToInt32(dt.Rows[0]["KULLANICIID"]);

                    DoktorMuayeneleri dm = new DoktorMuayeneleri(kullaniciID);


                    
                    Main mainForm = new Main(kullaniciID); 
                    this.Hide();  
                    mainForm.Show(); 
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre hatalı.");
                }
            }
            //using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-99R82DT;Initial Catalog=_HASTANE;Integrated Security=True;Encrypt=False"))
            //{
            //    string query = "SELECT * FROM GIRIS WHERE KullaniciAdi = @KullaniciAdi AND Parola = @Parola";
            //    SqlCommand cmd = new SqlCommand(query, con);
            //    cmd.Parameters.AddWithValue("@KullaniciAdi", kullaniciAdi_textBox.Text);
            //    cmd.Parameters.AddWithValue("@Parola", _Parola_textBox.Text);

            //    SqlDataAdapter sda = new SqlDataAdapter(cmd);
            //    dt = new DataTable();
            //    sda.Fill(dt);

            //    if (dt.Rows.Count > 0)
            //    {
            //        int kullaniciID = Convert.ToInt32(dt.Rows[0]["KULLANICIID"]);

            //        // Kullanıcı yetkilerini kontrol et
            //        CheckUserPermissions(kullaniciID);

            //        MessageBox.Show("Giriş başarılı!");

            //    }
            //    else
            //    {
            //        MessageBox.Show("Başarısız giriş!");
            //    }
        }

        




        //public void CheckUserPermissions(int kullaniciID)
        //{
        //    using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-99R82DT;Initial Catalog=_HASTANE;Integrated Security=True;Encrypt=False"))
        //    {
        //        string query = "SELECT FormID, Yetki FROM PERSONELFORMYETKILERI WHERE KULLANICIID = @KullaniciID";
        //        SqlCommand cmd = new SqlCommand(query, con);
        //        cmd.Parameters.AddWithValue("@KullaniciID", kullaniciID);

        //        SqlDataAdapter sda = new SqlDataAdapter(cmd);
        //        DataTable dtPermissions = new DataTable();
        //        sda.Fill(dtPermissions);
        //        Main mainForm = new Main();
        //        //Main mainForm = new Main();
        //        Doktorlar doktorlar = new Doktorlar();
        //        //doktorlar._Ekle_button.Enabled = false;
        //        //doktorlar._GUNCELLE_button.Enabled = false;
        //        //doktorlar._Sil_button.Enabled = false;

        //        Randevular randevular1 = new Randevular();
        //        //randevular1._Ekle_button.Enabled = false;
        //        //randevular1._GUNCELLE_button.Enabled = false;
        //        //randevular1._Sil_button.Enabled = false;

        //        Personeller personeller1 = new Personeller();
        //        //personeller1._Ekle_button.Enabled = false;
        //        //personeller1._GUNCELLE_button.Enabled = false;
        //        //personeller1._Sil_button.Enabled = false;

        //        Hastalar hastalar1 = new Hastalar();
        //        //hastalar1._Ekle_button.Enabled = false;
        //        //hastalar1._GUNCELLE_button.Enabled = false;
        //        //hastalar1._Sil_button.Enabled = false;

        //        Kullanicilar kullanicilar1 = new Kullanicilar();
        //        //kullanicilar1._Guncelle_button.Enabled = false;
        //        //kullanicilar1._SIL_button.Enabled = false;
        //        //kullanicilar1._EKLE_button.Enabled = false;
        //        //kullanicilar1._Yetkilerigor_button.Enabled = false;


        //        foreach (DataRow row in dtPermissions.Rows)
        //        {
        //            int formID = Convert.ToInt32(row["FormID"]);
        //            bool yetki = Convert.ToBoolean(row["Yetki"]);

        //            if (yetki == false)
        //            {
        //                switch (formID)
        //                {
        //                    case 1:
        //                        mainForm._DOK_button1.Enabled = false;

        //                        break;
        //                    case 2:
        //                        doktorlar._Ekle_button.Enabled = false;    
    
        //                        break;
        //                    case 3:
        //                        doktorlar._GUNCELLE_button.Enabled = false;
        //                        break;
        //                    case 4:
        //                        mainForm._hastalar_button.Enabled = false;
        //                        break;
        //                    case 5:
        //                        hastalar1._Ekle_button.Enabled = false;
        //                        break;
        //                    case 6:
        //                        hastalar1._GUNCELLE_button.Enabled = false;
        //                        break;
        //                    case 7:
        //                        mainForm._PERS_button4.Enabled = false;
        //                        break;
        //                    case 8:
        //                        personeller1._Ekle_button.Enabled = false;
        //                        break;
        //                    case 9:
        //                        personeller1._GUNCELLE_button.Enabled = false;
        //                        break;
        //                    case 10:
        //                        mainForm._RANDE_button2.Enabled = false;
        //                        break;
        //                    case 11:
        //                        randevular1._Ekle_button.Enabled = false;
        //                        break;
        //                    case 12:
        //                        randevular1._GUNCELLE_button.Enabled = false;
        //                        break;
        //                    case 13:
        //                        kullanicilar1._EKLE_button.Enabled = false;
        //                        break;
        //                    case 15:
        //                        mainForm._kullanicilarb.Enabled = false;
        //                        break;
        //                    case 14:
        //                        mainForm.Enabled = false;
        //                        break;
        //                    case 16:
        //                        kullanicilar1._Guncelle_button.Enabled = false;
        //                        break;
        //                    case 17:
        //                        kullanicilar1._Yetkilerigor_button.Enabled = false;
        //                        break;
        //                    default:
        //                        MessageBox.Show("Yetkili buton bulunamadı!");
        //                        break;

        //                }
                        
        //            }
                    
                    

        //        }

                
        //        doktorlar.Show(); doktorlar.Hide();
        //        hastalar1.Show();

        //        mainForm.Show();/*mainForm.Hide();*/
        //        personeller1.Show();
        //        randevular1.Show();
        //        kullanicilar1.Show();
        //        this.Hide();
        //    }
        //}

      




        private void button1_Click(object sender, EventArgs e)
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            KullaniciEkle girisislemleri = new KullaniciEkle();
            girisislemleri.Show();
        }

        private void _Parola_textBox_TextChanged(object sender, EventArgs e)
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

        private void kullaniciAdi_textBox_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
