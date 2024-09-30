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
using WindowsFormsAppSelll.MUAYENE;
using Database.Entity;

namespace WindowsFormsAppSelll
{
    public partial class MuayeneEkle : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-99R82DT;Initial Catalog=_HASTANE;Integrated Security=True;Encrypt=False");
        SqlDataAdapter da;
        DataTable dt;

        private int hid;
        public MuayeneEkle(int hastaId)
        {
            InitializeComponent();
            hid = hastaId;
            LoadDataIntoRandevu(hastaId);

        }
       
        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void LoadDataIntoRandevu(int hastaId)
        {
            dt = new DataTable();

            // Hasta ID'sine göre randevu bilgilerini al
            string readQuery = "SELECT RANDEVUID, Randevu_Tarihi, Randevu_Saati, DOKTORID, Bulgu, HASTAID FROM RANDEVULAR WHERE HASTAID = @HastaID AND Randevu_Tarihi <  CONVERT(DATE, GETDATE());";

            using (SqlCommand cmd = new SqlCommand(readQuery, con))
            {
                cmd.Parameters.AddWithValue("@HastaID", hastaId);

                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(dt);
                }
            }

            dataGridView1.DataSource = dt;

            // RANDEVUID sütununu gizle
            if (dataGridView1.Columns.Contains("RANDEVUID"))
            {
                dataGridView1.Columns["RANDEVUID"].Visible = false;
            }

        }
        private void FillComboSeachCode( int hastaId)
        {
            _DoktorBilgisi_comboBox.Items.Clear();
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-99R82DT;Initial Catalog=_HASTANE;Integrated Security=True;Encrypt=False");
            con.Open();
            SqlCommand Komut = new SqlCommand();
            Komut = con.CreateCommand();
            Komut.CommandType = CommandType.Text;
            Komut.CommandText = "Select DOKTORID, DoktorAdi +' ' + DoktorSoyadi as ADSOYAD  from DOKTORLAR";
            Komut.Parameters.AddWithValue("@HastaID", hastaId);
            Komut.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(Komut);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                //comboBox1.Items.Add(dr["DoktorAdi"].ToString());


                _DoktorBilgisi_comboBox.DataSource = dt;
                _DoktorBilgisi_comboBox.ValueMember = "DOKTORID";
                _DoktorBilgisi_comboBox.DisplayMember = "ADSOYAD";

            }
            con.Close();


        }
        private void FillComboSearchRandevu(/*int hastaId*/)
        {
            //_RandevuBilgisi_comboBox.Items.Clear();
            //SqlConnection con = new SqlConnection("Data Source=DESKTOP-99R82DT;Initial Catalog=_HASTANE;Integrated Security=True;Encrypt=False");
            //con.Open();
            //SqlCommand Komut = new SqlCommand();
            //Komut = con.CreateCommand();
            //Komut.CommandType = CommandType.Text;
            //Komut.CommandText = "SELECT Randevu_Tarihi, Randevu_Saati FROM RANDEVULAR WHERE HASTAID = @HastaID";
            ////Komut.Parameters.AddWithValue("@HastaID", hastaId);
            //Komut.ExecuteNonQuery();
            //DataTable dt = new DataTable();
            //SqlDataAdapter da = new SqlDataAdapter(Komut);
            //da.Fill(dt);
            //foreach (DataRow dr in dt.Rows)
            //{
            //    //comboBox1.Items.Add(dr["DoktorAdi"].ToString());


            //    _RandevuBilgisi_comboBox.DataSource = dt;
            //    _RandevuBilgisi_comboBox.ValueMember = "RANDEVUID";
            //    _RandevuBilgisi_comboBox.DisplayMember = "Randevu_Tarihi";

            //}
            //con.Close();
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


        

        private void MuayeneEkle_Load(object sender, EventArgs e)
        {

            //FillComboSearchRandevu(hid);
            dataGridView1.RowHeadersVisible = false;
            FillComboSearchHasta();
           
            FillComboSeachCode(hid);
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

            if (isAnyEmpty && dateTimePicker1.Value.Date == null)
            {
                MessageBox.Show("Doldurmalısın!!", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else {     
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-99R82DT;Initial Catalog=_HASTANE;Integrated Security=True;Encrypt=False");
            string insertQuery = "INSERT INTO MUAYENE(HASTAID,DOKTORID,Aciklama,islendiBilgisi,MuayeneTarihi) VALUES(@Hid,@Did,@Aciklama,@islendiBilgisi,@mTarihi)";
            con.Open();
            SqlCommand cmd = new SqlCommand(insertQuery, con);

            //cmd.Parameters.AddWithValue("@Mid", _DoktorBilgisi_comboBox.SelectedValue);
            //cmd.Parameters.AddWithValue("@Rid", _RandevuBilgisi_comboBox.SelectedValue);
            cmd.Parameters.AddWithValue("@Hid", _HastaBilgisi_comboBox.SelectedValue);
            cmd.Parameters.AddWithValue("@Did", _DoktorBilgisi_comboBox.SelectedValue);
            cmd.Parameters.AddWithValue("@Aciklama", _aciklama_textBox.Text);
            cmd.Parameters.AddWithValue("@islendiBilgisi", _islendi.Checked);
            cmd.Parameters.AddWithValue("@mTarihi",dateTimePicker1.Value.Date);
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
            Muayeneler form1 = Application.OpenForms.OfType<Muayeneler>().FirstOrDefault();
            if (form1 != null)
            {
                form1.LoadDataMuayene(); // İlk formun veri yükleme metodunu çağır
            }

            this.Close();
        }

        private void _HastaBilgisi_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_HastaBilgisi_comboBox.SelectedItem != null)
            {
                DataRowView selectedRow = (DataRowView)_HastaBilgisi_comboBox.SelectedItem;
                int hastaId = Convert.ToInt32(selectedRow["HASTAID"]); // HASTAID'yi al

                LoadDataIntoRandevu(hastaId); // Fonksiyonu çağır
            }

        }

        private void _HastaBilgisi_comboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void _RandevuBilgisi_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
