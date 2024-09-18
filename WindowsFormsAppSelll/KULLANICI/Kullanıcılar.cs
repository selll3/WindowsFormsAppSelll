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
            string comboboxvalue = _kullaniciTürü_comboBox.SelectedItem.ToString();
            if (dt.Rows.Count > 0 )
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i]["KullaniciTuru"].ToString()== comboboxvalue)
                    {
                        MessageBox.Show("Giriş yaptınız! " + dt.Rows[i][2]);
                        // 0 index admin , 1 index muhasebe,2 index personel, 3 index doktor 
                        // eger admin seçilirse
                        if (_kullaniciTürü_comboBox.SelectedIndex == 0)
                        {
                            Main ADMIN = new Main();
                            ADMIN.Show();
                            this.Hide();
                            
                        }
                        else if(_kullaniciTürü_comboBox.SelectedIndex == 1)
                        {

                        }
                        else if(_kullaniciTürü_comboBox.SelectedIndex == 2)
                        {

                        }
                        else 
                        {


                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Başarısız giriş");
            }
            
        }
    }
}
