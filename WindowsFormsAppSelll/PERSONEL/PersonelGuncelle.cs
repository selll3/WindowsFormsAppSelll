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
    public partial class PersonelGuncelle : Form
    {

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-99R82DT;Initial Catalog=_HASTANE;Integrated Security=True;Encrypt=False");
        SqlDataAdapter daPG;
        DataTable dtPG;
        int selectedDoctorID;
        public PersonelGuncelle()
        {
            InitializeComponent();
            LoadDataP();
        }
        private void LoadDataP()
        {
            dtPG = new DataTable();
            string readQuery = "Select PERSONELID, PersonelAdi,PersonelSoyadi, PersonelGorev,KULLANICIID from PERSONEL";
            daPG = new SqlDataAdapter(readQuery, con);
            daPG.Fill(dtPG);
            _personelguncelle_dataGridView.DataSource = dtPG;

            // DataGridView verileri yüklendikten sonra sütunları gizle
            if (_personelguncelle_dataGridView.Columns.Contains("PERSONELID"))
            {
                _personelguncelle_dataGridView.Columns["PERSONELID"].Visible = false;
            }
        }
        private void UpdateDoctorInfo(int personelID)
        {
            // İlgili doktor güncelleme işlemleri
            if (IsDoctor(personelID))
            {
                using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-99R82DT;Initial Catalog=_HASTANE;Integrated Security=True;Encrypt=False"))
                {
                    con.Open();

                    // Doktor güncelleme sorgusu
                    SqlCommand updateDoctorCmd = new SqlCommand("UPDATE DOKTORLAR SET DoktorAdi = @Padi, DoktorSoyadi = @Psoyadi WHERE PersonelID = @Pid", con);
                    var selectedRow = _personelguncelle_dataGridView.Rows.Cast<DataGridViewRow>()
                        .FirstOrDefault(row => Convert.ToInt32(row.Cells["PERSONELID"].Value) == personelID);

                    if (selectedRow != null)
                    {
                        updateDoctorCmd.Parameters.AddWithValue("@Padi", selectedRow.Cells["PersonelAdi"].Value ?? (object)DBNull.Value);
                        updateDoctorCmd.Parameters.AddWithValue("@Psoyadi", selectedRow.Cells["PersonelSoyadi"].Value ?? (object)DBNull.Value);
                        updateDoctorCmd.Parameters.AddWithValue("@Pid", personelID);

                        updateDoctorCmd.ExecuteNonQuery();
                    }
                }
            }
        }

        private bool IsDoctor(int personelID)
        {
            // Personelin doktor olup olmadığını kontrol et
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-99R82DT;Initial Catalog=_HASTANE;Integrated Security=True;Encrypt=False"))
            {
                con.Open();
                SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM PERSONEL WHERE PERSONELID = @Pid AND PersonelGorev = 'Doktor'", con);
                checkCmd.Parameters.AddWithValue("@Pid", personelID);
                return (int)checkCmd.ExecuteScalar() > 0;
            }
        }
        //private void UpdateDoctorInfo(int personelID)
        //{
        //    using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-99R82DT;Initial Catalog=_HASTANE;Integrated Security=True;Encrypt=False"))
        //    {
        //        con.Open();

        //        // İlk olarak personelin doktor olup olmadığını kontrol edelim
        //        SqlCommand checkCmd = new SqlCommand("SELECT PersonelGorev FROM PERSONEL WHERE PERSONELID = @Pid", con);
        //        checkCmd.Parameters.AddWithValue("@Pid", personelID);
        //        string personelGorev = (string)checkCmd.ExecuteScalar();
        //        SqlCommand updateDoctorCmd = new SqlCommand(
        //        "UPDATE DOKTORLAR SET DoktorAdi = @Padi, DoktorSoyadi = @Psoyadi WHERE PersonelID = @Pid", con);

        //        // Eğer personelin görevi doktorsa, doktorlar tablosunu güncelleyelim
        //        if (personelGorev == "Doktor")
        //        {
        //            foreach (DataGridViewRow row in _personelguncelle_dataGridView.Rows)
        //            {
        //                if (Convert.ToInt32(row.Cells["PERSONELID"].Value) == selectedDoctorID)
        //                {
        //                    updateDoctorCmd.Parameters.AddWithValue("@Padi", row.Cells["PersonelAdi"].Value ?? (object)DBNull.Value);
        //                    updateDoctorCmd.Parameters.AddWithValue("@Psoyadi", row.Cells["PersonelSoyadi"].Value ?? (object)DBNull.Value);
        //                    //updateDoctorCmd.Parameters.AddWithValue("@PGorev", row.Cells["PersonelGorev"].Value ?? (object)DBNull.Value);
        //                    updateDoctorCmd.Parameters.AddWithValue("@Pid", selectedDoctorID);

        //                    updateDoctorCmd.ExecuteNonQuery();
        //                    break;
        //                }
        //            }

        //        }
        //    }
        //}
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

        private void PersonelGuncelle_Load(object sender, EventArgs e)
        {
            _personelguncelle_dataGridView.RowHeadersVisible = false;
        }

        private void _kaydet_button_Click(object sender, EventArgs e)
        {

            if (selectedDoctorID == 0) // ID seçilmemişse
            {
                MessageBox.Show("Lütfen bir Personel seçin.");
                return;
            }

            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-99R82DT;Initial Catalog=_HASTANE;Integrated Security=True;Encrypt=False"))
            {
                con.Open();
                // Personel bilgilerini güncelle
                SqlCommand cmd = new SqlCommand("UPDATE PERSONEL SET PersonelAdi = @Padi, PersonelSoyadi = @Psoyadi, PersonelGorev = @PGorev WHERE PERSONELID = @Pid", con);

                var selectedRow = _personelguncelle_dataGridView.Rows.Cast<DataGridViewRow>()
                    .FirstOrDefault(row => Convert.ToInt32(row.Cells["PERSONELID"].Value) == selectedDoctorID);

                if (selectedRow != null)
                {
                    cmd.Parameters.AddWithValue("@Padi", selectedRow.Cells["PersonelAdi"].Value ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Psoyadi", selectedRow.Cells["PersonelSoyadi"].Value ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@PGorev", selectedRow.Cells["PersonelGorev"].Value ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Pid", selectedDoctorID);

                    cmd.ExecuteNonQuery();
                    UpdateDoctorInfo(selectedDoctorID);
                }
            }

            // İlk formu güncelle ve göster
            Personeller formpers = (Personeller)Application.OpenForms["Personeller"];
            formpers.LoadDataIntoGridp(); // İlk formun veri yükleme metodunu çağır
            this.Close();
            //if (selectedDoctorID == 0) // ID seçilmemişse
            //{
            //    MessageBox.Show("Lütfen bir Personel seçin.");
            //    return;
            //}

            //con.Open();
            //SqlCommand cmd = new SqlCommand("UPDATE PERSONEL SET PersonelAdi = @Padi, PersonelSoyadi = @Psoyadi, PersonelGorev = @PGorev WHERE PERSONELID = @Pid", con);

            //// Sütunlardaki verileri güncelle
            //foreach (DataGridViewRow row in _personelguncelle_dataGridView.Rows)
            //{
            //    if (Convert.ToInt32(row.Cells["PERSONELID"].Value) == selectedDoctorID)
            //    {
            //        cmd.Parameters.AddWithValue("@Padi", row.Cells["PersonelAdi"].Value ?? (object)DBNull.Value);
            //        cmd.Parameters.AddWithValue("@Psoyadi", row.Cells["PersonelSoyadi"].Value ?? (object)DBNull.Value);
            //        cmd.Parameters.AddWithValue("@PGorev", row.Cells["PersonelGorev"].Value ?? (object)DBNull.Value);
            //        cmd.Parameters.AddWithValue("@Pid", selectedDoctorID);

            //        cmd.ExecuteNonQuery();
            //        break;
            //    }
            //}
            // UpdateDoctorInfo(selectedDoctorID);
            //con.Close();

            //// İlk formu güncelle ve göster
            //Personeller formpers = (Personeller)Application.OpenForms["Personeller"];
            //formpers.LoadDataIntoGridp(); // İlk formun veri yükleme metodunu çağır
            //this.Close();
        }

        private void _personelguncelle_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && _personelguncelle_dataGridView.Rows.Count > 0)
            {
                selectedDoctorID = Convert.ToInt32(_personelguncelle_dataGridView.Rows[e.RowIndex].Cells["PERSONELID"].Value);
            }
        }
    }
}
