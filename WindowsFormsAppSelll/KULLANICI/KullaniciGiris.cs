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

namespace WindowsFormsAppSelll.KULLANICI
{
    public partial class KullaniciGiris : Form
    {
        public KullaniciGiris()
        {
            InitializeComponent();
        }

        private void Kullanıcılar_Load(object sender, EventArgs e)
        {

        }

        private void Login_button_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-99R82DT;Initial Catalog=_HASTANE;Integrated Security=True;Encrypt=False");
            SqlCommand cmd = new SqlCommand("select*from GIRIS where KullaniciAdi='"+kullaniciAdi_textBox.Text+ "'and Parola='"+_Parola_textBox.Text+"'",con);


            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);




            //////string comboboxvalue = _kullaniciTürü_comboBox.SelectedItem.ToString();
            //if (dt.Rows.Count > 0)
            //{
            //    //if (dt.Rows["KullaniciTuru"])
            //    for (int i = 0; i < dt.Rows.Count; i++)
            //    {
            //        if (dt.Rows[i]["KullaniciTuru"].ToString() == "admin")
            //        {
            //            MessageBox.Show("Giriş yaptınız! " + dt.Rows[i][2]);
            //            //// 0 index admin , 1 index muhasebe,2 index personel, 3 index doktor 
            //            //          
            //            Main ADMIN = new Main();
            //            ADMIN.Show();
            //            this.Hide();
            //        }
            //        //            
            //        else if (dt.Rows[i]["KullaniciTuru"].ToString() == "Muhasebe/İK")
            //        {
            //            Main Km = new Main();
            //            Km._RANDE_button2.Visible = false;
            //            Km.Show();
            //            this.Hide();

            //            //.Visible = false;
            //            //Km._RANDE_button2_Click.
            //            //_Doktorlar_dataGridView.Columns["DOKTORID"].Visible = false;

            //        }
            //        else if (dt.Rows[i]["KullaniciTuru"].ToString() == "Personel")
            //        {
            //            Main Kp = new Main();
            //            Kp._DOK_button1.Visible = false;
            //            Kp._PERS_button4.Visible = false;
            //            Kp._hastalar_button.Visible = false;
            //            Kp.Show();
            //            this.Hide();


            //        }
            //        else
            //        {
            //            Main Kd = new Main();
            //            Kd._DOK_button1.Visible = false;
            //            Kd._PERS_button4.Visible = false;
            //            Kd.Show();
            //            this.Hide();

            //        }

            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Başarısız giriş");
            //}

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
