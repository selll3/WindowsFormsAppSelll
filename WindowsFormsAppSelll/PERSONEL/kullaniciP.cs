using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppSelll.PERSONEL
{
    public partial class kullaniciP : Form
    {
        public kullaniciP()
        {
            InitializeComponent();
        }

        private void _Hastalar_button_Click(object sender, EventArgs e)
        {
            Hastalar hst = new Hastalar();
            hst.ShowDialog();
        }

        private void _randevular_button_Click(object sender, EventArgs e)
        {
            Randevular randevular = new Randevular();
            randevular.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
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
