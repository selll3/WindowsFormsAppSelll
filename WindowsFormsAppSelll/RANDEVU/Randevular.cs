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
        }
        private void _GUNCELLE_button_Click(object sender, EventArgs e)
        {
            if (_Randevular_dataGridView.SelectedRows.Count > 0)
            {
                int selectedRandevuId = Convert.ToInt32(_Randevular_dataGridView.SelectedRows[0].Cells["RANDEVUID"].Value);
                DateTime selectedRandevuTarihi = Convert.ToDateTime(_Randevular_dataGridView.SelectedRows[0].Cells["Randevu_Tarihi"].Value);
                TimeSpan selectedRandevuSaati = TimeSpan.Parse(_Randevular_dataGridView.SelectedRows[0].Cells["Randevu_Saati"].Value.ToString());
                string selectedBulgu = _Randevular_dataGridView.SelectedRows[0].Cells["Bulgu"].Value.ToString();
                int SelectedDid= Convert.ToInt32(_Randevular_dataGridView.SelectedRows[0].Cells["DOKTORID"].Value);
                int SelectedHid = Convert.ToInt32(_Randevular_dataGridView.SelectedRows[0].Cells["HASTAID"].Value);
                RandevuGuncelle randevuGuncelleForm = new RandevuGuncelle(selectedRandevuId, selectedRandevuTarihi, selectedRandevuSaati, selectedBulgu,SelectedDid,SelectedHid);
                randevuGuncelleForm.FormClosed += (s, args) => LoadDataIntoGridr(); // Form kapandığında güncelle
                randevuGuncelleForm.Show();
            }
            else
            {
                MessageBox.Show("Lütfen güncellenecek bir randevu seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            //if (_Randevular_dataGridView.SelectedRows.Count > 0)
            //{
            //    // Seçilen satırdan personel bilgilerini al
            //    int selectedrandevulId = Convert.ToInt32(_Randevular_dataGridView.SelectedRows[0].Cells["RANDEVUID"].Value);
            //    string selectedrandevuTarihi = _Randevular_dataGridView.SelectedRows[0].Cells["Randevu_Tarihi"].Value.ToString();
            //    string selectedrandevuSaati = _Randevular_dataGridView.SelectedRows[0].Cells["Randevu_Saati"].Value.ToString();
            //    string selectedBulgu = _Randevular_dataGridView.SelectedRows[0].Cells["Bulgu"].Value.ToString();

            //    // PersonelGuncelle formunu aç ve bilgileri gönder
            //    RandevuGuncelle randevuGuncelleForm = new RandevuGuncelle(selectedrandevulId, selectedrandevuTarihi, selectedrandevuSaati, selectedBulgu);
            //    randevuGuncelleForm.FormClosed += _Randevular_dataGridView;
            //    randevuGuncelleForm.Show();
            //}
            //else
            //{
            //    MessageBox.Show("Lütfen güncellenecek bir personel seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //} // burayı nasıl çağırmalıyım
            ////PersonelGuncelle PersonelGuncelle = new PersonelGuncelle();
            ////PersonelGuncelle.FormClosed += PersonelGuncelle_FormClosed;
            ////PersonelGuncelle.Show();

            //RandevuGuncelle randevuGuncelle = new RandevuGuncelle();
            //randevuGuncelle.Show();


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

           

        }

        private void _Sil_button_Click(object sender, EventArgs e)
        {
            if (_Randevular_dataGridView.SelectedRows.Count > 0)
            {
                // DataGridView'den seçilen satırın HASTAID'sini alıyoruz.
                int selectedRandevuId = Convert.ToInt32(_Randevular_dataGridView.SelectedRows[0].Cells["RANDEVUID"].Value);

                
                
                    // Linq kullanarak silinecek hastayı buluyoruz.
                    
                    if (selectedRandevuId != 0)
                    {

                          var silindirandevu = Database.Model.Randevular.RandevuSil(selectedRandevuId);
                          if(silindirandevu)
                          {// Hastayı silmek için Remove metodunu kullanıyoruz.
                           //context.RANDEVULAR.Remove(randevu);
                            //context.SaveChanges();

                            MessageBox.Show("SİLME İŞLEMİ BAŞARIYLA TAMAMLANDI", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);
                             verileriyükle(); // DataGridView'i güncellemek için verileri tekrar yüklüyoruz
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


           
           
        }

        private void _DoktorBilgisi_label_Click(object sender, EventArgs e)
        {

        }

        private void _Ekle_button_Click(object sender, EventArgs e)
        {
            RandevuEkle formR = new RandevuEkle();
            formR.Show();

         
        }
        private void FillComboSeachCode()
        {
    

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

    
