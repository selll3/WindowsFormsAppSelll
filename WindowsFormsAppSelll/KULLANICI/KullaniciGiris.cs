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
            string kullaniciAdi = kullaniciAdi_textBox.Text;
            string parola = _Parola_textBox.Text;

            // LINQ kullanarak veritabanında kullanıcı sorgulama
            var kullanici = dbContext.GIRIS
                .Where(g => g.KullaniciAdi.Equals(kullaniciAdi, StringComparison.OrdinalIgnoreCase) &&
                            g.Parola.Equals(parola))
                .FirstOrDefault();

            if (kullanici != null)
            {
                // Kullanıcı bulundu, ana formu aç
                int kullaniciID = kullanici.KULLANICIID;

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
