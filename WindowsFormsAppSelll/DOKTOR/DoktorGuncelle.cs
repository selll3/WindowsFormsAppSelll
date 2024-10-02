using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Database.Entity;

namespace WindowsFormsAppSelll
{
    public partial class DoktorGuncelle : Form
    {


        //SqlConnection con = new SqlConnection("Data Source=DESKTOP-99R82DT;Initial Catalog=_HASTANE;Integrated Security=True;Encrypt=False");
        //SqlDataAdapter da;
        //DataTable dt;
        int selectedDoctorID;
        int selectedPersonelID; 

        public DoktorGuncelle(int doktorID, int personelID)
        {
            InitializeComponent();
            //LoadData();
            selectedDoctorID = doktorID;
            selectedPersonelID = personelID;
            LoadDoctorData();

        }
        private void LoadDoctorData()
        {

            using (Hastanedb dbContext = new Hastanedb())
            {   var doktor = dbContext.DOKTORLAR
           .Where(d => d.DOKTORID == selectedDoctorID)
           .Select(d => new
           {
               d.DoktorAdi,
               d.DoktorSoyadi,
               d.DoktorunBransi,
               d.Doktorun_kati
           })
           .FirstOrDefault();

            if (doktor != null)
            {
                _DoktorAdi_textBox.Text = doktor.DoktorAdi;
                _DoktorSoyadi_textBox.Text = doktor.DoktorSoyadi;
               comboBox1.SelectedItem = doktor.DoktorunBransi;
                numericUpDown1.Value = (int)doktor.Doktorun_kati; // NumericUpDown kullanıyorsanız
            }
        }
        }

        private void UpdateDoctorAndPersonel()
        {
            using (Hastanedb dbContext = new Hastanedb())
            {     // Doktor ve personel güncelleme işlemleri
                var doktor = dbContext.DOKTORLAR.Find(selectedDoctorID);
            var personel = dbContext.PERSONEL.Find(selectedPersonelID);

            if (doktor != null && personel != null)
            {
                // Doktorun eski adı ve soyadı
                string oldDoktorAdi = doktor.DoktorAdi;
                string oldDoktorSoyadi = doktor.DoktorSoyadi;

                // Güncellenen değerleri ata
                doktor.DoktorAdi = _DoktorAdi_textBox.Text;
                doktor.DoktorSoyadi = _DoktorSoyadi_textBox.Text;
                doktor.DoktorunBransi = comboBox1.SelectedItem.ToString();
                doktor.Doktorun_kati = (int)numericUpDown1.Value;

                // Eğer doktor adı veya soyadı değiştiyse, personeli de güncelle
                if (oldDoktorAdi != doktor.DoktorAdi || oldDoktorSoyadi != doktor.DoktorSoyadi)
                {
                    personel.PersonelAdi = doktor.DoktorAdi;
                    personel.PersonelSoyadi = doktor.DoktorSoyadi;
                }

                dbContext.SaveChanges();
                MessageBox.Show("Doktor ve Personel bilgileri başarıyla güncellendi.");
            }
        }

        }


        private void DoktorGuncelle_Load(object sender, EventArgs e)
        {
            //_DoktorlarGuncelle_dataGridView.RowHeadersVisible = false;
            // _DoktorlarGuncelle_dataGridView.Columns["DOKTORID"].Visible = false;
        }
        //PERSONEL GÜNCELLENDİĞİNDE DOKTOR GÜNCELLENİYOR MU
        // ARTI OLARAK DOKTOR GÜNCELLENDİĞİNDE PERSONEL GÖREVİ DOKTOR OLANLAR GÜNCELLENİYOR MU
        private void button1_Click(object sender, EventArgs e)
        {
            UpdateDoctorAndPersonel();

            // İlk formu güncelle ve göster
            Doktorlar form1 = (Doktorlar)Application.OpenForms["Doktorlar"];
            form1.LoadDataIntoGrid(); // İlk formun veri yükleme metodunu çağır
            this.Close();

        }

        private void _DoktorlarGuncelle_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void _DoktorlarGuncelle_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex >= 0 && _DoktorlarGuncelle_dataGridView.Rows.Count > 0)
            //{
            //    selectedDoctorID = Convert.ToInt32(_DoktorlarGuncelle_dataGridView.Rows[e.RowIndex].Cells["DOKTORID"].Value);
            //    selectedPersonelID = Convert.ToInt32(_DoktorlarGuncelle_dataGridView.Rows[e.RowIndex].Cells["PERSONELID"].Value); // PersonelID'yi de al
            //}
         
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
    }
}
