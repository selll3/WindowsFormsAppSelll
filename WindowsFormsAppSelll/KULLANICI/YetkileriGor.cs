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


        private void LoadYetkiler()
        {
            using (Hastanedb dbContext = new Hastanedb())
            {
                var yetkiler = (from form in dbContext.FORMLAR
                                join yetki in dbContext.PERSONELFORMYETKILERI
                                on form.FormID equals yetki.FormID into formYetkileri
                                from fy in formYetkileri.Where(y => y.KULLANICIID == kullaniciID).DefaultIfEmpty()
                                select new
                                {
                                    form.FormID,
                                    form.FormAdi,
                                    Yetki = fy != null ? fy.Yetki : false // Eğer yetki kaydı yoksa varsayılan olarak false ayarlanır
                                }).ToList();

                dt = new DataTable();
                dt.Columns.Add("FormID", typeof(int));
                dt.Columns.Add("FormAdi", typeof(string));
                dt.Columns.Add("Yetki", typeof(bool));

                foreach (var item in yetkiler)
                {
                    DataRow row = dt.NewRow();
                    row["FormID"] = item.FormID;
                    row["FormAdi"] = item.FormAdi;
                    row["Yetki"] = item.Yetki;
                    dt.Rows.Add(row);
                }

                _yetkilerigor_dataGridView.DataSource = dt;

                // FormID sütununu gizle
                if (_yetkilerigor_dataGridView.Columns.Contains("FormID"))
                {
                    _yetkilerigor_dataGridView.Columns["FormID"].Visible = false;
                }

                _yetkilerigor_dataGridView.Columns[1].ReadOnly = true;
                _yetkilerigor_dataGridView.RowHeadersVisible = false;
            }
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
            foreach (DataRow row in dt.Rows)
            {
                int formID = Convert.ToInt32(row["FormID"]);
                bool yetki = Convert.ToBoolean(row["Yetki"]);

                if (formID <= 0)
                {
                    MessageBox.Show("Geçersiz FormID: " + formID, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                PERSONELFORMYETKILERI pfy = new PERSONELFORMYETKILERI
                {
                    KULLANICIID = kullaniciID,
                    FormID = formID,
                    Yetki = yetki
                };

                bool islemBasarili = Database.Model.Yetkiler.YetkiEkleVeyaGuncelle(pfy);

                if (!islemBasarili)
                {
                    MessageBox.Show("Bir hata oluştu. İşlem başarısız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            MessageBox.Show("Kayıt başarıyla tamamlandı.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();

            Main mainguncel = new Main(kullaniciID);
            mainguncel.yetkileriolustur();

            //using (Hastanedb dbContext = new Hastanedb())
            //{
            //    foreach (DataRow row in dt.Rows)
            //    {
            //        int formID = Convert.ToInt32(row["FormID"]);
            //        bool yetki = Convert.ToBoolean(row["Yetki"]);

            //        if (formID <= 0)
            //        {
            //            MessageBox.Show("Geçersiz FormID: " + formID, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //            return;
            //        }

            //        var personelFormYetki = dbContext.PERSONELFORMYETKILERI.SingleOrDefault(pfy => pfy.KULLANICIID == kullaniciID && pfy.FormID == formID);

            //        if (personelFormYetki != null)
            //        {
            //            // Eğer kayıt varsa güncelle
            //            personelFormYetki.Yetki = yetki;
            //        }
            //        else
            //        {
            //            // Kayıt yoksa yeni bir kayıt ekle
            //            dbContext.PERSONELFORMYETKILERI.Add(new PERSONELFORMYETKILERI
            //            {
            //                KULLANICIID = kullaniciID,
            //                FormID = formID,
            //                Yetki = yetki
            //            });
            //        }
            //    }

            //    dbContext.SaveChanges();
            //    MessageBox.Show("Kayıt başarıyla tamamlandı.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}

            //this.Close();
            //Main mainguncel = new Main(kullaniciID);
            //mainguncel.yetkileriolustur();



        }

        private void YetkileriGor_Load(object sender, EventArgs e)
        {
            LoadYetkiler();
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
