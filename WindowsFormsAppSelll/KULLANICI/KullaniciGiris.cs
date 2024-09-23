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
using WindowsFormsAppSelll.ENTITY;

namespace WindowsFormsAppSelll.KULLANICI
{
    public partial class KullaniciGiris : Form
    {
         // Kullanıcı ID'sini tutacak alan

        DataTable dt;
        DataTable dt2;
        public KullaniciGiris()
        {
            InitializeComponent();
        }

        private void Kullanıcılar_Load(object sender, EventArgs e)
        {

        }

        private void Login_button_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-99R82DT;Initial Catalog=_HASTANE;Integrated Security=True;Encrypt=False"))
            {
                string query = "SELECT * FROM GIRIS WHERE KullaniciAdi = @KullaniciAdi AND Parola = @Parola";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@KullaniciAdi", kullaniciAdi_textBox.Text);
                cmd.Parameters.AddWithValue("@Parola", _Parola_textBox.Text);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    int kullaniciID = Convert.ToInt32(dt.Rows[0]["KULLANICIID"]);

                    // Kullanıcı yetkilerini kontrol et
                    CheckUserPermissions(kullaniciID);

                    MessageBox.Show("Giriş başarılı!");
                }
                else
                {
                    MessageBox.Show("Başarısız giriş!");
                }
            }


        }

        private void CheckUserPermissions(int kullaniciID)
        {
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-99R82DT;Initial Catalog=_HASTANE;Integrated Security=True;Encrypt=False"))
            {
                string query = "SELECT FormID, Yetki FROM PERSONELFORMYETKILERI WHERE KULLANICIID = @KullaniciID";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@KullaniciID", kullaniciID);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dtPermissions = new DataTable();
                sda.Fill(dtPermissions);

                foreach (DataRow row in dtPermissions.Rows)
                {
                    int formID = Convert.ToInt32(row["FormID"]);
                    bool yetki = Convert.ToBoolean(row["Yetki"]);

                        //Main m = new Main();
                        //m.Show();

                    if (yetki)
                    {
                        // Kullanıcının yetkisi olan formu aç
                        OpenForm(formID);
                    }
                    //else
                    //{
                    //    Main ma = new Main();
                    //    ma._RANDE_button2.Visible = false;
                    //    ma._DOK_button1.Visible = false;
                    //    ma._PERS_button4.Visible = false;
                    //    ma._hastalar_button.Visible = false;

                    //}
                }
            }
        }

        private void OpenForm(int formID)
        {  
            switch (formID)
            {
                case 1: Main doktorlar = new Main();
                    doktorlar._DOK_button1.Visible = true;
                    //Doktorlar DoktorlarForm = new Doktorlar();
                    //DoktorlarForm._

                    break;
                   

                case 2:Doktorlar doktorEkleForm = new Doktorlar();
                    doktorEkleForm._Ekle_button.Visible = true;

                    break;
                   

                case 3:Doktorlar doktorGuncelle = new Doktorlar();
                    doktorGuncelle._GUNCELLE_button.Visible = true;
                    break;
                    
                case 4:Main HastalarForm = new Main();
                    HastalarForm._hastalar_button.Visible = true;
                    break;
                    
                case 5: Hastalar hastaEkle = new Hastalar();
                    hastaEkle._Ekle_button.Visible = true;
                    break;
                case 6:  Hastalar hastaGuncelle =new Hastalar();
                    hastaGuncelle._GUNCELLE_button.Visible= true;
                    break;
                case 7:Main personeller = new Main();
                    personeller._PERS_button4.Visible = true;
                    break;
                case 8: Personeller personelEkle = new Personeller();
                    personelEkle._Ekle_button.Visible = true;
                    break;
                case 9: Personeller personelGuncelle=new Personeller();
                    personelGuncelle._GUNCELLE_button.Visible = true;
                    break;
               case 10: Main randevular = new Main();
                    randevular._RANDE_button2.Visible = true;
                    break;
               case 11: Randevular randevuEkle = new Randevular();
                    randevuEkle._Ekle_button.Visible = true;
                    break;
               case 12:  Randevular randevuGuncelle = new Randevular();
                    randevuGuncelle._GUNCELLE_button.Visible  = true;
                    //randevuGuncelle._Sil_button.Visible = true;
                    break;
               case 13: Kullanicilar kullaniciEkle = new Kullanicilar();
                    kullaniciEkle._EKLE_button.Visible = true;
                    break;
               case 14:
                    Main adminForm = new Main(); // Admin formu aç
                    adminForm.Visible = true;
                    break;
               case 15: Main kullanicilar = new Main();
                    kullanicilar._kullanicilarb.Visible = true;
                    break;
               case 16: Kullanicilar kullaniciGuncelle = new Kullanicilar();
                    kullaniciGuncelle._Guncelle_button.Visible = true;
                    break;
               case 17:

                    Kullanicilar kullanicilar1 = new Kullanicilar();
                    YetkileriGor yetkileriGor = new YetkileriGor( kullanicilar1.selectedUserID);
                    kullanicilar1._Yetkilerigor_button.Visible = true;
                    break;


                // Diğer formlar için case blokları ekleyebilirsin
               default:
                    MessageBox.Show("Yetkili form bulunamadı!");
                    break;
            }

            this.Hide(); // Mevcut formu gizle
        }
        
        
        

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
