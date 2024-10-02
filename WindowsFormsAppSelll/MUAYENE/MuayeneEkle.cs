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
using WindowsFormsAppSelll.MUAYENE;
using Database.Entity;
using WindowsFormsAppSelll.ENTITY;
//using WindowsFormsAppSelll.ENTITY;
//using WindowsFormsAppSelll.ENTITY;

//using WindowsFormsAppSelll.ENTITY;
//using WindowsFormsAppSelll.ENTITY;

namespace WindowsFormsAppSelll
{
    public partial class MuayeneEkle : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-99R82DT;Initial Catalog=_HASTANE;Integrated Security=True;Encrypt=False");
        SqlDataAdapter da;
        DataTable dt;

        private int hid;
        public MuayeneEkle(int hastaId)
        {
            InitializeComponent();
            hid = hastaId;
           //_HastaBilgisi_comboBox.ValueMember = ;
            LoadDataIntoRandevu(hastaId);
           

        }
       
        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void LoadDataIntoRandevu(int hastaId)
        {
           
            
                var randevular = Database.Model.Randevular.dbr.RANDEVULAR
                    .Where(r => r.HASTAID == hastaId && r.Randevu_Tarihi < DateTime.Today)
                    .Select(r => new
                    {
                        r.RANDEVUID,
                        r.Randevu_Tarihi,
                        r.Randevu_Saati,
                        r.DOKTORID,
                        r.Bulgu,
                        r.HASTAID
                    })
                    .ToList();

                // DataTable oluştur
                DataTable randevuTable = new DataTable();
                randevuTable.Columns.Add("RANDEVUID", typeof(int));
                randevuTable.Columns.Add("Randevu_Tarihi", typeof(DateTime));
                randevuTable.Columns.Add("Randevu_Saati", typeof(string));
                randevuTable.Columns.Add("DOKTORID", typeof(int));
                randevuTable.Columns.Add("Bulgu", typeof(string));
                randevuTable.Columns.Add("HASTAID", typeof(int));

                // Verileri DataTable'a ekle
                foreach (var randevu in randevular)
                {
                    randevuTable.Rows.Add(randevu.RANDEVUID, randevu.Randevu_Tarihi, randevu.Randevu_Saati, randevu.DOKTORID, randevu.Bulgu, randevu.HASTAID);
                }

                dataGridView1.DataSource = randevuTable;

                // RANDEVUID sütununu gizle
                if (dataGridView1.Columns.Contains("RANDEVUID"))
                {
                    dataGridView1.Columns["RANDEVUID"].Visible = false;
                }
            
        }


        private void FillComboSeachCode( int hastaId)
        {
          
            
                var doktorlar = Database.Model.Doktorlar.dbd.DOKTORLAR
                    .Select(d => new
                    {
                        d.DOKTORID,
                        ADSOYAD = d.DoktorAdi + " " + d.DoktorSoyadi
                    })
                    .ToList();

                _DoktorBilgisi_comboBox.DataSource = doktorlar;
                _DoktorBilgisi_comboBox.ValueMember = "DOKTORID";
                _DoktorBilgisi_comboBox.DisplayMember = "ADSOYAD";
            


        }
       
        private void FillComboSearchHasta()
        {
            
            
                var hastalar = Database.Model.Hastalar.dbh.HASTALAR
                    .Select(h => new
                    {
                        h.HASTAID,
                        ADSOYAD = h.HastaAdi + " " + h.HastaSoyadi
                    })
                    .ToList();

                _HastaBilgisi_comboBox.DataSource = hastalar;
                _HastaBilgisi_comboBox.ValueMember = "HASTAID";
                _HastaBilgisi_comboBox.DisplayMember = "ADSOYAD";
            


        }


        

        private void MuayeneEkle_Load(object sender, EventArgs e)
        {

            //FillComboSearchRandevu(hid);
            dataGridView1.RowHeadersVisible = false;
            FillComboSearchHasta();
           
            FillComboSeachCode(hid);
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

        private void _kaydet_button_Click(object sender, EventArgs e)
        {
            bool isAnyEmpty = false;
            foreach (Control control in this.Controls)
            {
                // Sadece TextBox'ları kontrol et
                if (control is TextBox && string.IsNullOrWhiteSpace(control.Text))
                {
                    isAnyEmpty = true;
                    break;
                }
            }

            if (isAnyEmpty && dateTimePicker1.Value.Date == null)
            {
                MessageBox.Show("Doldurmalısın!!", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {


               Database.Entity.MUAYENE muayene = new Database.Entity.MUAYENE();

                muayene.HASTAID = (int)_HastaBilgisi_comboBox.SelectedValue;
                muayene.DOKTORID = (int)_DoktorBilgisi_comboBox.SelectedValue;
                muayene.Aciklama = _aciklama_textBox.Text;
                muayene.islendiBilgisi = _islendi.Checked;
                muayene.MuayeneTarihi = dateTimePicker1.Value.Date;

                var eklendimi =Database.Model.Muayeneler.MuayeneEkle(muayene);
                   /* context.MUAYENE.Add(muayene);*/ // Yeni muayene kaydını ekle
            /*       /* int count = context.SaveChanges()*/

                    if (eklendimi )
                    {
                        MessageBox.Show("KAYIT BAŞARIYLA TAMAMLANDI", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("KAYIT OLUŞTURULAMADI", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                

                Muayeneler form1 = Application.OpenForms.OfType<Muayeneler>().FirstOrDefault();
                if (form1 != null)
                {
                    form1.LoadDataMuayene(); // İlk formun veri yükleme metodunu çağır
                }

                this.Close();
            }

        }

        private void _HastaBilgisi_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_HastaBilgisi_comboBox.SelectedValue != null)
            {
                //// Seçilen değerin türünü kontrol edin
                //var selectedValueType = _HastaBilgisi_comboBox.SelectedValue.GetType();
                //MessageBox.Show($"Selected value type: {selectedValueType}");

                // Eğer tür doğru ise dönüştürme yapın
                if (_HastaBilgisi_comboBox.SelectedValue is int)
                {
                    int hastaId = (int)_HastaBilgisi_comboBox.SelectedValue; // HASTAID'yi al
                    LoadDataIntoRandevu(hastaId); // Fonksiyonu çağır
                }
            }
        }


        private void _HastaBilgisi_comboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void _RandevuBilgisi_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
