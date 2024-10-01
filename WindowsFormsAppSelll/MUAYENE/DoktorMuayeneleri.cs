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
using WindowsFormsAppSelll.KULLANICI;

namespace WindowsFormsAppSelll.MUAYENE
{
    public partial class DoktorMuayeneleri : Form
    {
        //private int doktorid;
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
            using (var context = new Hastanedb())
            {
                var personelID = context.PERSONEL
                    .Where(p => p.KULLANICIID == kullaniciId)
                    .Select(p => p.PERSONELID)
                    .FirstOrDefault();

                if (personelID > 0)
                {
                    var doktorID = context.DOKTORLAR
                        .Where(d => d.PERSONELID == personelID)
                        .Select(d => d.DOKTORID)
                        .FirstOrDefault();

                    if (doktorID > 0)
                    {
                        var muayeneler = context.MUAYENE
                            .Where(m => m.DOKTORID == doktorID && m.MuayeneTarihi >= DateTime.Now)
                            .Select(m => new
                            {
                                m.MUAYENEID,
                                m.HASTAID,
                                m.DOKTORID,
                                m.MuayeneTarihi,
                                m.Aciklama,
                                m.islendiBilgisi
                            })
                            .ToList();

                        _DoktorMuayeneleri_dataGridView.DataSource = muayeneler; // DataGridView'e verileri bağlıyoruz
                    }
                    else
                    {
                        MessageBox.Show("Giriş yapan kullanıcı doktor değil.");
                    }
                }
            }
        }
        private int GetPersonelIDByKullaniciID(int kullaniciID)
        {
            int personelID = 0;
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-99R82DT;Initial Catalog=_HASTANE;Integrated Security=True;Encrypt=False"))
            {
                con.Open();
                // KULLANICIID'yi kullanarak PERSONEL tablosundan PERSONELID'yi alıyoruz
                SqlCommand cmd = new SqlCommand("SELECT PERSONELID FROM PERSONEL WHERE KULLANICIID = @kullaniciID", con);
                cmd.Parameters.AddWithValue("@kullaniciID", kullaniciID);

                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    personelID = (int)result;
                }
            }
            return personelID;
        }
        private int GetDoctorIDByPersonelID(int personelID)
        {
            int doktorID = 0;
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-99R82DT;Initial Catalog=_HASTANE;Integrated Security=True;Encrypt=False"))
            {
                con.Open();
                // PERSONEL tablosundan PersonelGorev'e göre doktor olup olmadığını kontrol ediyoruz
                SqlCommand checkCmd = new SqlCommand("SELECT PersonelGorev FROM PERSONEL WHERE PERSONELID = @personelID", con);
                checkCmd.Parameters.AddWithValue("@personelID", personelID);
                string personelGorev = (string)checkCmd.ExecuteScalar();

                if (personelGorev == "Doktor")
                {
                    // Eğer personel bir doktor ise, DOKTORLAR tablosundan DOKTORID'yi alıyoruz
                    SqlCommand cmd = new SqlCommand("SELECT DOKTORID FROM DOKTORLAR WHERE PersonelID = @personelID", con);
                    cmd.Parameters.AddWithValue("@personelID", personelID);

                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        doktorID = (int)result;
                    }
                }
            }
            return doktorID;
        }
        private void LoadUpcomingAppointments(int doktorID)
        {
            DataTable dtMuayeneler = GetGelecekMuayeneler(doktorID);
            _DoktorMuayeneleri_dataGridView.DataSource = dtMuayeneler; // Muayeneleri grid üzerinde göster
        }

        private DataTable GetGelecekMuayeneler(int doktorID)
        {
            DataTable muayeneTablosu = new DataTable();
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-99R82DT;Initial Catalog=_HASTANE;Integrated Security=True;Encrypt=False"))
            {
                con.Open();
                // Gelecek muayeneleri almak için sorgu
                SqlCommand cmd = new SqlCommand("SELECT MUAYENEID,HASTAID,DOKTORID,MuayeneTarihi,Aciklama,islendiBilgisi FROM MUAYENE WHERE DOKTORID = @doktorID AND MuayeneTarihi >= GETDATE()", con);
                cmd.Parameters.AddWithValue("@doktorID", doktorID);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(muayeneTablosu);
            }
            return muayeneTablosu;
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
            GetGelecekMuayeneler(doktorID);
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
