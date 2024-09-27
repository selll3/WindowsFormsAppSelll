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

namespace WindowsFormsAppSelll.MUAYENE
{
    public partial class DMuayeneleriAyrinti : Form
    {
        private int hastaID;
        public DMuayeneleriAyrinti(int _hastaID)
        {
            InitializeComponent();
            hastaID = _hastaID; // Hasta ID'sini form yüklenirken alıyoruz
            LoadHastaBilgileri();
        }
        private void LoadHastaBilgileri()
        {
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-99R82DT;Initial Catalog=_HASTANE;Integrated Security=True;Encrypt=False"))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM HASTALAR WHERE HASTAID = @hastaID", con);
                cmd.Parameters.AddWithValue("@hastaID", hastaID);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    _hastaAdi_textBox.Text = reader["HastaAdi"].ToString();
                    _hastaSoyadi_textBox.Text = reader["HastaSoyadi"].ToString();
                   
                    _hastaYasi_textBox.Text = reader["HastaYasi"].ToString();

                }
            }
        }
        private void DMuayeneleriAyrinti_Load(object sender, EventArgs e)
        {

        }

        private void _Vazgec_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
