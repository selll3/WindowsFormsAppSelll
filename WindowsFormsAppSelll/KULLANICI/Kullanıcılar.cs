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
using WindowsFormsAppSelll.PERSONEL;
using WindowsFormsAppSelll.Muhasebe;
using WindowsFormsAppSelll.DOKTOR;
using System.Runtime.InteropServices;

namespace WindowsFormsAppSelll.KULLANICI
{
    public partial class Kullanıcılar : Form
    {
        public Kullanıcılar()
        {
            InitializeComponent();
        }

        private void Kullanıcılar_Load(object sender, EventArgs e)
        {

        }

        private void Login_button_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-99R82DT;Initial Catalog=_HASTANE;Integrated Security=True;Encrypt=False");
            SqlCommand cmd = new SqlCommand("select*from LOGIN where KullaniciAdi='"+kullaniciAdi_textBox.Text+ "'and Parola='"+_Parola_textBox.Text+"'",con);


            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);




            ////string comboboxvalue = _kullaniciTürü_comboBox.SelectedItem.ToString();
            if (dt.Rows.Count > 0)
            {
                //if (dt.Rows["KullaniciTuru"])
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i]["KullaniciTuru"].ToString() == "admin")
                    {
                        MessageBox.Show("Giriş yaptınız! " + dt.Rows[i][2]);
                        //// 0 index admin , 1 index muhasebe,2 index personel, 3 index doktor 
                        //          
                        Main ADMIN = new Main();
                        ADMIN.Show();
                        this.Hide();
                    }
                    //            
                    else if (dt.Rows[i]["KullaniciTuru"].ToString() == "Muhasebe/İK")
                    {
                         Main Km = new Main();
                         Km._DOK_button1.Visible = false;
                            
                           //.Visible = false;
                        //Km._RANDE_button2_Click.
                        //_Doktorlar_dataGridView.Columns["DOKTORID"].Visible = false;

                    }
                    else if (dt.Rows[i]["KullaniciTuru"].ToString() == "Personel")
                    {
                        kullaniciP kp = new kullaniciP();
                        kp.Show();
                        this.Hide();
                    }
                    else
                    {
                        KullaniciD kullaniciD = new KullaniciD();
                        kullaniciD.Show();
                        this.Hide();

                    }

                }
            }
            else
            {
                MessageBox.Show("Başarısız giriş");
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
            Girisislemleri girisislemleri = new Girisislemleri();
            girisislemleri.Show();
        }
    }
}
