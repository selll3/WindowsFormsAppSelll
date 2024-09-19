using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsAppSelll.YETKI
{
    public partial class YetkiliEkle : Form
    {
        public YetkiliEkle()
        {
            InitializeComponent();
        }
        private void LoadPersonelList()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-99R82DT;Initial Catalog=_HASTANE;Integrated Security=True;Encrypt=False");
            // PERSONEL tablosundan verileri çekme
            SqlCommand cmd = new SqlCommand("SELECT PERSONELID, PersonelAd FROM PERSONEL", con);
            //SqlCommand cmd= "SELECT PERSONELID, PersonelAd FROM PERSONEL";
            // Veritabanı bağlantısı ve veri çekme işlemleri
            // PersonelID ve Adları ComboBox'a ekleme
        }

        private void FillComboSearchCodeform()
        {
            _formlar_comboBox.Items.Clear();
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-99R82DT;Initial Catalog=_HASTANE;Integrated Security=True;Encrypt=False");
            con.Open();
            SqlCommand Komut = new SqlCommand();
            Komut = con.CreateCommand();
            Komut.CommandType = CommandType.Text;
            Komut.CommandText = "Select FormID,FormAdi from FORMLAR";
            Komut.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(Komut);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                //comboBox1.Items.Add(dr["DoktorAdi"].ToString());


                _formlar_comboBox.DataSource = dt;
                _formlar_comboBox.ValueMember = "FormID";
               _formlar_comboBox.DisplayMember = "FormAdi";

            }
            con.Close();


        }
        private void FillComboSearchPERSONEL()
        {
            _personel_comboBox.Items.Clear();
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-99R82DT;Initial Catalog=_HASTANE;Integrated Security=True;Encrypt=False");
            con.Open();
            SqlCommand Komut = new SqlCommand();
            Komut = con.CreateCommand();
            Komut.CommandType = CommandType.Text;
            Komut.CommandText = "Select PERSONELID, PersonelAdi +' ' + PersonelSoyadi as ADSOYAD  from PERSONEL";
            Komut.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(Komut);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                //comboBox1.Items.Add(dr["DoktorAdi"].ToString());


                _personel_comboBox.DataSource = dt;
                _personel_comboBox.ValueMember = "PERSONELID";
                _personel_comboBox.DisplayMember = "ADSOYAD";

            }
            con.Close();


        }

        private void Yetkiler_Load(object sender, EventArgs e)
        {
            FillComboSearchCodeform();
            FillComboSearchPERSONEL();
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
                // // RANDEVULAR rdv = new RANDEVULAR();
                //  //rdv.Randevu_Tarihi =_RandevuTarihi_textBox.Text ;
                // // rdv.Randevu_Saati = _RandevuSaati_textBox.Text;
                //// rdv.Bulgu =_Bulgu_textBox.Text ;
                //// Convert.ToDateTime

                //  Hastanedb dbr = new Hastanedb();

                //  dbr.RANDEVULAR.Add(rdv);
                //  dbr.SaveChanges();


                SqlConnection con = new SqlConnection("Data Source=DESKTOP-99R82DT;Initial Catalog=_HASTANE;Integrated Security=True;Encrypt=False");
                string insertQuery = "INSERT INTO PERSONELFORMYETKILERI(FormID,Yetki,PERSONELID) VALUES( @Fid,@Yetki ,@Pid) ";
                con.Open();
                SqlCommand cmd = new SqlCommand(insertQuery, con);
                SqlCommand bilg = new SqlCommand(insertQuery, con);

               
                
                cmd.Parameters.AddWithValue("@Fid", _formlar_comboBox.SelectedValue);
                cmd.Parameters.AddWithValue("@Pid", _personel_comboBox.SelectedValue);
                cmd.Parameters.AddWithValue("@Yetki",true);
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

                // İlk formu güncelle ve göster
                Randevular formr = Application.OpenForms.OfType<Randevular>().FirstOrDefault();
                if (formr != null)
                {
                    formr.LoadDataIntoGridr(); // İlk formun veri yükleme metodunu çağır
                }

                this.Close();



            }
        }
    }
}
