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
    public partial class Doktor_ekle : Form
    {
        public Doktor_ekle()
        {
            InitializeComponent();
        }
        
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Doktor_ekle_Load(object sender, EventArgs e)
        {

        }

        private void _Ekle_button_Click(object sender, EventArgs e)
        {
            bool isAnyEmpty = false;
            foreach(Control control in this.Controls)
            {
                if(control.Text.Length == 0)
                {
                    isAnyEmpty = true;
                    break;
                }

            }
            if (isAnyEmpty)
            {
                MessageBox.Show("Doldurmalısın!!","BİLGİLENDİRME",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {   
               // DOKTORLAR dr = new DOKTORLAR();
              //  dr.DoktorAdi = _DoktorAdi_textBox.Text;
               // dr.DoktorSoyadi = _DoktorSoyadi_textBox.Text;
               // dr.DoktorSoyadi = _DoktorBranşi_textBox.Text;
               // dr.DoktorSoyadi = _DoktorunKati_textBox.Text;


              //  Hastanedb db = new Hastanedb();

               // db.DOKTORLAR.Add(dr);
               // db.SaveChanges();
                

                SqlConnection con = new SqlConnection("Data Source=DESKTOP-99R82DT;Initial Catalog=_HASTANE;Integrated Security=True;Encrypt=False");
                string insertQuery = "INSERT INTO DOKTORLAR(DoktorAdi,DoktorSoyadi,DoktorunBransi,Doktorun_kati) VALUES(@DoktorAdi, @DoktorSoyadi, @Doktorbransi, @Doktorunkati) ";
                con.Open();
                SqlCommand cmd = new SqlCommand(insertQuery, con);
                cmd.Parameters.AddWithValue("@DoktorAdi", _DoktorAdi_textBox.Text);
                cmd.Parameters.AddWithValue("@DoktorSoyadi", _DoktorSoyadi_textBox.Text);
                cmd.Parameters.AddWithValue("@DoktorBransi", _DoktorBranşi_textBox.Text);
                cmd.Parameters.AddWithValue("@Doktorunkati", _DoktorunKati_textBox.Text);
                int count = cmd.ExecuteNonQuery();
                con.Close();
                if (count > 0)
                {
                      MessageBox.Show("KAYIT BAŞARIYLA TAMAMLANDI","BİLGİLENDİRME",MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("KAYIT OLUŞTURULAMADI", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
        }

       

        private void _Vazgec_button_Click_1(object sender, EventArgs e)
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
