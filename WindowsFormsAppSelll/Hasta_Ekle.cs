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
    public partial class Hasta_Ekle : Form
    {
        public Hasta_Ekle()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Hasta_Ekle_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
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
                HASTALAR hst = new HASTALAR();
                hst.HastaAdi = _HastaAdi_textBox.Text;
                hst.HastaSoyadi = _HastaSoyadi_textBox.Text;
                hst.HastaYasi = Convert.ToInt32(_HastaYasi_textBox.Text);
               // int.TryParse

               Hastanedb dbh = new Hastanedb();

                dbh.HASTALAR.Add(hst);
                 dbh.SaveChanges();


                SqlConnection con = new SqlConnection("Data Source=DESKTOP-99R82DT;Initial Catalog=_HASTANE;Integrated Security=True;Encrypt=False");
                string insertQuery = "INSERT INTO HASTALAR(HastaAdi,HastaSoyadi,HastaYasi) VALUES(@Hastaadi, @Hastasoyadi, @Hastayasi) ";
                con.Open();
                SqlCommand cmd = new SqlCommand(insertQuery, con);
                cmd.Parameters.AddWithValue("@Hastaadi",_HastaAdi_textBox.Text);
                cmd.Parameters.AddWithValue("@Hastasoyadi",_HastaSoyadi_textBox.Text);
                cmd.Parameters.AddWithValue("@Hastayasi",_HastaYasi_textBox.Text);
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
