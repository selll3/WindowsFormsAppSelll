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

namespace WindowsFormsAppSelll
{
    public partial class Personel_ekle : Form
    {
        public Personel_ekle()
        {
            InitializeComponent();
        }

        private void _Ekle_button_Click(object sender, EventArgs e)
        {
            bool isAnyEmpty = false;
            foreach (Control control in this.Controls)
            {
                if (control.Text.Length == 0)
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
                // PERSONEL prs = new PERSONEL();
                  //prs.PersonelAdi = _PersonelAdi_textBox.Text;
                 // prs.PersonelSoyadi = _PersonelSoyadi_textBox.Text;
                 // prs.PersonelGorev = _Gorevi_textBox.Text;
                 

                 // Hastanedb dbp = new Hastanedb();

                // dbp.PERSONEL.Add(prs);
                // dbp.SaveChanges();


                SqlConnection con = new SqlConnection("Data Source=DESKTOP-99R82DT;Initial Catalog=_HASTANE;Integrated Security=True;Encrypt=False");
                string insertQuery = "INSERT INTO PERSONEL(PersonelAdi,PersonelSoyadi,PersonelGorev) VALUES(@Personeladi, @Personelsoyadi, @Personelgorev) ";
                con.Open();
                SqlCommand cmd = new SqlCommand(insertQuery, con);
                cmd.Parameters.AddWithValue("@Personeladi",_PersonelAdi_textBox.Text);
                cmd.Parameters.AddWithValue("@Personelsoyadi",_PersonelSoyadi_textBox.Text);
                cmd.Parameters.AddWithValue("@Personelgorev",_Gorevi_textBox.Text);
                
                int count = cmd.ExecuteNonQuery();
                con.Close();
                if (count > 0)
                {
                    MessageBox.Show("KAYIT BAŞARIYLA TAMAMLANDI", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("KAYIT OLUŞTURULAMADI", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void _Vazgec_button_Click(object sender, EventArgs e)
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
    }
}
