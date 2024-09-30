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
//using WindowsFormsAppSelll.ENTITY;
using Database.Entity;
namespace WindowsFormsAppSelll.KULLANICI
{
    public partial class YetkileriGor : Form
    {
        DataTable dt;
        
        private int kullaniciID;
        public YetkileriGor(int userID)
        {
            InitializeComponent();
            kullaniciID = userID;
            //LoadYetkiler();
        }
       

        private void YetkileriGor_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-99R82DT;Initial Catalog=_HASTANE;Integrated Security=True;Encrypt=False"))
            {
                string query = @"
        SELECT F.FormID, F.FormAdi, 
        ISNULL(PFY.Yetki, 0) AS Yetki 
        FROM FORMLAR F
        LEFT JOIN PERSONELFORMYETKILERI PFY ON F.FormID = PFY.FormID AND PFY.KULLANICIID = @KullaniciID";

                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.SelectCommand.Parameters.AddWithValue("@KullaniciID", kullaniciID);
                dt = new DataTable();
               
                da.Fill(dt);
                _yetkilerigor_dataGridView.DataSource = dt;

                if (_yetkilerigor_dataGridView.Columns.Contains("FormID"))
                {
                    _yetkilerigor_dataGridView.Columns["FormID"].Visible = false;
                }
                _yetkilerigor_dataGridView.Columns[1].ReadOnly = true;
                _yetkilerigor_dataGridView.RowHeadersVisible = false;
                //FormID değerlerini kontrol et
                foreach (DataRow row in dt.Rows)
                {
                    int formID = row["FormID"] != DBNull.Value ? Convert.ToInt32(row["FormID"]) : -1; // Geçersiz formID
                    bool yetki = row["Yetki"] != DBNull.Value && Convert.ToBoolean(row["Yetki"]); // Varsayılan olarak false kullan

                    // Geçersiz değer kontrolü
                    if (formID <= 0)
                    {
                        MessageBox.Show("Geçersiz FormID: " + formID, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            //using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-99R82DT;Initial Catalog=_HASTANE;Integrated Security=True;Encrypt=False"))
            //{
            //    string query = @"
            //SELECT F.FormID, F.FormAdi, 
            //ISNULL(PFY.Yetki, 0) AS Yetki 
            //FROM FORMLAR F
            //LEFT JOIN PERSONELFORMYETKILERI PFY ON F.FormID = PFY.FormID AND PFY.KULLANICIID = @KullaniciID";

            //    SqlDataAdapter da = new SqlDataAdapter(query, con);
            //    da.SelectCommand.Parameters.AddWithValue("@KullaniciID", kullaniciID);
            //    DataTable dt = new DataTable();
            //    da.Fill(dt);
            //    _yetkilerigor_dataGridView.DataSource = dt;
            //}

        }
       
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == _yetkilerigor_dataGridView.Columns["Yetki"].Index && e.RowIndex >= 0)
            {
                DataGridViewCheckBoxCell checkBoxCell = (DataGridViewCheckBoxCell)_yetkilerigor_dataGridView.Rows[e.RowIndex].Cells["Yetki"];
                checkBoxCell.Value = !(Convert.ToBoolean(checkBoxCell.Value)); // Mevcut değeri tersine çevir
                _yetkilerigor_dataGridView.RefreshEdit(); // Güncellemeleri yansıt
            }
        }
        //private YetkileriGor yetkileriGorForm;
        private void _Kaydet_button_Click(object sender, EventArgs e)
        {
            
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-99R82DT;Initial Catalog=_HASTANE;Integrated Security=True;Encrypt=False"))
            {
                con.Open();
                foreach (DataRow row in dt.Rows)
                {
                    int formID = Convert.ToInt32(row["FormID"]);
                    bool yetki = Convert.ToBoolean(row["Yetki"]);

                    if (formID <= 0)
                    {
                        MessageBox.Show("Geçersiz FormID: " + formID, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Önce kayıt var mı kontrol et
                    string selectQuery = "SELECT COUNT(*) FROM PERSONELFORMYETKILERI WHERE KULLANICIID = @KullaniciID AND FormID = @FormID";
                    SqlCommand selectCmd = new SqlCommand(selectQuery, con);
                    selectCmd.Parameters.AddWithValue("@KullaniciID", kullaniciID);
                    selectCmd.Parameters.AddWithValue("@FormID", formID);

                    int recordCount = (int)selectCmd.ExecuteScalar();

                    if (recordCount > 0)
                    {
                        // Kayıt varsa güncelle
                        string updateQuery = "UPDATE PERSONELFORMYETKILERI SET Yetki = @Yetki WHERE KULLANICIID = @KullaniciID AND FormID = @FormID";
                        SqlCommand updateCmd = new SqlCommand(updateQuery, con);
                        updateCmd.Parameters.AddWithValue("@Yetki", yetki);
                        updateCmd.Parameters.AddWithValue("@KullaniciID", kullaniciID);
                        updateCmd.Parameters.AddWithValue("@FormID", formID);
                        updateCmd.ExecuteNonQuery();
                    }
                    else
                    {
                        // Kayıt yoksa yeni kayıt ekle
                        string insertQuery = "INSERT INTO PERSONELFORMYETKILERI (KULLANICIID, FormID, Yetki) VALUES (@KullaniciID, @FormID, @Yetki)";
                        SqlCommand insertCmd = new SqlCommand(insertQuery, con);
                        insertCmd.Parameters.AddWithValue("@KullaniciID", kullaniciID);
                        insertCmd.Parameters.AddWithValue("@FormID", formID);
                        insertCmd.Parameters.AddWithValue("@Yetki", yetki);
                        insertCmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Kayıt başarıyla tamamlandı.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
           
            this.Close();
            //using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-99R82DT;Initial Catalog=_HASTANE;Integrated Security=True;Encrypt=False"))
            //{
            //    con.Open();
            //    foreach ( DataRow row in dt.Rows)
            //    {
            //        int formID = Convert.ToInt32(row["FormID"]);
            //        bool yetki = Convert.ToBoolean(row["Yetki"]);

            //        if (formID <= 0)
            //        {
            //            MessageBox.Show("Geçersiz FormID: " + formID, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //            return;
            //        }

            //        // Yetkileri güncelle veya ekle
            //        //string query = /*@*/"UPDATE PERSONELFORMYETKILERI SET Yetki = @Yetki WHERE KULLANICIID = @KullaniciID AND FormID = @FormID";

            //        string query =  "UPDATE PERSONELFORMYETKILERI SET Yetki = CASE  WHEN Yetki IS NULL THEN 0  ELSE @Yetki  END WHERE KULLANICIID = @KullaniciID AND FormID = @FormID";





            //        SqlCommand cmd = new SqlCommand(query, con);
            //        cmd.Parameters.AddWithValue("@KullaniciID", kullaniciID);
            //        cmd.Parameters.AddWithValue("@FormID", formID);
            //        cmd.Parameters.AddWithValue("@Yetki", yetki);
            //        cmd.ExecuteNonQuery();
            //    }

            //    MessageBox.Show("KAYIT BAŞARIYLA TAMAMLANDI", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    //Main mmm = new Main(kullaniciID);
            //    //mmm.Activate();

            //}    

            //this.Close();

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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
