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

        //public delegate void HastaGuncellendiEventHandler(object sender, EventArgs e);
        //public event HastaGuncellendiEventHandler HastaGuncellendi;
        int selectedDoctorID;
        private int hastaID;
        public HastaGuncelle(int selectedHastaId)
        {
            InitializeComponent();
            ///*LoadDataH()*/;
             hastaID = selectedHastaId;
            LoadHastaBilgileri();
        }
        private void LoadHastaBilgileri()
        {
            using (Hastanedb dbContext = new Hastanedb())
            {
                var hasta = dbContext.HASTALAR.FirstOrDefault(h => h.HASTAID == hastaID);
                if (hasta != null)
                {
                    _HastaAdi_textBox.Text = hasta.HastaAdi;
                    _HastaSoyadi_textBox.Text = hasta.HastaSoyadi;
                    numericUpDown1.Value = (int)hasta.HastaYasi;
                }
                else
                {
                    MessageBox.Show("Hasta bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
        }
        private void HastaGuncelle_Load(object sender, EventArgs e)
        {
            
        }

        private void _kaydet_button_Click(object sender, EventArgs e)
        {
          
            
                var hasta = Database.Model.Hastalar.dbh.HASTALAR.FirstOrDefault(h => h.HASTAID == hastaID);
                if (hasta != null)
                {
                    hasta.HastaAdi = _HastaAdi_textBox.Text;
                    hasta.HastaSoyadi = _HastaSoyadi_textBox.Text;
                    hasta.HastaYasi = (int)numericUpDown1.Value;
                    var hastagunc = Database.Model.Hastalar.HastaGuncelle(hasta);
                   if(hastagunc)
                   {
                    MessageBox.Show("Hasta bilgileri başarıyla güncellendi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                   }
                   else
                   {
                    MessageBox.Show("Hasta güncellenemedi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                   }                              //dbContext.SaveChanges();
                                            //HastaGuncellendi?.Invoke(this, EventArgs.Empty);
                   
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

        private void _hastaguncelle_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            //if (e.RowIndex >= 0 && _hastaguncelle_dataGridView.Rows.Count > 0)
            //{
            //    selectedDoctorID = Convert.ToInt32(_hastaguncelle_dataGridView.Rows[e.RowIndex].Cells["HASTAID"].Value);
            //}
        }

        private void _hastaguncelle_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void _HastaAdi_textBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
