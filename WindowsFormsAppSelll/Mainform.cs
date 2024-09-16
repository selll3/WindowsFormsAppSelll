using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppSelll
{
    public partial class Mainform : Form
    {
        public Mainform()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Randevular frm = new Randevular();
            frm.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
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

        private void _D_button_Click(object sender, EventArgs e)
        {
            Doktorlar frmd = new Doktorlar();
            frmd.ShowDialog();
        }

        private void _H_button_Click(object sender, EventArgs e)
        {
            Hastalar frmh = new Hastalar();
            frmh.ShowDialog();
        }

        private void _P_button_Click(object sender, EventArgs e)
        {
            Personeller frmp = new Personeller();
            frmp.ShowDialog();
        }
    }
}
