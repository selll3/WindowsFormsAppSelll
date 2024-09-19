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
    public partial class YetkileriGor : Form
    {
        public YetkileriGor()
        {
            InitializeComponent();
        }

        private void YetkileriGor_Load(object sender, EventArgs e)
        {   Kullanicilar kl = new Kullanicilar();

            //int personelID = Convert.ToInt32(_yetkilerigor_dataGridView.SelectedRows[0].Cells["YetkiID"].Value);
            // Önceki formdan veya kullanıcı seçiminizden al

            // Veritabanı bağlantısı ve sorgu




           
            

               SqlConnection conn = new SqlConnection("Data Source=DESKTOP-99R82DT;Initial Catalog=_HASTANE;Integrated Security=True;Encrypt=False");
               //string insertQuery = "SELECT PERSONELFORMYETKILERI.*, FORM.* FROM PERSONELFORMYETKILERI INNER JOIN FORM ON PERSONELFORMYETKILERI.PERSONELID = FORM.PERSONELID";
                SqlCommand cmd = new SqlCommand("SELECT * FROM View_22", conn);
                conn.Open();
                
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);

                // DataGridView'e veri bağlama
                _yetkilerigor_dataGridView.DataSource = table;
            
        }
       

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
