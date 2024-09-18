using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsAppSelll.KULLANICI;

namespace WindowsFormsAppSelll
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void _DOK_button1_Click(object sender, EventArgs e)
        {   
            Kullanıcılar klnc = new Kullanıcılar();
         
             
            
            Doktorlar DKF = new Doktorlar();
            DKF.ShowDialog();
        }

        private void _RANDE_button2_Click(object sender, EventArgs e)
        {
            Randevular rdvf = new Randevular();
            rdvf.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hastalar hstf = new Hastalar();
            hstf.ShowDialog();
        }

        private void _PERS_button4_Click(object sender, EventArgs e)
        {
            Personeller prsf = new Personeller();
            prsf.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

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
