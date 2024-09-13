using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsAppSelll.ENTITY;


namespace WindowsFormsAppSelll
{
    public partial class Randevu_ekle : Form
    {
        public Randevu_ekle()
        {
            InitializeComponent();
        }
       
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Bulgu_label_Click(object sender, EventArgs e)
        {

        }

        private void _saat_label_Click(object sender, EventArgs e)
        {

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
               // // RANDEVULAR rdv = new RANDEVULAR();
               //  //rdv.Randevu_Tarihi =_RandevuTarihi_textBox.Text ;
               // // rdv.Randevu_Saati = _RandevuSaati_textBox.Text;
               //// rdv.Bulgu =_Bulgu_textBox.Text ;
               //// Convert.ToDateTime

               //  Hastanedb dbr = new Hastanedb();

               //  dbr.RANDEVULAR.Add(rdv);
               //  dbr.SaveChanges();

                
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-99R82DT;Initial Catalog=_HASTANE;Integrated Security=True;Encrypt=False");
                string insertQuery = "INSERT INTO RANDEVULAR(Randevu_Tarihi,Randevu_Saati,Bulgu,DOKTORID) VALUES(@RandevuTarihi, @RandevuSaati, @bulgu,@Doktorid) ";
                con.Open();
                SqlCommand cmd = new SqlCommand(insertQuery, con);
                SqlCommand bilg = new SqlCommand(insertQuery, con);
               
                cmd.Parameters.AddWithValue("@RandevuTarihi", dateTimePicker1.Value.Date);
                cmd.Parameters.AddWithValue("@RandevuSaati", dateTimePicker2.Value);
                cmd.Parameters.AddWithValue("@bulgu",_Bulgu_textBox.Text);
                cmd.Parameters.AddWithValue("@Doktorid",comboBox1.SelectedValue);
                //date time picker
               
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

        private void _Bulgu_textBox_TextChanged(object sender, EventArgs e)
        {

        }

       
        private void FillComboSeachCode()
        {
            comboBox1.Items.Clear();
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-99R82DT;Initial Catalog=_HASTANE;Integrated Security=True;Encrypt=False");
            con.Open();
            SqlCommand Komut = new SqlCommand();
            Komut = con.CreateCommand();
            Komut.CommandType = CommandType.Text;
            Komut.CommandText = "Select DOKTORID, DoktorAdi +' ' + DoktorSoyadi as ADSOYAD  from DOKTORLAR";
            Komut.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(Komut);
            da.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                //comboBox1.Items.Add(dr["DoktorAdi"].ToString());
               

                comboBox1.DataSource = dt;
                comboBox1.ValueMember = "DOKTORID";
                comboBox1.DisplayMember = "ADSOYAD";

            }
            con.Close();


        }

       
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
               
                   
                   
                  
         
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void Randevu_ekle_Load(object sender, EventArgs e)
        {
            FillComboSeachCode();
        }
    }
}
