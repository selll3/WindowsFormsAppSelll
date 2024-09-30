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
using Database.Entity;

namespace WindowsFormsAppSelll
{
    public partial class DoktorGuncelle : Form
    {


        SqlConnection con = new SqlConnection("Data Source=DESKTOP-99R82DT;Initial Catalog=_HASTANE;Integrated Security=True;Encrypt=False");
        SqlDataAdapter da;
        DataTable dt;
        int selectedDoctorID;
        int selectedPersonelID; 
        public DoktorGuncelle()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {

            dt = new DataTable();
            string readQuery = "Select DoktorID, DoktorAdi, DoktorSoyadi, PersonelID from DOKTORLAR";
            da = new SqlDataAdapter(readQuery, con);
            da.Fill(dt);
            _DoktorlarGuncelle_dataGridView.DataSource = dt;

            // DataGridView verileri yüklendikten sonra sütunları gizle
            if (_DoktorlarGuncelle_dataGridView.Columns.Contains("DoktorID"))
            {
                _DoktorlarGuncelle_dataGridView.Columns["DoktorID"].Visible = false;
            }
            if (_DoktorlarGuncelle_dataGridView.Columns.Contains("PersonelID"))
            {
                _DoktorlarGuncelle_dataGridView.Columns["PersonelID"].Visible = false;
            }
          
        }

        private void UpdateDoctorAndPersonel(int doctorID, int personelID)
        {
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-99R82DT;Initial Catalog=_HASTANE;Integrated Security=True;Encrypt=False"))
            {
                con.Open();

                // Doktor güncellemesi
                SqlCommand updateDoctorCmd = new SqlCommand(
                    "UPDATE DOKTORLAR SET DoktorAdi = @Dadi, DoktorSoyadi = @Dsoyadi WHERE DoktorID = @Did", con);

                // Personel güncellemesi
                SqlCommand updatePersonelCmd = new SqlCommand(
                    "UPDATE PERSONEL SET PersonelAdi = @Dadi, PersonelSoyadi = @Dsoyadi WHERE PERSONELID = @Pid AND PersonelGorev = 'Doktor'", con);

                // Seçilen doktoru ve personeli güncelle
                var selectedRow = _DoktorlarGuncelle_dataGridView.Rows.Cast<DataGridViewRow>()
                    .FirstOrDefault(row => Convert.ToInt32(row.Cells["DoktorID"].Value) == doctorID);



                if (selectedRow != null)
                {
                    string doktorAdi = selectedRow.Cells["DoktorAdi"].Value?.ToString();
                    string doktorSoyadi = selectedRow.Cells["DoktorSoyadi"].Value?.ToString();

                    // Doktor güncelleme parametreleri
                    updateDoctorCmd.Parameters.AddWithValue("@Dadi", doktorAdi ?? (object)DBNull.Value);
                    updateDoctorCmd.Parameters.AddWithValue("@Dsoyadi", doktorSoyadi ?? (object)DBNull.Value);
                    updateDoctorCmd.Parameters.AddWithValue("@Did", doctorID);

                    // Personel güncelleme parametreleri
                    updatePersonelCmd.Parameters.AddWithValue("@Dadi", doktorAdi ?? (object)DBNull.Value);
                    updatePersonelCmd.Parameters.AddWithValue("@Dsoyadi", doktorSoyadi ?? (object)DBNull.Value);
                    updatePersonelCmd.Parameters.AddWithValue("@Pid", personelID);

                    // Veritabanında güncelleme işlemleri
                    updateDoctorCmd.ExecuteNonQuery();
                    updatePersonelCmd.ExecuteNonQuery();

                    MessageBox.Show("Doktor ve Personel bilgileri başarıyla güncellendi.");
                }

               

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
            if (selectedDoctorID == 0 || selectedPersonelID == 0) // Doktor veya personel seçilmemişse
            {
                MessageBox.Show("Lütfen bir doktor seçin.");
                return;
            }

            // Doktor ve personel bilgilerini güncelle
            UpdateDoctorAndPersonel(selectedDoctorID, selectedPersonelID);

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
                selectedDoctorID = Convert.ToInt32(_DoktorlarGuncelle_dataGridView.Rows[e.RowIndex].Cells["DOKTORID"].Value);
                selectedPersonelID = Convert.ToInt32(_DoktorlarGuncelle_dataGridView.Rows[e.RowIndex].Cells["PERSONELID"].Value); // PersonelID'yi de al
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
