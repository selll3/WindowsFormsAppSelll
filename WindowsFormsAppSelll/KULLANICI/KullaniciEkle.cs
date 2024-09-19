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
                //HASTALAR hst = new HASTALAR();
                //hst.HastaAdi = _HastaAdi_textBox.Text;
                //hst.HastaSoyadi = _HastaSoyadi_textBox.Text;
                //hst.HastaYasi = Convert.ToInt32(_HastaYasi_textBox.Text);
                //// int.TryParse

                //Hastanedb dbh = new Hastanedb();

                //dbh.HASTALAR.Add(hst);
                //dbh.SaveChanges();


                SqlConnection con = new SqlConnection("Data Source=DESKTOP-99R82DT;Initial Catalog=_HASTANE;Integrated Security=True;Encrypt=False");
                string insertQuery = "INSERT INTO GIRIS(KullaniciAdi,Parola) VALUES(@Kadi, @Parola) ";
                con.Open();
                SqlCommand cmd = new SqlCommand(insertQuery, con);
                cmd.Parameters.AddWithValue("@Kadi", kullaniciAdi_textBox.Text);
                cmd.Parameters.AddWithValue("@Parola", _Parola_textBox.Text);
                
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
                Kullanicilar formh = Application.OpenForms.OfType<Kullanicilar>().FirstOrDefault();
                if (formh != null)
                {
                    formh.LoadDatakullanici(); // İlk formun veri yükleme metodunu çağır
                }

                this.Close();




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
    }
}
