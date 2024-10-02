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
    public partial class HastaEkle : Form
    {
        //    SqlConnection con = new SqlConnection("Data Source=DESKTOP-99R82DT;Initial Catalog=_HASTANE;Integrated Security=True;Encrypt=False");
        //    SqlDataAdapter daHE;
        //    DataTable dtHE;
        public HastaEkle()
        {
            InitializeComponent();
            //LoadDataHE();
        }
        private void LoadDataHE()
        {
            //   
        }
        private void HastaEkle_Load(object sender, EventArgs e)
        {
           
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
                HASTALAR hst = new HASTALAR();
                hst.HastaAdi = _HastaAdi_textBox.Text;
                hst.HastaSoyadi = _HastaSoyadi_textBox.Text;
                hst.HastaYasi = (int?)numericUpDown1.Value;
                var eklendi = Database.Model.Hastalar.HastaEkle(hst);
                if (eklendi)
                {
                   
                  
                    MessageBox.Show("KAYIT BAŞARIYLA TAMAMLANDI", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


                else
                {
                    MessageBox.Show("KAYIT OLUŞTURULAMADI", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
               
            }


            // İlk formu güncelle ve göster
            Hastalar formh = Application.OpenForms.OfType<Hastalar>().FirstOrDefault();
            if (formh != null)
            {
                formh.LoadDataIntoGridh(); // İlk formun veri yükleme metodunu çağır
            }

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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
