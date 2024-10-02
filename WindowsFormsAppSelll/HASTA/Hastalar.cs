using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Database.Entity;
using Database.Model;

namespace WindowsFormsAppSelll
{
    public partial class Hastalar : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-99R82DT;Initial Catalog=_HASTANE;Integrated Security=True;Encrypt=False");
        SqlDataAdapter dah;
        DataTable dth;
        private int currentUserId;
        private Hastanedb dbContext = new Hastanedb();
        public Hastalar(int userId)
        {
            InitializeComponent();
            LoadDataIntoGridh();
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
                    case 5:
                        _Ekle_button.Enabled = true;
                        break;
                    case 6:
                        _GUNCELLE_button.Enabled = true;
                        _Sil_button.Enabled = true;
                        break;



                }
            }
        }

        public void LoadDataIntoGridh()

        {
            //Hastanedb db = new Hastanedb();
            //_Hastalar_dataGridView.DataSource = Database.Model.Hastalar.db.HASTALAR.ToList();


            _Hastalar_dataGridView.DataSource = Database.Model.Hastalar.HastalariGetir();
            //_Hastalar_dataGridView.DataSource = Database.Model.Hastalar.db.HASTALAR
            //    .Select(r => new
            //    {
            //        r.HASTAID,  // İstediğin sütunları buraya ekleyebilirsin
            //        r.HastaAdi,
            //        r.HastaSoyadi,
            //        r.HastaYasi

            //        // r.Bulgu gibi başka sütunlar da ekleyebilirsin
            //    }).ToList();

            // DOKTORID sütununu gizle
            if (_Hastalar_dataGridView.Columns.Contains("HASTAID"))
            {
                _Hastalar_dataGridView.Columns["HASTAID"].Visible = false;
            }

        }
        private void _HastalariListele_button_Click(object sender, EventArgs e)
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
            LoadDataIntoGridh();

            // DOKTORID sütununu gizle
            if (_Hastalar_dataGridView.Columns.Contains("HASTAID"))
            {
                _Hastalar_dataGridView.Columns["HASTAID"].Visible = false;

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

        private void _Sil_button_Click(object sender, EventArgs e)
        {

            if (_Hastalar_dataGridView.SelectedRows.Count > 0)
            {
                // DataGridView'den seçilen satırın HASTAID'sini alıyoruz.
                int selectedHastaId = Convert.ToInt32(_Hastalar_dataGridView.SelectedRows[0].Cells["HASTAID"].Value);

                //using (var context = new Hastanedb())
                //{
                // Linq kullanarak silinecek hastayı buluyoruz.
                //var hasta = context.HASTALAR.FirstOrDefault(h => h.HASTAID == selectedHastaId);

                if (selectedHastaId != 0)
              {
                    // Hastayı silmek için Remove metodunu kullanıyoruz.
                    //context.HASTALAR.Remove(hasta);
                    var silindi = Database.Model.Hastalar.HastalariSil(selectedHastaId);
                    if (silindi)
                    {

                        MessageBox.Show("SİLME İŞLEMİ BAŞARIYLA TAMAMLANDI", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        verileriyükle();
                    }
                    //context.SaveChanges();
                    else
                    {
                        MessageBox.Show("Silinemedi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Silinecek hasta bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

            //}

            else
            {
                MessageBox.Show("Lütfen silinecek satırı seçin.");
            }


            // DataGridView'i güncellemek için verileri tekrar yüklüyoruz


        }

        private void _Ekle_button_Click(object sender, EventArgs e)
        {




        }

        private void Hastalar_Load(object sender, EventArgs e)
        {
            
            _Hastalar_dataGridView.RowHeadersVisible = false;
            _Hastalar_dataGridView.Columns[1].ReadOnly = true;
            _Hastalar_dataGridView.Columns[2].ReadOnly = true;
            //_/*Hastalar_dataGridView.Columns[3].ReadOnly = true;*/
            //_Hastalar_dataGridView.Columns[4].ReadOnly = true;
        }

        private void _Kayıt_button_Click(object sender, EventArgs e)
        {


        }

        private void _GUNCELLE_button_Click(object sender, EventArgs e)
        {
            if (_Hastalar_dataGridView.SelectedRows.Count > 0)
            {
                // Seçilen hastanın HASTAID'sini alıyoruz
                int selectedHastaId = Convert.ToInt32(_Hastalar_dataGridView.SelectedRows[0].Cells["HASTAID"].Value);

                // HastaGuncelle formunu aç ve seçilen hastaID'yi gönder
                HastaGuncelle hastaGuncelleForm = new HastaGuncelle(selectedHastaId);
                hastaGuncelleForm.ShowDialog();

                // Güncellemeden sonra verileri yeniden yükle
                LoadDataIntoGridh();
                //HastaGuncelle hastaGuncelle = new HastaGuncelle(selectedHastaId);
                //hastaGuncelle.HastaGuncellendi += HastaGuncelle_HastaGuncellendi; // Event'e abone ol
                //hastaGuncelle.ShowDialog();
            }
            else
            {
                MessageBox.Show("Lütfen güncellenecek hastayı seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void HastaGuncelle_HastaGuncellendi(object sender, EventArgs e)
        {
            // Hasta verilerini tekrar yükleyerek güncelle
            _Hastalar_dataGridView.DataSource = Database.Model.Hastalar.HastalariGetir();
        }
        private void _Hastalar_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
