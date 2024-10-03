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
//using Database.Entity.MUAYENE;
using WindowsFormsAppSelll.KULLANICI;

namespace WindowsFormsAppSelll.MUAYENE
{
    public partial class DoktorMuayeneleri : Form
    {
        //private int doktorid;
        //public static Hastanedb muayene = new Hastanedb();
        public static int kullaniciId;
        public DoktorMuayeneleri(int Kid)
        {
            InitializeComponent();
           
            kullaniciId = Kid;
           _DoktorMuayeneleri_dataGridView.CellDoubleClick += _DoktorMuayeneleri_dataGridView_CellDoubleClick;
            DoktorMuayeneleriniListele();

        }


        private void DoktorMuayeneleriniListele()
        {
            
            
                var personelID = Database.Model.Personeller.dp.PERSONEL
                    .Where(p => p.KULLANICIID == kullaniciId)
                    .Select(p => p.PERSONELID)
                    .FirstOrDefault();

                if (personelID > 0)
                {
                    var doktorID = Database.Model.Doktorlar.dbd.DOKTORLAR
                        .Where(d => d.PERSONELID == personelID)
                        .Select(d => d.DOKTORID)
                        .FirstOrDefault();

                    if (doktorID > 0)
                    {
                        var muayeneler = Database.Model.Muayeneler.GetMuayenelerByDoktorID(doktorID);  // Modelden veriyi alıyoruz
                        _DoktorMuayeneleri_dataGridView.DataSource = muayeneler.Select(m => new
                        {
                            m.MUAYENEID,
                            m.HASTAID,
                            m.DOKTORID,
                            m.MuayeneTarihi,
                            m.Aciklama,
                            m.islendiBilgisi
                        }).ToList(); // DataGridView'e bağlıyoruz
                    }
                    else
                    {
                        MessageBox.Show("Giriş yapan kullanıcı doktor değil.");
                    }
                }
            
        }
        private int GetPersonelIDByKullaniciID(int kullaniciID)
        {
           
            {
                // KullaniciID'ye göre PersonelID'yi alıyoruz
                return Database.Model.Personeller.dp.PERSONEL
                    .Where(p => p.KULLANICIID == kullaniciID)
                    .Select(p => p.PERSONELID)
                    .FirstOrDefault();
            }
        }
        private int GetDoctorIDByPersonelID(int personelID)
        {
            
            
                // Personel görevinin doktor olup olmadığını kontrol ediyoruz
                string personelGorev = Database.Model.Personeller.dp.PERSONEL
                    .Where(p => p.PERSONELID == personelID)
                    .Select(p => p.PersonelGorev)
                    .FirstOrDefault();

                if (personelGorev == "Doktor")
                {
                    // Eğer personel doktor ise, Doktorlar tablosundan doktorID'yi alıyoruz
                    return Database.Model.Doktorlar.dbd.DOKTORLAR
                        .Where(d => d.PERSONELID == personelID)
                        .Select(d => d.DOKTORID)
                        .FirstOrDefault();
                }
                return 0; // Doktor değilse 0 döndürüyoruz
            
        }
        private void LoadUpcomingAppointments(int doktorID)
        {
            var muayeneler = GetGelecekMuayeneler(doktorID);
            _DoktorMuayeneleri_dataGridView.DataSource = muayeneler.Select(m => new
            {
                m.MUAYENEID,
                m.HASTAID,
                m.DOKTORID,
                m.MuayeneTarihi,
                m.Aciklama,
                m.islendiBilgisi
            }).ToList(); // Muayeneleri Da
            //DataTable dtMuayeneler = GetGelecekMuayeneler(doktorID);
            //_DoktorMuayeneleri_dataGridView.DataSource = dtMuayeneler; // Muayeneleri grid üzerinde göster
        }

        private List<Database.Entity.MUAYENE> GetGelecekMuayeneler(int doktorID)
        {
            //using (var context = new Hastanedb())
            //{
                // Doktorun gelecekteki muayenelerini listeleme
                return Database.Model.Muayeneler.dbm.MUAYENE
                    .Where(m => m.DOKTORID == doktorID && m.MuayeneTarihi >= DateTime.Now)
                    .ToList();
            //}
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DoktorMuayeneleri_Load(object sender, EventArgs e)
        {
            _DoktorMuayeneleri_dataGridView.RowHeadersVisible = false;

            // Giriş yapan kullanıcının KULLANICIID'sini al
            int kullaniciID = kullaniciId ;

                // PERSONELID'yi bul
                int personelID = GetPersonelIDByKullaniciID( kullaniciID);

                // DOKTORID'yi bul
                int doktorID = GetDoctorIDByPersonelID(personelID);

            // Doktorun gelecekteki muayenelerini yükle
            //GetGelecekMuayeneler(doktorID);
            LoadUpcomingAppointments(doktorID);


        }

        private void _DoktorMuayeneleri_dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Geçerli bir satıra tıklandığında
            {
                // Muayene DataGridView'den HASTAID'yi alıyoruz
                int hastaID = Convert.ToInt32(_DoktorMuayeneleri_dataGridView.Rows[e.RowIndex].Cells["HASTAID"].Value);
                // Hasta bilgileri formunu açıyoruz ve hasta ID'sini gönderiyoruz
                DMuayeneleriAyrinti hastaForm = new DMuayeneleriAyrinti(hastaID);
                hastaForm.ShowDialog(); // Modal olarak açıyoruz
            }
        }

        private void _Vazgec_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
