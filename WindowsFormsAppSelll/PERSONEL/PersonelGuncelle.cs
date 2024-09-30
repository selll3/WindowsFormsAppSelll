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
using Database.Entity;

namespace WindowsFormsAppSelll
{
    public partial class PersonelGuncelle : Form
    {

        //SqlConnection con = new SqlConnection("Data Source=DESKTOP-99R82DT;Initial Catalog=_HASTANE;Integrated Security=True;Encrypt=False");
        //SqlDataAdapter daPG;
        //DataTable dtPG;
        int selectedDoctorID;
        public PersonelGuncelle()
        {
            InitializeComponent();
            LoadDataP();
        }
        private void LoadDataP()
        {
            using (var context = new Hastanedb()) // Entity Framework DBContext sınıfınızın adı
            {
                var personelListesi = context.PERSONEL
                    .Select(p => new
                    {
                        p.PERSONELID,
                        p.PersonelAdi,
                        p.PersonelSoyadi,
                        p.PersonelGorev
                    }).ToList();

                _personelguncelle_dataGridView.DataSource = personelListesi;

                if (_personelguncelle_dataGridView.Columns.Contains("PERSONELID"))
                {
                    _personelguncelle_dataGridView.Columns["PERSONELID"].Visible = false;
                }
             
            }
        }
        private void UpdateDoctorInfo(int personelID)
        {
            using (var context = new Hastanedb())
            {
                var doktor = context.DOKTORLAR
                    .FirstOrDefault(d => d.PERSONELID == personelID);

                if (doktor != null)
                {
                    var selectedRow = _personelguncelle_dataGridView.Rows.Cast<DataGridViewRow>()
                        .FirstOrDefault(row => Convert.ToInt32(row.Cells["PERSONELID"].Value) == personelID);

                    if (selectedRow != null)
                    {
                        doktor.DoktorAdi = selectedRow.Cells["PersonelAdi"].Value?.ToString();
                        doktor.DoktorSoyadi = selectedRow.Cells["PersonelSoyadi"].Value?.ToString();

                        context.SaveChanges();
                    }
                }
            }
        }
        private bool IsDoctor(int personelID)
        {
            using (var context = new Hastanedb())
            {
                return context.PERSONEL
                    .Any(p => p.PERSONELID == personelID && p.PersonelGorev == "Doktor");
            }
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

        private void PersonelGuncelle_Load(object sender, EventArgs e)
        {
            _personelguncelle_dataGridView.RowHeadersVisible = false;
            _personelguncelle_dataGridView.Columns["PersonelAdi"].ReadOnly = false;
            _personelguncelle_dataGridView.Columns["PersonelSoyadi"].ReadOnly = false;
            _personelguncelle_dataGridView.Columns["PersonelGorev"].ReadOnly = true;
           
            //_personelguncelle_dataGridView.EditMode = DataGridViewEditMode.EditOnEnter;

            //    _personelguncelle_dataGridView.RowHeadersVisible = false;
            //    _personelguncelle_dataGridView.RowHeadersVisible = false;
        }

        private void _kaydet_button_Click(object sender, EventArgs e)
        {

            if (selectedDoctorID == 0)
            {
                MessageBox.Show("Lütfen bir Personel seçin.");
                return;
            }

            using (var context = new Hastanedb())
            {
                var personel = context.PERSONEL
                    .FirstOrDefault(p => p.PERSONELID == selectedDoctorID);

                if (personel != null)
                {
                    var selectedRow = _personelguncelle_dataGridView.Rows.Cast<DataGridViewRow>()
                        .FirstOrDefault(row => Convert.ToInt32(row.Cells["PERSONELID"].Value) == selectedDoctorID);

                    if (selectedRow != null)
                    {
                        personel.PersonelAdi = selectedRow.Cells["PersonelAdi"].Value?.ToString();
                        personel.PersonelSoyadi = selectedRow.Cells["PersonelSoyadi"].Value?.ToString();
                        personel.PersonelGorev = selectedRow.Cells["PersonelGorev"].Value?.ToString();

                        context.SaveChanges();

                        UpdateDoctorInfo(selectedDoctorID);
                    }
                }
            }

            // İlk formu güncelle ve göster
            Personeller formpers = (Personeller)Application.OpenForms["Personeller"];
            formpers.LoadDataIntoGridp();
            this.Close();

        }

        private void _personelguncelle_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && _personelguncelle_dataGridView.Rows.Count > 0)
            {
                selectedDoctorID = Convert.ToInt32(_personelguncelle_dataGridView.Rows[e.RowIndex].Cells["PERSONELID"].Value);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
