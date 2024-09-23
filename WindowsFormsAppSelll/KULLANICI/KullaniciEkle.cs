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
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-99R82DT;Initial Catalog=_HASTANE;Integrated Security=True;Encrypt=False");
                string insertQuery = "INSERT INTO GIRIS(KullaniciAdi, Parola) OUTPUT INSERTED.KULLANICIID VALUES(@Kadi, @Parola)";

                con.Open();
                SqlCommand cmd = new SqlCommand(insertQuery, con);
                cmd.Parameters.AddWithValue("@Kadi", kullaniciAdi_textBox.Text);
                cmd.Parameters.AddWithValue("@Parola", _Parola_textBox.Text);

                // KULLANICIID'yi al
                int newUserId = (int)cmd.ExecuteScalar();


                // Yetkileri ekleme sorgusu
                string insertYetkiQuery = "INSERT INTO PERSONELFORMYETKILERI (KULLANICIID, FormID, Yetki) VALUES (@KullaniciID, @FormID, 0)"; // 0: false

                // Yetkiler için gerekli FormID'leri belirle
                List<int> formIDs = new List<int> {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17};

                foreach (var formID in formIDs)
                {
                    SqlCommand yetkiCmd = new SqlCommand(insertYetkiQuery, con);
                    yetkiCmd.Parameters.AddWithValue("@KullaniciID", newUserId);
                    yetkiCmd.Parameters.AddWithValue("@FormID", formID);
                    yetkiCmd.ExecuteNonQuery();
                }

                con.Close();

                MessageBox.Show("KAYIT BAŞARIYLA TAMAMLANDI", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Kullanicilar formh = Application.OpenForms.OfType<Kullanicilar>().FirstOrDefault();
                if (formh != null)
                {
                    formh.LoadDatakullanici(); // İlk formun veri yükleme metodunu çağır
                }

                this.Close();
            }
            //bool isAnyEmpty = false;
            //foreach (Control control in this.Controls)
            //{
            //    // Sadece TextBox'ları kontrol et
            //    if (control is TextBox && string.IsNullOrWhiteSpace(control.Text))
            //    {
            //        isAnyEmpty = true;
            //        break;
            //    }
            //}
            //if (isAnyEmpty)
            //{
            //    MessageBox.Show("Doldurmalısın!!", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //else
            //{
            //    //HASTALAR hst = new HASTALAR();
            //    //hst.HastaAdi = _HastaAdi_textBox.Text;
            //    //hst.HastaSoyadi = _HastaSoyadi_textBox.Text;
            //    //hst.HastaYasi = Convert.ToInt32(_HastaYasi_textBox.Text);
            //    //// int.TryParse

            //    //Hastanedb dbh = new Hastanedb();

            //    //dbh.HASTALAR.Add(hst);
            //    //dbh.SaveChanges();


            //    SqlConnection con = new SqlConnection("Data Source=DESKTOP-99R82DT;Initial Catalog=_HASTANE;Integrated Security=True;Encrypt=False");
            //    string insertQuery = "INSERT INTO GIRIS(KULLANICIID,KullaniciAdi,Parola) VALUES(@Kid,@Kadi, @Parola) ";

            //    con.Open();
            //    SqlCommand cmd = new SqlCommand(insertQuery, con);
            //    cmd.Parameters.AddWithValue("@Kadi", kullaniciAdi_textBox.Text);
            //    cmd.Parameters.AddWithValue("@Parola", _Parola_textBox.Text);

            //    int count = cmd.ExecuteNonQuery();

            //    con.Close();
            //    if (count > 0)
            //    {
            //        MessageBox.Show("KAYIT BAŞARIYLA TAMAMLANDI", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //    else
            //    {
            //        MessageBox.Show("KAYIT OLUŞTURULAMADI", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //    Kullanicilar formh = Application.OpenForms.OfType<Kullanicilar>().FirstOrDefault();
            //    if (formh != null)
            //    {
            //        formh.LoadDatakullanici(); // İlk formun veri yükleme metodunu çağır
            //    }

            //    this.Close();




            //}



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
                //string insertquery = "INSERT INTO PERSONELFORMYETKILERI(YetkiID,Yetki,KULLANICIID,FormID) VALUES(@Yid,@Yetki,@Kid,@Fid);