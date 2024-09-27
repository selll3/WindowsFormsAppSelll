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
    public partial class DoktorGuncelle : Form
    {


        SqlConnection con = new SqlConnection("Data Source=DESKTOP-99R82DT;Initial Catalog=_HASTANE;Integrated Security=True;Encrypt=False");
        SqlDataAdapter da;
        DataTable dt;
        int selectedDoctorID;
        public DoktorGuncelle()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            dt = new DataTable();
            string readQuery = "Select DOKTORID, DoktorAdi, DoktorSoyadi from DOKTORLAR";
            da = new SqlDataAdapter(readQuery, con);
            da.Fill(dt);
            _DoktorlarGuncelle_dataGridView.DataSource = dt;

            // DataGridView verileri yüklendikten sonra sütunları gizle
            if (_DoktorlarGuncelle_dataGridView.Columns.Contains("DOKTORID"))
            {
                _DoktorlarGuncelle_dataGridView.Columns["DOKTORID"].Visible = false;
            }
        }
        private void DoktorGuncelle_Load(object sender, EventArgs e)
        {
            _DoktorlarGuncelle_dataGridView.RowHeadersVisible = false;
            // _DoktorlarGuncelle_dataGridView.Columns["DOKTORID"].Visible = false;
        }
        //PERSONEL GÜNCELLENDİĞİNDE DOKTOR GÜNCELLENİYOR MU
        // ARTI OLARAK DOKTOR GÜNCELLENDİĞİNDE PERSONEL GÖREVİ DOKTOR OLANLAR GÜNCELLENİYOR MU
        private void button1_Click(object sender, EventArgs e)
        {
            if (selectedDoctorID == 0) // ID seçilmemişse
            {
                MessageBox.Show("Lütfen bir doktor seçin.");
                return;
            }

            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE DOKTORLAR SET PersonelAdi = @Padi, PersonelSoyadi = @Psoyadi WHERE PersonelGorev='Doktor' and PERSONELID = @id ", con);

            // Sütunlardaki verileri güncelle
            foreach (DataGridViewRow row in _DoktorlarGuncelle_dataGridView.Rows)
            {
                if (Convert.ToInt32(row.Cells["PERSONELID"].Value) == selectedDoctorID)
                {
                    cmd.Parameters.AddWithValue("@Padi", row.Cells["PersonelAdi"].Value ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Psoyadi", row.Cells["PersonelSoyadi"].Value ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@id", selectedDoctorID);

                    cmd.ExecuteNonQuery();
                    break;
                }
            }

            con.Close();

            // İlk formu güncelle ve göster
            Doktorlar form1 = (Doktorlar)Application.OpenForms["Doktorlar"];
            form1.LoadDataIntoGrid(); // İlk formun veri yükleme metodunu çağır
            this.Close();
        }

        private void _DoktorlarGuncelle_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void _DoktorlarGuncelle_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && _DoktorlarGuncelle_dataGridView.Rows.Count > 0)
            {
                selectedDoctorID = Convert.ToInt32(_DoktorlarGuncelle_dataGridView.Rows[e.RowIndex].Cells["PERSONELID"].Value);
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
    }
}
