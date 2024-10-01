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
    public partial class doktorekle : Form
    {

       

        public doktorekle(/*i*//*nt kullaniciID*/)
        {
            InitializeComponent();
            //this.kullaniciID = kullaniciID;
            //LoadData();
        }

       

        private void LoadData()
        {
            
            
        }
        private void doktorekle_Load(object sender, EventArgs e)
        {
           
        }

        private void _kaydet_button_Click(object sender, EventArgs e)
        {
           
            bool isAnyEmpty = false;
            foreach (Control control in this.Controls)
            {
                //Sadece TextBox'ları kontrol et
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
                
                

            }


           

            // İlk formu güncelle ve göster
            Doktorlar form1 = Application.OpenForms.OfType<Doktorlar>().FirstOrDefault();
            if (form1 != null)
            {
                form1.LoadDataIntoGrid(); // İlk formun veri yükleme metodunu çağır
            }

            this.Close();
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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
    
}
