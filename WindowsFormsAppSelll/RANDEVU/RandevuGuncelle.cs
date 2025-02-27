﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using WindowsFormsAppSelll.ENTITY;
using Database.Entity;
//using WindowsFormsAppSelll.ENTITY;

namespace WindowsFormsAppSelll
{
    public partial class RandevuGuncelle : Form
    {
       
        int selectedDoctorID;
        private int randevuId;
        private string Bulgun;
        private DateTime randevuTarihi_;
        private TimeSpan RandevuSaati;
        private int Doktorid;
        private int hastaid;
        public RandevuGuncelle(int id, DateTime randevuTarihi, TimeSpan randevuSaati, string bulgu, int did,int hid)
        {
            InitializeComponent();
            randevuId = id;
            randevuTarihi_ = randevuTarihi;
            RandevuSaati = randevuSaati;
            Bulgun = bulgu;
            Doktorid = did;
            hastaid=hid;

            // TextBox'lara bilgileri doldur
        _RandevuTarihi_dateTimePicker.Value = randevuTarihi;
            _RandevuSaati_dateTimePicker.Value = randevuTarihi.Date.Add(randevuSaati);
            _Bulgu_textBox.Text = bulgu;
            _doktorBilgisi_comboBox.SelectedValue= did.ToString();
            _HastaBilgisi_comboBox.SelectedValue= hid.ToString();
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

        private void _kaydet_button_Click(object sender, EventArgs e)
        {   // Seçilen doktorun ID'sini kontrol et
            if (_doktorBilgisi_comboBox.SelectedValue == null)
            {
                MessageBox.Show("Lütfen bir doktor seçin.");
                return;
            }

            // Seçilen hasta ID'sini kontrol et
            if (_HastaBilgisi_comboBox.SelectedValue == null)
            {
                MessageBox.Show("Lütfen bir hasta seçin.");
                return;
            }

            // Güncellenmiş verileri al
            int selectedDoctorID = (int)_doktorBilgisi_comboBox.SelectedValue;
            int selectedHastaID = (int)_HastaBilgisi_comboBox.SelectedValue;
            DateTime randevuTarihi = _RandevuTarihi_dateTimePicker.Value;
            TimeSpan randevuSaati = _RandevuSaati_dateTimePicker.Value.TimeOfDay;
            string bulgu = _Bulgu_textBox.Text;

            using (Hastanedb db = new Hastanedb())
            {
                // Randevu kaydını bul
                var randevu = db.RANDEVULAR.SingleOrDefault(r => r.RANDEVUID == randevuId);

                if (randevu != null)
                {
                    // Randevu bilgilerini güncelle
                    randevu.Randevu_Tarihi = randevuTarihi;
                    randevu.Randevu_Saati = randevuSaati;
                    randevu.DOKTORID = selectedDoctorID;
                    randevu.HASTAID = selectedHastaID;
                    randevu.Bulgu = bulgu;
                    var randevuguncelle = Database.Model.Randevular.RandevuGuncelle(randevu);
                    if (randevuguncelle)
                    {

                    MessageBox.Show("Randevu başarıyla güncellendi.");
                    this.Close(); // Formu kapat
                    }
                     else
                {
                    MessageBox.Show("Randevu bulunamadı.");
                }// Değişiklikleri kaydet
                    //db.SaveChanges();

                }
               
            }
           
         
            

            //// İlk formu güncelle ve göster
            Randevular formr = (Randevular)Application.OpenForms["Randevular"];
            formr.LoadDataIntoGridr(); // İlk formun veri yükleme metodunu çağır
            this.Close();
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

        private void _randevuguncelle_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            //if (e.RowIndex >= 0 && _randevuguncelle_dataGridView.Rows.Count > 0)
            //{
            //    selectedDoctorID = Convert.ToInt32(_randevuguncelle_dataGridView.Rows[e.RowIndex].Cells["RANDEVUID"].Value);
            //}
        }

        private void RandevuGuncelle_Load(object sender, EventArgs e)
        {
            FillComboSeachCode();
            FillComboSearchHasta();
         
        }
    }
}
