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

namespace WindowsFormsAppSelll.MUAYENE
{
    public partial class Muayeneler : Form
    {
        //    SqlConnection con = new SqlConnection("Data Source=DESKTOP-99R82DT;Initial Catalog=_HASTANE;Integrated Security=True;Encrypt=False");
        //    SqlDataAdapter dM;
        //    DataTable dtM;
        private int Hid;
        public Muayeneler(int hastaid )
        {
            InitializeComponent();
            LoadDataMuayene();
            Hid = hastaid;
        }
        public void LoadDataMuayene()
        {
            //Hastanedb dp = new Hastanedb();
            //dataGridView1.DataSource = dp.MUAYENE.ToList();

            Hastanedb dbm = new Hastanedb();
            dataGridView1.DataSource = dbm.MUAYENE
                .Select(r => new
                {
                    r.MUAYENEID,  // İstediğin sütunları buraya ekleyebilirsin
                    r.MuayeneTarihi,
                    r.Aciklama,
                    r.DOKTORID,
                    r.HASTAID,
                    r.islendiBilgisi
                    
                    // r.Bulgu gibi başka sütunlar da ekleyebilirsin
                }).ToList();

            //dtM = new DataTable();
            //string readQuery = "SELECT MUAYENEID,DOKTORID,HASTAID,Aciklama,islendiBilgisi FROM MUAYENE";
            //dM = new SqlDataAdapter(readQuery, con);
            //dM.Fill(dtM);
            //dataGridView1.DataSource = dM;

            //if (dataGridView1.Columns.Contains("MUAYENEID"))
            //{
            //    dataGridView1.Columns["MUAYENEID"].Visible = false;
            //}

        }
        private void Muayeneler_Load(object sender, EventArgs e)
        {

        }

        private void _Ekle_button_Click(object sender, EventArgs e)
        {
            MuayeneEkle mekle = new MuayeneEkle(Hid);
            mekle.Show();
        }

        private void vazgec_button_Click(object sender, EventArgs e)
        {
            //foreach (Control control in this.Controls)
            //{
            //    if (control is TextBox)
            //    {
            //        control.Text = string.Empty;
            //    }
            //}

            // Formu kapat
            this.Close();
        }
    }
}
