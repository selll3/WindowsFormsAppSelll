using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using WindowsFormsAppSelll.ENTITY;
using Database.Entity;

namespace WindowsFormsAppSelll
{
    public partial class Personeller : Form
    {


        private int currentUserId;
        private Hastanedb dbContext = new Hastanedb();
        public Personeller(int userId)
        {
            InitializeComponent();
       
            LoadDataIntoGridp();
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
                    case 8: 
                        _Ekle_button.Enabled = true;
                        break;
                    case 9:  
                        _GUNCELLE_button.Enabled = true;
                        _Sil_button.Enabled = true;
                        break;


                      
                }
            }
        }
        public void LoadDataIntoGridp()
        {
            //dtp = new DataTable();
            //string readQuery = "SELECT PERSONELID, PersonelAdi, PersonelSoyadi,PersonelGorev FROM PERSONEL";
            //dap = new SqlDataAdapter(readQuery, con);
            //dap.Fill(dtp);
            //_Personeller_dataGridView.DataSource = dtp;


            _Personeller_dataGridView.DataSource = Database.Model.Personeller.PersoneliGetir();
            //_Personeller_dataGridView.DataSource = Database.Model.Personeller.dp.PERSONEL
            //    .Select(r => new
            //    {
            //        r.PERSONELID,  // İstediğin sütunları buraya ekleyebilirsin
            //        r.PersonelAdi,
            //        r.PersonelSoyadi,
            //        r.PersonelGorev
            //        //r.KULLANICIID
                   
            //        // r.Bulgu gibi başka sütunlar da ekleyebilirsin
            //    }).ToList();
            // DOKTORID sütununu gizle
            //if (_Personeller_dataGridView.Columns.Contains("PERSONELID"))
            //{
            //    _Personeller_dataGridView.Columns["PERSONELID"].Visible = false;
            //}

        }




        private void _PersonelilListele_button_Click(object sender, EventArgs e)
        {

         

        }


        private void verileriyükle()
        {
           

            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    control.Visible = false;
                }
                else if (control is NumericUpDown)
                {
                    control.Visible = false;
                }
                else if (control is Label)
                {
                    control.Visible = false;
                }
                else
                {
                    control.Visible = true;
                }
            }
            _Personeller_dataGridView.DataSource = Database.Model.Personeller.PersoneliGetir();
            //_Personeller_dataGridView.DataSource = Database.Model.Personeller.dp.PERSONEL
            //   .Select(r => new
            //   {
            //       r.PERSONELID,  // İstediğin sütunları buraya ekleyebilirsin
            //       r.PersonelAdi,
            //       r.PersonelSoyadi,
            //       r.PersonelGorev
            //       //r.KULLANICIID

            //       // r.Bulgu gibi başka sütunlar da ekleyebilirsin
            //   }).ToList();


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

        private void _Sil_button_Click(object sender, EventArgs e)
        {
            if (_Personeller_dataGridView.SelectedRows.Count > 0)
            {
                int selectedRowId = Convert.ToInt32(_Personeller_dataGridView.SelectedRows[0].Cells["PERSONELID"].Value); // ID sütununu kullanarak silme işlemi yapacağız

                if (selectedRowId != 0)
                {
                    // Model katmanındaki personel silme işlemini çağırıyoruz
                    var silindi = Database.Model.Personeller.PersonelSil(selectedRowId);

                    if (silindi)
                    {
                        // Eğer personelin görevi "Doktor" ise, doktordan da silinsin
                        var personelGorev = Database.Model.Personeller.PersonelMiDoktorMu(selectedRowId);
                        if (personelGorev != null && personelGorev.Equals("Doktor", StringComparison.OrdinalIgnoreCase))
                        {
                            var doktorSilindi = Database.Model.Doktorlar.DoktorlariSil(selectedRowId);

                            if (!doktorSilindi)
                            {
                                MessageBox.Show("Doktor silinemedi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }

                        MessageBox.Show("SİLME İŞLEMİ BAŞARIYLA TAMAMLANDI", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        verileriyükle(); // DataGridView'i güncellemek için verileri tekrar yüklüyoruz
                    }
                    else
                    {
                        MessageBox.Show("Personel silinemedi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Silinecek personel bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Lütfen silinecek satırı seçin.");
            }
        }


        private void _GUNCELLE_button_Click(object sender, EventArgs e)
        {
            if (_Personeller_dataGridView.SelectedRows.Count > 0)
            {
                // Seçilen satırdan personel bilgilerini al
                int selectedPersonelId = Convert.ToInt32(_Personeller_dataGridView.SelectedRows[0].Cells["PERSONELID"].Value);
                string selectedPersonelAdi = _Personeller_dataGridView.SelectedRows[0].Cells["PersonelAdi"].Value.ToString();
                string selectedPersonelSoyadi = _Personeller_dataGridView.SelectedRows[0].Cells["PersonelSoyadi"].Value.ToString();
                string selectedPersonelGorev = _Personeller_dataGridView.SelectedRows[0].Cells["PersonelGorev"].Value.ToString();

                // PersonelGuncelle formunu aç ve bilgileri gönder
                PersonelGuncelle personelGuncelleForm = new PersonelGuncelle(selectedPersonelId, selectedPersonelAdi, selectedPersonelSoyadi, selectedPersonelGorev);
                personelGuncelleForm.FormClosed += PersonelGuncelle_FormClosed;
                personelGuncelleForm.Show();
            }
            else
            {
                MessageBox.Show("Lütfen güncellenecek bir personel seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } 


        }

        private void PersonelGuncelle_FormClosed(object sender, FormClosedEventArgs e)
        {
            verileriyükle();
        }

        private void _Ekle_button_Click(object sender, EventArgs e)
            {


            PersonelEkle formP = new PersonelEkle();
            formP.Show();

           
        }

        private void _Personeller_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void Personeller_Load(object sender, EventArgs e)
        {
            _Personeller_dataGridView.RowHeadersVisible = false;
            //    _Personeller_dataGridView.Columns[0].ReadOnly = true;
            //    _Personeller_dataGridView.Columns[1].ReadOnly = true;
            //    _Personeller_dataGridView.Columns[2].ReadOnly = true;
        }

        private void _Kayıt_button_Click(object sender, EventArgs e)
        {
           

        }
}









}
