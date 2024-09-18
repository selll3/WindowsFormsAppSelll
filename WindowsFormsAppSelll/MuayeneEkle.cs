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

namespace WindowsFormsAppSelll
{
    public partial class MuayeneEkle : Form
    {
        public MuayeneEkle()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void FillComboSeachCode()
        {
            _DoktorBilgisi_comboBox.Items.Clear();
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


                _DoktorBilgisi_comboBox.DataSource = dt;
                _DoktorBilgisi_comboBox.ValueMember = "DOKTORID";
                _DoktorBilgisi_comboBox.DisplayMember = "ADSOYAD";

            }
            con.Close();


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

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-99R82DT;Initial Catalog=_HASTANE;Integrated Security=True;Encrypt=False");
            string insertQuery = "INSERT INTO MUAYENE(MUAYENEID,RANDEVUID,HASTAID,DOKTORID,Aciklama) VALUES(@Mid, @Rid, @Hid,@Did)";
            con.Open();
            SqlCommand cmd = new SqlCommand(insertQuery, con);

            cmd.Parameters.AddWithValue("@Mid", _DoktorBilgisi_comboBox.SelectedValue);
            cmd.Parameters.AddWithValue("@Rid", _DoktorBilgisi_comboBox.SelectedValue);
            cmd.Parameters.AddWithValue("@Hid", _DoktorBilgisi_comboBox.SelectedValue);
            cmd.Parameters.AddWithValue("@Did", _DoktorBilgisi_comboBox.SelectedValue);

        }

        private void _HastaBilgisi_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
