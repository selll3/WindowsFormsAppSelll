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
//using System;
//using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;


namespace WindowsFormsAppSelll
{
    public partial class RandevuEkle : Form
    {
        
        public RandevuEkle()
        {
            InitializeComponent();
            
        }
      
        private void _randevuekle_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FillComboSeachCode()
        {
            
            
                var doktorList = Database.Model.Doktorlar.dbd.DOKTORLAR
                    .Select(d => new
                    {
                        DOKTORID = d.DOKTORID,
                        ADSOYAD = d.DoktorAdi + " " + d.DoktorSoyadi
                    }).ToList();

                _doktorBilgisi_comboBox.DataSource = doktorList;
                _doktorBilgisi_comboBox.ValueMember = "DOKTORID";
                _doktorBilgisi_comboBox.DisplayMember = "ADSOYAD";
            
        }


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
            if (isAnyEmpty)
            {
                MessageBox.Show("Doldurmalısın!!", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
             

                RANDEVULAR rdv = new RANDEVULAR();
                 rdv.Randevu_Tarihi = _RandevuTarihi_dateTimePicker.Value.Date;
                rdv.Randevu_Saati = _RandevuSaati_dateTimePicker.Value.TimeOfDay;
                rdv.Bulgu = _Bulgu_textBox.Text;
                rdv.DOKTORID =(int?)_doktorBilgisi_comboBox.SelectedValue;
                rdv.HASTAID =(int?)_HastaBilgisi_comboBox.SelectedValue;

                var eklendi = Database.Model.Randevular.RandevuEkle(rdv);
                if (eklendi)
                {
                    MessageBox.Show("KAYIT BAŞARIYLA TAMAMLANDI", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("KAYIT OLUŞTURULAMADI", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
       
                Randevular formr = Application.OpenForms.OfType<Randevular>().FirstOrDefault();
                if (formr != null)
                {
                    formr.LoadDataIntoGridr(); // İlk formun veri yükleme metodunu çağır
                }

                this.Close();



            }

           
        }
        private void FillComboSearchHasta()
        {
            
            
                var hastaList = Database.Model.Hastalar.dbh.HASTALAR
                    .Select(h => new
                    {
                        HASTAID = h.HASTAID,
                        ADSOYAD = h.HastaAdi + " " + h.HastaSoyadi
                    }).ToList();

                _HastaBilgisi_comboBox.DataSource = hastaList;
                _HastaBilgisi_comboBox.ValueMember = "HASTAID";
                _HastaBilgisi_comboBox.DisplayMember = "ADSOYAD";
            
        }

        private void RandevuEkle_Load(object sender, EventArgs e)
        {
            FillComboSeachCode();
            FillComboSearchHasta();
        }

        private void _RandevuTarihi_dateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void _HastaBilgisi_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void _doktorBilgisi_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
