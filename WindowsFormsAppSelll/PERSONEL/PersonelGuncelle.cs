﻿using System;
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

namespace WindowsFormsAppSelll
{
    public partial class PersonelGuncelle : Form
    {

       
        int selectedDoctorID;
        private int personelId;
        private string personelGorev;
        public PersonelGuncelle(int id, string adi, string soyadi, string gorev)
        {
            InitializeComponent();
            personelId = id;
            personelGorev = gorev;

            // TextBox'lara bilgileri doldur
            _PersonelAdi_textBox.Text = adi;
            _PersonelSoyadi_textBox.Text = soyadi;
            //_PersonelGorev_textBox.Text = gorev;
        }
        //private void LoadDataP()
        //{
        //    Hastanedb dbP = new Hastanedb();
     

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

        private void PersonelGuncelle_Load(object sender, EventArgs e)
        {
           
        }

        private void _kaydet_button_Click(object sender, EventArgs e)
        {

           
            
                // PERSONEL tablosundaki bilgileri güncelle
                var personel = Database.Model.Personeller.dp.PERSONEL.FirstOrDefault(p => p.PERSONELID == personelId);
                if (personel != null)
                {
                    // Personel bilgilerini güncelle
                    personel.PersonelAdi = _PersonelAdi_textBox.Text;
                    personel.PersonelSoyadi = _PersonelSoyadi_textBox.Text;

                    // Model katmanındaki güncelleme yöntemini çağır
                    bool personelGuncellendi = Database.Model.Personeller.PersonelGuncelle(personel);

                    // Eğer personelin görevi "Doktor" ise DOKTORLAR tablosunu güncelle
                    if (personelGorev.Equals("Doktor", StringComparison.OrdinalIgnoreCase))
                    {
                        var doktor = Database.Model.Doktorlar.dbd.DOKTORLAR.FirstOrDefault(d => d.PERSONELID == personelId);
                        if (doktor != null)
                        {
                            doktor.DoktorAdi = _PersonelAdi_textBox.Text;
                            doktor.DoktorSoyadi = _PersonelSoyadi_textBox.Text;

                            // Model katmanındaki doktor güncelleme yöntemini çağır
                            bool doktorGuncellendi = Database.Model.Doktorlar.DoktorGuncelle(doktor);
                        }
                    }

                    Database.Model.Personeller.dp.SaveChanges(); // Değişiklikleri kaydet
                    MessageBox.Show("Personel başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Personel bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            

            // İlk formu güncelle ve göster
            Personeller formpers = (Personeller)Application.OpenForms["Personeller"];
            formpers.LoadDataIntoGridp();
            this.Close();





           

        }

        private void _personelguncelle_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex >= 0 && dataGridView1.Rows.Count > 0)
            //{
            //    selectedDoctorID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["PERSONELID"].Value);
            //}
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
