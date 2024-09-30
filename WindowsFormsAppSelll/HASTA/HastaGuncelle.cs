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
/*using WindowsFormsAppSelll.ENTITY*//*;*/
using Database.Entity;

namespace WindowsFormsAppSelll
{
    public partial class HastaGuncelle : Form
    {

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-99R82DT;Initial Catalog=_HASTANE;Integrated Security=True;Encrypt=False");
        SqlDataAdapter daHG;
        DataTable dtHG;
        int selectedDoctorID;
        public HastaGuncelle()
        {
            InitializeComponent();
            LoadDataH();
        }
        private void LoadDataH()
        {
            dtHG = new DataTable();
            string readQuery = "Select HASTAID, HastaAdi,HastaSoyadi, HastaYasi from HASTALAR";
            daHG = new SqlDataAdapter(readQuery, con);
            daHG.Fill(dtHG);
            _hastaguncelle_dataGridView.DataSource = dtHG;

            // DataGridView verileri yüklendikten sonra sütunları gizle
            if (_hastaguncelle_dataGridView.Columns.Contains("HASTAID"))
            {
                _hastaguncelle_dataGridView.Columns["HASTAID"].Visible = false;
            }
        }
        private void HastaGuncelle_Load(object sender, EventArgs e)
        {
            _hastaguncelle_dataGridView.RowHeadersVisible = false;
        }

        private void _kaydet_button_Click(object sender, EventArgs e)
        {
            if (selectedDoctorID == 0) // ID seçilmemişse
            {
                MessageBox.Show("Lütfen bir doktor seçin.");
                return;
            }

            using (var context = new Hastanedb())
            {
                // Seçilen doktorun ID'sine göre ilgili hastayı bul
                var  hasta = context.HASTALAR.FirstOrDefault(h => h.HASTAID == selectedDoctorID);
                
                if (hasta != null)
                {
                    // DataGridView'den güncel verileri al ve güncelle
                    foreach (DataGridViewRow row in _hastaguncelle_dataGridView.Rows)
                    {
                        if (Convert.ToInt32(row.Cells["HASTAID"].Value) == selectedDoctorID)
                        {
                            hasta.HastaAdi = row.Cells["HastaAdi"].Value?.ToString() ?? null;
                            hasta.HastaSoyadi = row.Cells["HastaSoyadi"].Value?.ToString() ?? null;
                            hasta.HastaYasi = row.Cells["HastaYasi"].Value != null ? Convert.ToInt32(row.Cells["HastaYasi"].Value) : (int?)null;

                            // Veritabanına güncellemeleri kaydet
                            context.SaveChanges();
                            _hastaguncelle_dataGridView.DataSource = Database.Model.Hastalar.HastaGuncelle(hasta);
                            MessageBox.Show("Güncelleme işlemi başarıyla tamamlandı.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                           
                        }
                    }
                    
                }
                else
                {
                    MessageBox.Show("Güncellenecek hasta bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        
            // İlk formu güncelle ve göster
            Hastalar form1 = (Hastalar)Application.OpenForms["Hastalar"];
            form1.LoadDataIntoGridh(); // İlk formun veri yükleme metodunu çağır
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

        private void _hastaguncelle_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && _hastaguncelle_dataGridView.Rows.Count > 0)
            {
                selectedDoctorID = Convert.ToInt32(_hastaguncelle_dataGridView.Rows[e.RowIndex].Cells["HASTAID"].Value);
            }
        }

        private void _hastaguncelle_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
