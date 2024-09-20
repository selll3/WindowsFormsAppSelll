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

namespace WindowsFormsAppSelll.KULLANICI
{
    public partial class YetkileriGor : Form
    {
        private int _kullaniciId;
        public YetkileriGor(int kullaniciId)
        {
            InitializeComponent();
            _kullaniciId = kullaniciId;
             LoadYetkiler();
        }
        private void LoadYetkiler()
        {
            using (var context = new Hastanedb())
            {
                var yetkiler = (from f in context.FORMLAR
                                join y in context.PERSONELFORMYETKILERI on f.FormID equals y.FormID into joined
                                from j in joined.DefaultIfEmpty()
                                select new
                                {
                                    FormAdi = f.FormAdi,
                                    Yetki = j != null && j.KULLANICIID == _kullaniciId ? j.Yetki : false // Kullanıcıya özel yetki kontrolü
                                }).ToList();

                _yetkilerigor_dataGridView.DataSource = yetkiler;
            }
        }

        //public void ReloadYetkiler(int kullaniciId)
        //{
        //    _kullaniciId = kullaniciId;
        //    LoadYetkiler();
        //}
        public void ReloadYetkiler(int kullaniciId)
        {
            _kullaniciId = kullaniciId; // Kullanıcı ID'sini güncelle
            LoadYetkiler(); // Yetkileri yeniden yükle
        }
        private void YetkileriGor_Load(object sender, EventArgs e)

        {  /* Kullanicilar kl = new Kullanicilar();*/
            // Checkbox sütunu için
            //_yetkilerigor_dataGridView.Columns[2].ReadOnly = false;
            //int personelID = Convert.ToInt32(_yetkilerigor_dataGridView.SelectedRows[0].Cells["YetkiID"].Value);
            // Önceki formdan veya kullanıcı seçiminizden al

            // Veritabanı bağlantısı ve sorgu


            //int selectedKullaniciID = (int)kl._kullanicilar_dataGridView.SelectedRows[0].Cells["KULLANICIID"].Value;
            //DATA();

            // SqlConnection conn = new SqlConnection("Data Source=DESKTOP-99R82DT;Initial Catalog=_HASTANE;Integrated Security=True;Encrypt=False");
            ////string insertQuery = "SELECT PERSONELFORMYETKILERI.*, FORM.* FROM PERSONELFORMYETKILERI INNER JOIN FORM ON PERSONELFORMYETKILERI.PERSONELID = FORM.PERSONELID";
            // SqlCommand cmd = new SqlCommand("SELECT * FROM ViewDENEME",conn);


            // SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            // DataTable table = new DataTable();
            // adapter.Fill(table);

            // // DataGridView'e veri bağlama
            // _yetkilerigor_dataGridView.DataSource = table;
            // conn.Close();
        }
        //public void DATA()
        // {

        //     SqlConnection conn = new SqlConnection("Data Source=DESKTOP-99R82DT;Initial Catalog=_HASTANE;Integrated Security=True;Encrypt=False");
        //     //string insertQuery = "SELECT PERSONELFORMYETKILERI.*, FORM.* FROM PERSONELFORMYETKILERI INNER JOIN FORM ON PERSONELFORMYETKILERI.PERSONELID = FORM.PERSONELID";
        //     SqlCommand cmd = new SqlCommand("SELECT * FROM Viewdeneme1", conn);


        //     SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        //     DataTable table = new DataTable();
        //     adapter.Fill(table);

        //     // DataGridView'e veri bağlama
        //     _yetkilerigor_dataGridView.DataSource = table;
        //     conn.Close();
        // }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //private YetkileriGor yetkileriGorForm;
        private void _Kaydet_button_Click(object sender, EventArgs e)
        {
            using (var context = new Hastanedb())
            {
                foreach (DataGridViewRow row in _yetkilerigor_dataGridView.Rows)
                {
                    if (row.DataBoundItem != null) // Klasik null kontrol
                    {
                        string formAdi = row.Cells["FormAdi"].Value.ToString();
                        bool yetkiDurumu = Convert.ToBoolean(row.Cells["Yetki"].Value);

                        var form = context.FORMLAR.FirstOrDefault(f => f.FormAdi == formAdi);
                        if (form != null)
                        {
                            var yetki = context.PERSONELFORMYETKILERI
                                .FirstOrDefault(y => y.KULLANICIID == _kullaniciId && y.FormID == form.FormID);

                            if (yetki != null)
                            {
                                // Yetki varsa güncelle
                                yetki.Yetki = yetkiDurumu;
                            }
                            else
                            {
                                // Yetki yoksa yeni bir kayıt oluştur
                                context.PERSONELFORMYETKILERI.Add(new PERSONELFORMYETKILERI
                                {
                                    KULLANICIID = _kullaniciId,
                                    FormID = form.FormID,
                                    Yetki = yetkiDurumu
                                });
                            }
                        }
                    }
                }
                context.SaveChanges();
                MessageBox.Show("Yetkiler başarıyla kaydedildi.");
            }
            //using (var context = new Hastanedb())
            //{
            //    foreach (DataGridViewRow row in _yetkilerigor_dataGridView.Rows)
            //    {
            //        string formAdi = row.Cells["FormAdi"].Value.ToString();
            //        bool yetki = (bool)row.Cells["Yetki"].Value;

            //        // FormID'yi veritabanından bulmak için form adını kullanıyoruz
            //        var form = context.FORMLAR.FirstOrDefault(f => f.FormAdi == formAdi);
            //        if (form != null)
            //        {
            //            var mevcutYetki = context.PERSONELFORMYETKILERI
            //                .FirstOrDefault(y => y.KULLANICIID == _kullaniciId && y.FormID == form.FormID);

            //            if (mevcutYetki != null)
            //            {
            //                // Mevcut yetkiyi güncelle
            //                mevcutYetki.Yetki = yetki;
            //            }
            //            else
            //            {
            //                // Yeni yetki ekle
            //                var yeniYetki = new PERSONELFORMYETKILERI
            //                {
            //                    KULLANICIID = _kullaniciId,
            //                    FormID = form.FormID,
            //                    Yetki = yetki
            //                };
            //                context.PERSONELFORMYETKILERI.Add(yeniYetki);
            //            }
            //        }
            //        else
            //        {
            //            MessageBox.Show("Geçersiz FormID. Lütfen form listesini kontrol edin.");
            //        }
            //    }

            //    context.SaveChanges();
            //    MessageBox.Show("Yetkiler başarıyla kaydedildi.");
            //    this.Close(); // Formu kapat ve bir önceki forma dön
            //}
            //if (_yetkilerigor_dataGridView.SelectedRows.Count > 0)
            //{
            //    int kullaniciId = Convert.ToInt32(_yetkilerigor_dataGridView.SelectedRows[0].Cells["KULLANICIID"].Value);

            //    if (yetkileriGorForm == null || yetkileriGorForm.IsDisposed)
            //    {
            //        // Eğer form kapatıldıysa yeni form oluştur
            //        yetkileriGorForm = new YetkileriGor(kullaniciId);
            //        yetkileriGorForm.Show();
            //    }
            //    else
            //    {
            //        // Eğer form zaten açıksa, yeniden yükle
            //        yetkileriGorForm.ReloadYetkiler(kullaniciId);
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Lütfen bir kullanıcı seçin.");
            //}

            //using (var context = new Hastanedb())
            //{
            //    foreach (DataGridViewRow row in _yetkilerigor_dataGridView.Rows)
            //    {
            //        int formId = Convert.ToInt32(row.Cells["FormID"].Value);  // FormID'yi alıyoruz
            //        bool yetkiDurumu = Convert.ToBoolean(row.Cells["Yetki"].Value);  // Yetki checkbox durumunu alıyoruz

            //        // Yetkileri güncelle
            //        var yetki = context.PERSONELFORMYETKILERI.FirstOrDefault(y => y.KULLANICIID == _kullaniciId && y.FormID == formId);

            //        if (yetki != null)
            //        {
            //            // Eğer yetki zaten varsa, güncelle
            //            yetki.Yetki = yetkiDurumu;
            //        }
            //        else
            //        {
            //            // Eğer yetki daha önce yoksa, yeni bir yetki ekle
            //            context.PERSONELFORMYETKILERI.Add(new PERSONELFORMYETKILERI
            //            {
            //                KULLANICIID = _kullaniciId,
            //                FormID = formId,
            //                Yetki = yetkiDurumu
            //            });
            //        }
            //    }

            //    context.SaveChanges();  // Veritabanına kaydet
            //}

            //MessageBox.Show("Yetkiler güncellendi.");






            //foreach (DataGridViewRow row in _yetkilerigor_dataGridView.Rows)
            //{
            //    int formId = Convert.ToInt32(row.Cells["FormID"].Value);
            //    bool yetki = Convert.ToBoolean(row.Cells["Yetki"].Value);

            //    // FormID'nin geçerli olup olmadığını kontrol et
            //    if (formId <= 0) // 0 veya negatif değer kontrolü
            //    {
            //        MessageBox.Show("Geçersiz FormID. Lütfen form listesini kontrol edin.");
            //        return; // İşlemi durdur
            //    }

            //    SaveUserPermission(_kullaniciId, formId, yetki);
            //}

            //MessageBox.Show("Yetkiler başarıyla kaydedildi!");


            //    foreach (DataGridViewRow row in _yetkilerigor_dataGridView.Rows)
            //    {
            //        int formId = Convert.ToInt32(row.Cells["FormID"].Value);
            //        bool yetki = Convert.ToBoolean(row.Cells["Yetki"].Value);

            //        // Form ID'sinin geçerli olup olmadığını kontrol et
            //        if (!IsValidFormId(formId))
            //        {
            //            MessageBox.Show($"FormID {formId} mevcut değil. Lütfen kontrol edin.");
            //            return; // İşlemi durdur
            //        }

            //        SaveUserPermission(_kullaniciId, formId, yetki);
            //    }

            //    MessageBox.Show("Yetkiler başarıyla kaydedildi!");
            //foreach (DataGridViewRow row in _yetkilerigor_dataGridView.Rows)
            //{
            //    // FormID ve checkbox değerini al
            //    int formId = Convert.ToInt32(row.Cells["FormID"].Value);
            //    bool yetki = Convert.ToBoolean(row.Cells["Yetki"].Value);

            //    // Kullanıcı ID'si ile yetkiyi kaydet
            //    SaveUserPermission(_kullaniciId, formId, yetki);
            //}

            //MessageBox.Show("Yetkiler başarıyla kaydedildi!");

            //    DataGridView dgv = new DataGridView();
            //    foreach (DataGridViewRow row in dgv.Rows)
            //    {
            //        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-99R82DT;Initial Catalog=_HASTANE;Integrated Security=True;Encrypt=False");
            //        SqlCommand cmd = new SqlCommand("UPDATE PERSONELFORMYETKILERI SET Yetki = @Yetki WHERE FormID = @FormID AND KULLANICIID = @KULLANICIID");
            //        conn.Open();

            //        bool yetki = (bool)row.Cells["Yetki"].Value; // Checkbox değerini al
            //        string formAdi = row.Cells["FormAdi"].Value.ToString();
            //         conn.Close();
            //        // Form adından FormID'yi al ve yetkiyi güncelle

            //        // SQL komutunu çalıştır ve veritabanını güncelle
            //    }

        }
        //private bool IsValidFormId(int formId)
        //{
        //    string query = "SELECT COUNT(*) FROM FORMLAR WHERE FormID = @formId";
        //    using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-99R82DT;Initial Catalog=_HASTANE;Integrated Security=True;Encrypt=False"))
        //    {
        //        using (SqlCommand command = new SqlCommand(query, connection))
        //        {
        //            command.Parameters.AddWithValue("@formId", formId);
        //            connection.Open();
        //            int count = (int)command.ExecuteScalar();
        //            return count > 0; // Eğer form mevcutsa true döner
        //        }
        //    }
        //}

        //private void SaveUserPermission(int kullaniciId, int formId, bool yetki)
        //{
        //    string query = "IF EXISTS (SELECT * FROM PERSONELFORMYETKILERI WHERE KULLANICIID = @kullaniciId AND FormID = @formId) " +
        //                   "BEGIN " +
        //                   "UPDATE PERSONELFORMYETKILERI SET Yetki = @yetki WHERE KULLANICIID = @kullaniciId AND FormID = @formId " +
        //                   "END " +
        //                   "ELSE " +
        //                   "BEGIN " +
        //                   "INSERT INTO PERSONELFORMYETKILERI (KULLANICIID, FormID, Yetki) VALUES (@kullaniciId, @formId, @yetki) " +
        //                   "END";

        //    using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-99R82DT;Initial Catalog=_HASTANE;Integrated Security=True;Encrypt=False"))
        //    {
        //        using (SqlCommand command = new SqlCommand(query, connection))
        //        {
        //            command.Parameters.AddWithValue("@kullaniciId", kullaniciId);
        //            command.Parameters.AddWithValue("@formId", formId);
        //            command.Parameters.AddWithValue("@yetki", yetki ? 1 : 0); // Boolean'u BIT'e çevir

        //            connection.Open();
        //            command.ExecuteNonQuery();
        //        }
        //    }
        //}



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
