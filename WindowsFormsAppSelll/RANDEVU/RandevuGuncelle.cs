using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

namespace WindowsFormsAppSelll
{
    public partial class RandevuGuncelle : Form
    {
        //SqlConnection con = new SqlConnection("Data Source=DESKTOP-99R82DT;Initial Catalog=_HASTANE;Integrated Security=True;Encrypt=False");
        //SqlDataAdapter daRG;
        //DataTable dtRG;
        int selectedDoctorID;
        public RandevuGuncelle()
        {
            InitializeComponent();
            LoadDataR();
        }
        private void LoadDataR()
        {
            Hastanedb dbr = new Hastanedb();


            _randevuguncelle_dataGridView.DataSource = dbr.RANDEVULAR
               .Select(r => new
               {
                   r.RANDEVUID,  // İstediğin sütunları buraya ekleyebilirsin
                   r.Randevu_Tarihi,
                   r.Randevu_Saati,
                   r.DOKTORID,
                   r.HASTAID,
                   r.Bulgu
                   // r.Bulgu gibi başka sütunlar da ekleyebilirsin
               }).ToList();
           
            if (_randevuguncelle_dataGridView.Columns.Contains("RANDEVUID"))
            {
                _randevuguncelle_dataGridView.Columns["RANDEVUID"].Visible = false;
            }
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
                var randevu = context.RANDEVULAR.FirstOrDefault(h => h.RANDEVUID == selectedDoctorID);

                if (randevu != null)
                {
                    // DataGridView'den güncel verileri al ve güncelle
                    foreach (DataGridViewRow row in _randevuguncelle_dataGridView.Rows)
                    {
                        if (Convert.ToInt32(row.Cells["RANDEVUID"].Value) == selectedDoctorID)
                        {
                            randevu.Randevu_Tarihi = row.Cells["Randevu_Tarihi"].Value != null
         ? Convert.ToDateTime(row.Cells["Randevu_Tarihi"].Value)
         : (DateTime?)null;

                            randevu.Randevu_Saati = row.Cells["Randevu_Saati"].Value != null
        ? TimeSpan.Parse(row.Cells["Randevu_Saati"].Value.ToString())
        : (TimeSpan?)null;
                            randevu.Bulgu = row.Cells["Bulgu"].Value?.ToString() ?? null;
                            randevu.DOKTORID = row.Cells["DOKTORID"].Value != null
       ? Convert.ToInt32(row.Cells["DOKTORID"].Value)
       : (int?)null;
                            // Veritabanına güncellemeleri kaydet
                            context.SaveChanges();
                            //_randevuguncelle_dataGridView.DataSource = Database.Model.Hastalar.HastaGuncelle(randevu);
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
            Randevular form1 = (Randevular)Application.OpenForms["Randevular"];
            form1.LoadDataIntoGridr(); // İlk formun veri yükleme metodunu çağır
            this.Close();
            //if (selectedDoctorID == 0) // ID seçilmemişse
            //{
            //    MessageBox.Show("Lütfen bir RANDEVU seçin.");
            //    return;
            //}

            //con.Open();
            //SqlCommand cmd = new SqlCommand("UPDATE RANDEVULAR SET Randevu_Tarihi = @Rtarih, Randevu_Saati = @Rsaat, Bulgu = @bulgu,DOKTORID= @did WHERE RANDEVUID = @Rid", con);

            //// Sütunlardaki verileri güncelle
            //foreach (DataGridViewRow row in _randevuguncelle_dataGridView.Rows)
            //{
            //    if (Convert.ToInt32(row.Cells["RANDEVUID"].Value) == selectedDoctorID)
            //    {
            //        cmd.Parameters.AddWithValue("@Rtarih", row.Cells["Randevu_Tarihi"].Value ?? (object)DBNull.Value);
            //        cmd.Parameters.AddWithValue("@Rsaat", row.Cells["Randevu_Saati"].Value ?? (object)DBNull.Value);
            //        cmd.Parameters.AddWithValue("@bulgu", row.Cells["Bulgu"].Value ?? (object)DBNull.Value);
            //        cmd.Parameters.AddWithValue("@did", row.Cells["DOKTORID"].Value ?? (object)DBNull.Value);
            //        cmd.Parameters.AddWithValue("@Rid", selectedDoctorID);

            //        cmd.ExecuteNonQuery();
            //        break;
            //    }
            //}


            //    // rdv.DoktorSoyadi = _DoktorSoyadi_textBox.Text;
            //    // rdv.DoktorSoyadi = _DoktorBranşi_textBox.Text;
            //    // rdv.DoktorSoyadi = _DoktorunKati_textBox.Text;


            //    //  Hastanedb hstl = new Hastanedb();

            //    // db.DOKTORLAR.Add(dr);
            //    // db.SaveChanges();

            //cmd.Parameters.AddWithValue("@Hadi", row.Cells["HastaAdi"].Value ?? (object)DBNull.Value);
            //cmd.Parameters.AddWithValue("@Hsoyadi", row.Cells["HastaSoyadi"].Value ?? (object)DBNull.Value);
            //cmd.Parameters.AddWithValue("@HYasi", row.Cells["HastaYasi"].Value ?? (object)DBNull.Value);
            //cmd.Parameters.AddWithValue("@Hid", selectedDoctorID);

            //cmd.ExecuteNonQuery();


            //con.Close();

            // İlk formu güncelle ve göster
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

            if (e.RowIndex >= 0 && _randevuguncelle_dataGridView.Rows.Count > 0)
            {
                selectedDoctorID = Convert.ToInt32(_randevuguncelle_dataGridView.Rows[e.RowIndex].Cells["RANDEVUID"].Value);
            }
        }

        private void RandevuGuncelle_Load(object sender, EventArgs e)
        {
            _randevuguncelle_dataGridView.RowHeadersVisible = false;
        }
    }
}
