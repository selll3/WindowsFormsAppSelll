using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using WindowsFormsAppSelll.ENTITY;
using Database.Entity;


namespace WindowsFormsAppSelll
{
    public partial class Randevular : Form
    {
        //SqlConnection con = new SqlConnection("Data Source=DESKTOP-99R82DT;Initial Catalog=_HASTANE;Integrated Security=True;Encrypt=False");
        ////SqlDataAdapter da;
        ////DataTable dt;

        private int currentUserId;
        private Hastanedb dbContext = new Hastanedb();
        public Randevular(int userId)
        {
            InitializeComponent();
            //_Randevular_dataGridView.Visible = false;
            LoadDataIntoGridr();
            currentUserId = userId;
            yetkileriolustur();

        }

        private void yetkileriolustur()
        {
            
            var userPermissions = dbContext.PERSONELFORMYETKILERI
                                           .Where(p => p.KULLANICIID == currentUserId && p.Yetki == true)
                                           .ToList();

            
            foreach (var permission in userPermissions)
            {
                switch (permission.FormID)
                {
                    case 11:  
                        _Ekle_button.Enabled = true;
                        break;
                    case 12:  
                        _GUNCELLE_button.Enabled = true;
                        _Sil_button.Enabled = true;
                        break;


                        
                }
            }
        }
        public void LoadDataIntoGridr()
        {
            //dt = new DataTable();
            //string readQuery = "SELECT DOKTORID, DoktorAdi, DoktorSoyadi, DoktorunBransi, Doktorun_kati FROM DOKTORLAR";
            //da = new SqlDataAdapter(readQuery, con);
            //da.Fill(dt);
            //_Randevular_dataGridView.DataSource = dt;
             //RANDEVULAR r = new RANDEVULAR();

             //Hastanedb dbr = new Hastanedb();
            //_Randevular_dataGridView.DataSource = dbr.RANDEVULAR.ToList();
            Hastanedb dbr = new Hastanedb();
            _Randevular_dataGridView.DataSource = dbr.RANDEVULAR
                .Select(r => new
                {
                    r.RANDEVUID,  // İstediğin sütunları buraya ekleyebilirsin
                    r.Randevu_Tarihi,
                    r.Randevu_Saati,
                    r.DOKTORID,
                    r.HASTAID,
                    r.Bulgu
                    // r.Bulgu gibi başka sütunlar da ekleyebilirsin
                }).ToList();


            // RANDEVUID sütununu gizle
            if (_Randevular_dataGridView.Columns.Contains("RANDEVUID"))
            {
                _Randevular_dataGridView.Columns["RANDEVUID"].Visible = false;
            }
            //string connectionString = "Data Source=DESKTOP-99R82DT;Initial Catalog=_HASTANE;Integrated Security=True;Encrypt=False"; // Bağlantı dizesini buraya yazın
            //string query = "SELECT * FROM DOKTORLAR"; // Sorgunuzu buraya yazın

            //using (SqlConnection connection = new SqlConnection(connectionString))
            //{
            //    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
            //    DataTable dataTable = new DataTable();

            //    // Verileri doldur
            //    dataAdapter.Fill(dataTable);

            //    // DataGridView'e veriyi bağla
            //    _Doktorlar_dataGridView.DataSource = dataTable;
            //}
        }
      
        private void _GUNCELLE_button_Click(object sender, EventArgs e)
        {
            RandevuGuncelle randevuGuncelle = new RandevuGuncelle();
            randevuGuncelle.Show();
            
            //this.Hide();
            //SqlConnection con = new SqlConnection("Data Source=DESKTOP-99R82DT;Initial Catalog=_HASTANE;Integrated Security=True;Encrypt=False");
            //con.Open();
            //string updateQuery = "UPDATE RANDEVULAR SET Randevu_Tarihi=@RandevuTarihi,Randevu_Saati=@RandevuSaati,Bulgu=@Bulgu WHERE RANDEVUID=@RANDEVUID ";
            //SqlCommand cmd = new SqlCommand(updateQuery, con);
            //cmd.Parameters.AddWithValue("@RandevuTarihi", dateTimePicker1.Value.Date);
            //cmd.Parameters.AddWithValue("@RandevuSaati", dateTimePicker2.Value);
            //cmd.Parameters.AddWithValue("@Bulgu", _Bulgu_textBox.Text);
            //cmd.Parameters.AddWithValue("@RANDEVUID", _RANDEVULAR_numericUpDown.Value);

            //int count = cmd.ExecuteNonQuery();
            //con.Close();
            //if (count > 0)
            //{
            //    MessageBox.Show("GÜNCELLEME BAŞARIYLA TAMAMLANDI", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //else
            //{
            //    MessageBox.Show("GÜNCELLEME BAŞARISIZ", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
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
        private void verileriyükle()
        {
            Hastanedb dbr = new Hastanedb();
            _Randevular_dataGridView.DataSource = dbr.RANDEVULAR
                .Select(r => new
                {
                    r.RANDEVUID,  // İstediğin sütunları buraya ekleyebilirsin
                    r.Randevu_Tarihi,
                    r.Randevu_Saati,
                    r.DOKTORID,
                    r.HASTAID,
                    r.Bulgu
                    // r.Bulgu gibi başka sütunlar da ekleyebilirsin
                }).ToList();


            // RANDEVUID sütununu gizle
            if (_Randevular_dataGridView.Columns.Contains("RANDEVUID"))
            {
                _Randevular_dataGridView.Columns["RANDEVUID"].Visible = false;
            }

            //Hastanedb dbr = new Hastanedb();
            //_Randevular_dataGridView.DataSource = dbr.RANDEVULAR.ToList();

            //foreach (Control control in this.Controls)
            //{
            //    if (control is TextBox)
            //    {
            //        control.Visible = false;
            //    }
            //    else if (control is NumericUpDown)
            //    {
            //        control.Visible = false;
            //    }
            //    else if (control is Label)
            //    {
            //        control.Visible = false;
            //    }
            //    else
            //    {
            //        control.Visible = true;
            //    }

            //}
            //SqlConnection con = new SqlConnection("Data Source=DESKTOP-99R82DT;Initial Catalog=_HASTANE;Integrated Security=True;Encrypt=False");
            //string readQuery = "Select RANDEVUID,Randevu_Tarihi,Randevu_Saati,DOKTORID,Bulgu from RANDEVULAR ";
            //// İNNER JOİN İLE SORGU YAPIP ALABİLİRİZ DOKTOR ADI SOYADINI YA DA DİREKT DOKTORID
            //SqlDataAdapter sda = new SqlDataAdapter(readQuery, con);
            //SqlCommandBuilder cmd = new SqlCommandBuilder();
            //DataTable dta = new DataTable();
            //sda.Fill(dta);
            //_Randevular_dataGridView.DataSource = dta;

        }

        private void _Sil_button_Click(object sender, EventArgs e)
        {
            if (_Randevular_dataGridView.SelectedRows.Count > 0)
            {
                // DataGridView'den seçilen satırın HASTAID'sini alıyoruz.
                int selectedHastaId = Convert.ToInt32(_Randevular_dataGridView.SelectedRows[0].Cells["RANDEVUID"].Value);

                using (var context = new Hastanedb())
                {
                    // Linq kullanarak silinecek hastayı buluyoruz.
                    var randevu = context.RANDEVULAR.FirstOrDefault(h => h.RANDEVUID == selectedHastaId);

                    if (randevu != null)
                    {
                        // Hastayı silmek için Remove metodunu kullanıyoruz.
                        context.RANDEVULAR.Remove(randevu);
                        context.SaveChanges();

                        MessageBox.Show("SİLME İŞLEMİ BAŞARIYLA TAMAMLANDI", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Silinecek hasta bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }

            }

            else
            {
                MessageBox.Show("Lütfen silinecek satırı seçin.");
            }


            verileriyükle(); // DataGridView'i güncellemek için verileri tekrar yüklüyoruz
            //if (_Randevular_dataGridView.SelectedRows.Count > 0)
            //{
            //    int selectedRowId = Convert.ToInt32(_Randevular_dataGridView.SelectedRows[0].Cells["RANDEVUID"].Value); // ID sütununu kullanarak silme işlemi yapacağız
            //    string connectionString = "Data Source=DESKTOP-99R82DT;Initial Catalog=_HASTANE;Integrated Security=True;Encrypt=False";
            //    using (SqlConnection connection = new SqlConnection(connectionString))
            //    {
            //        connection.Open();
            //        string query = "DELETE FROM RANDEVULAR WHERE RANDEVUID = @RANDEVUID";
            //        using (SqlCommand command = new SqlCommand(query, connection))
            //        {
            //            command.Parameters.AddWithValue("@RANDEVUID", selectedRowId);
            //            command.ExecuteNonQuery();
            //            MessageBox.Show("SİLME İŞLEMİ BAŞARIYLA TAMAMLANDI", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        }
            //    }

            //}
            //else
            //{
            //    MessageBox.Show("Lütfen silinecek satırı seçin.");
            //}
            //verileriyükle();
        }

        private void _DoktorBilgisi_label_Click(object sender, EventArgs e)
        {

        }

        private void _Ekle_button_Click(object sender, EventArgs e)
        {
            RandevuEkle formR = new RandevuEkle();
            formR.Show();

            //bool isAnyEmpty = false;
            //foreach (Control control in this.Controls)
            //{
            //    // Sadece TextBox'ları kontrol et
            //    if (control is TextBox && string.IsNullOrWhiteSpace(control.Text))
            //    {
            //        isAnyEmpty = true;
            //        break;
            //    }
            //}
            //if (isAnyEmpty)
            //{
            //    MessageBox.Show("Doldurmalısın!!", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //else
            //{
            //    // // RANDEVULAR rdv = new RANDEVULAR();
            //    //  //rdv.Randevu_Tarihi =_RandevuTarihi_textBox.Text ;
            //    // // rdv.Randevu_Saati = _RandevuSaati_textBox.Text;
            //    //// rdv.Bulgu =_Bulgu_textBox.Text ;
            //    //// Convert.ToDateTime

            //    //  Hastanedb dbr = new Hastanedb();

            //    //  dbr.RANDEVULAR.Add(rdv);
            //    //  dbr.SaveChanges();


            //    SqlConnection con = new SqlConnection("Data Source=DESKTOP-99R82DT;Initial Catalog=_HASTANE;Integrated Security=True;Encrypt=False");
            //    string insertQuery = "INSERT INTO RANDEVULAR(Randevu_Tarihi,Randevu_Saati,Bulgu,DOKTORID) VALUES(@RandevuTarihi, @RandevuSaati, @bulgu,@Doktorid) ";
            //    con.Open();
            //    SqlCommand cmd = new SqlCommand(insertQuery, con);
            //    SqlCommand bilg = new SqlCommand(insertQuery, con);

            //    cmd.Parameters.AddWithValue("@RandevuTarihi", dateTimePicker1.Value.Date);
            //    cmd.Parameters.AddWithValue("@RandevuSaati", dateTimePicker2.Value);
            //    cmd.Parameters.AddWithValue("@bulgu", _Bulgu_textBox.Text);
            //    cmd.Parameters.AddWithValue("@Doktorid", comboBox1.SelectedValue);
            //    //date time picker

            //    int count = cmd.ExecuteNonQuery();
            //    con.Close();
            //    if (count > 0)
            //    {
            //        MessageBox.Show("KAYIT BAŞARIYLA TAMAMLANDI", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //    else
            //    {
            //        MessageBox.Show("KAYIT OLUŞTURULAMADI", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }

            //}
        }
        private void FillComboSeachCode()
        {
            //comboBox1.Items.Clear();
            //SqlConnection con = new SqlConnection("Data Source=DESKTOP-99R82DT;Initial Catalog=_HASTANE;Integrated Security=True;Encrypt=False");
            //con.Open();
            //SqlCommand Komut = new SqlCommand();
            //Komut = con.CreateCommand();
            //Komut.CommandType = CommandType.Text;
            //Komut.CommandText = "Select DOKTORID, DoktorAdi +' ' + DoktorSoyadi as ADSOYAD  from DOKTORLAR";
            //Komut.ExecuteNonQuery();
            //DataTable dt = new DataTable();
            //SqlDataAdapter da = new SqlDataAdapter(Komut);
            //da.Fill(dt);
            //foreach (DataRow dr in dt.Rows)
            //{
            //    //comboBox1.Items.Add(dr["DoktorAdi"].ToString());


            //    comboBox1.DataSource = dt;
            //    comboBox1.ValueMember = "DOKTORID";
            //    comboBox1.DisplayMember = "ADSOYAD";

            //}
            //con.Close();


        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Randevular_Load(object sender, EventArgs e)
        {
            //FillComboSeachCode();
            _Randevular_dataGridView.RowHeadersVisible = false;
            _Randevular_dataGridView.Columns[0].ReadOnly = true;
            _Randevular_dataGridView.Columns[1].ReadOnly = true;
            _Randevular_dataGridView.Columns[2].ReadOnly = true;
            _Randevular_dataGridView.Columns[3].ReadOnly = true;
            _Randevular_dataGridView.Columns[4].ReadOnly = true;
        }

        private void _Kayıt_button_Click(object sender, EventArgs e)
        {

            //foreach (Control control in this.Controls)
            //{
            //    if (control is DataGridView)
            //    {
            //        control.Visible = false;
            //    }
            //    else
            //    {
            //        control.Visible = true;
            //    }

            //}
        }

        private void _Randevular_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
