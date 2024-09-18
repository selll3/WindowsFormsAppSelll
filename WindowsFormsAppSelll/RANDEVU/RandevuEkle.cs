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
    public partial class RandevuEkle : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-99R82DT;Initial Catalog=_HASTANE;Integrated Security=True;Encrypt=False");
        SqlDataAdapter daRE;
        DataTable dtRE;
        public RandevuEkle()
        {
            InitializeComponent();
            //LoadDataRE();
        }
        //private void LoadDataRE()
        //{
        //    Hastanedb dbre = new Hastanedb();
        //    _randevuekle_dataGridView.DataSource = dbre.RANDEVULAR.ToList();
        //    //dtRE = new DataTable();
        //    //string readQuery = "SELECT PERSONELID, PersonelAdi,PersonelSoyadi, PersonelGorev from PERSONEL WHERE PERSONELID = 0";
        //    //daRE = new SqlDataAdapter(readQuery, con);
        //    //daRE.Fill(dtRE);
        //    //_randevuekle_dataGridView.DataSource = dtRE;

        //    //// DOKTORID sütununu gizle
        //    if (_randevuekle_dataGridView.Columns.Contains("RANDEVUID"))
        //    {
        //        _randevuekle_dataGridView.Columns["RANDEVUID"].Visible = false;
        //    }
        //}
        private void _randevuekle_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FillComboSeachCode()
        {
            _doktorBilgisi_comboBox.Items.Clear();
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
            foreach (DataRow dr in dt.Rows)
            {
                //comboBox1.Items.Add(dr["DoktorAdi"].ToString());


                _doktorBilgisi_comboBox.DataSource = dt;
                _doktorBilgisi_comboBox.ValueMember = "DOKTORID";
                _doktorBilgisi_comboBox.DisplayMember = "ADSOYAD";

            }
            con.Close();


        }

        private void _vazgec_button_Click(object sender, EventArgs e)
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

        private void _kaydet_button_Click(object sender, EventArgs e)
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
                string insertQuery = "INSERT INTO RANDEVULAR(Randevu_Tarihi,Randevu_Saati,Bulgu,DOKTORID) VALUES(@RandevuTarihi, @RandevuSaati, @bulgu,@Doktorid) ";
                con.Open();
                SqlCommand cmd = new SqlCommand(insertQuery, con);
                SqlCommand bilg = new SqlCommand(insertQuery, con);

                cmd.Parameters.AddWithValue("@RandevuTarihi", _RandevuTarihi_dateTimePicker.Value.Date);
                cmd.Parameters.AddWithValue("@RandevuSaati", _RandevuSaati_dateTimePicker.Value);
                cmd.Parameters.AddWithValue("@bulgu", _Bulgu_textBox.Text);
                cmd.Parameters.AddWithValue("@Doktorid", _doktorBilgisi_comboBox.SelectedValue);
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



            //    con.Open();
            //    foreach (DataGridViewRow row in _randevuekle_dataGridView.Rows)
            //    {
            //        //dataGridView1.Columns["DOKTORID"].Visible = false;
            //        if (!row.IsNewRow) // Yeni satır değilse
            //        {
            //            SqlCommand cmd = new SqlCommand("INSERT INTO PERSONEL ( PersonelAdi,PersonelSoyadi, PersonelGorev) VALUES (@Padi, @Psoyadi, @PGorev)", con);
            //            cmd.Parameters.AddWithValue("@Padi", row.Cells["PersonelAdi"].Value ?? (object)DBNull.Value);
            //            cmd.Parameters.AddWithValue("@Psoyadi", row.Cells["PersonelSoyadi"].Value ?? (object)DBNull.Value);
            //            cmd.Parameters.AddWithValue("@PGorev", row.Cells["PersonelGorev"].Value ?? (object)DBNull.Value);


            //            cmd.ExecuteNonQuery();
            //        }
            //    }
            //    con.Close();

            //    // İlk formu güncelle ve göster
            //    Randevular formr = Application.OpenForms.OfType<Randevular>().FirstOrDefault();
            //    if (formr != null)
            //    {
            //        formr.LoadDataIntoGridr(); // İlk formun veri yükleme metodunu çağır
            //    }

            //    this.Close();
        }
        private void FillComboSearchHasta()
        {
            _HastaBilgisi_comboBox.Items.Clear();
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-99R82DT;Initial Catalog=_HASTANE;Integrated Security=True;Encrypt=False");
            con.Open();
            SqlCommand Komut = new SqlCommand();
            Komut = con.CreateCommand();
            Komut.CommandType = CommandType.Text;
            Komut.CommandText = "Select HASTAID, HastaAdi +' ' + HastaSoyadi as ADSOYAD  from HASTALAR";
            Komut.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(Komut);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                //comboBox1.Items.Add(dr["DoktorAdi"].ToString());


                _HastaBilgisi_comboBox.DataSource = dt;
                _HastaBilgisi_comboBox.ValueMember = "HASTAID";
                _HastaBilgisi_comboBox.DisplayMember = "ADSOYAD";

            }
            con.Close();


        }
        private void RandevuEkle_Load(object sender, EventArgs e)
        {
            FillComboSeachCode();
            FillComboSearchHasta();
        }

        private void _RandevuTarihi_dateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void _HastaBilgisi_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
