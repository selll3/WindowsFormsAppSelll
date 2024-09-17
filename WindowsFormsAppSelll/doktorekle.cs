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
    public partial class doktorekle : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-99R82DT;Initial Catalog=_HASTANE;Integrated Security=True;Encrypt=False");
        SqlDataAdapter da;
        DataTable dt;


        public doktorekle()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            dt = new DataTable();
            string readQuery = "SELECT DoktorAdi, DoktorSoyadi, DoktorunBransi, Doktorun_kati FROM DOKTORLAR WHERE DOKTORID = 0";
            da = new SqlDataAdapter(readQuery, con);
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            // DOKTORID sütununu gizle
            if (dataGridView1.Columns.Contains("DOKTORID"))
            {
                dataGridView1.Columns["DOKTORID"].Visible = false;
            }
        }
        private void doktorekle_Load(object sender, EventArgs e)
        {

        }

        private void _kaydet_button_Click(object sender, EventArgs e)
        {
            con.Open();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                //dataGridView1.Columns["DOKTORID"].Visible = false;
                if (!row.IsNewRow) // Yeni satır değilse
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO DOKTORLAR (DoktorAdi, DoktorSoyadi, DoktorunBransi, Doktorun_kati) VALUES (@adi, @soyadi, @brans, @kat)", con);
                    cmd.Parameters.AddWithValue("@adi", row.Cells["DoktorAdi"].Value ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@soyadi", row.Cells["DoktorSoyadi"].Value ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@brans", row.Cells["DoktorunBransi"].Value ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@kat", row.Cells["Doktorun_kati"].Value ?? (object)DBNull.Value);

                    cmd.ExecuteNonQuery();
                }
            }
            con.Close();

            // İlk formu güncelle ve göster
            Doktorlar form1 = Application.OpenForms.OfType<Doktorlar>().FirstOrDefault();
            if (form1 != null)
            {
                form1.LoadDataIntoGrid(); // İlk formun veri yükleme metodunu çağır
            }

            this.Close();
        }
    }
    
}
