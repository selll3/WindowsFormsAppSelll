using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppSelll.Muhasebe
{
    public partial class KullaniciM : Form
    {
        public KullaniciM()
        {
            InitializeComponent();
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

        private void _Hastalar_button_Click(object sender, EventArgs e)
        {
            Hastalar HSTalar = new Hastalar();
            HSTalar.ShowDialog();

        }

        private void _PERSONELLER_button_Click(object sender, EventArgs e)
        {
           Personeller personel = new Personeller();
            personel.ShowDialog();
        }

        private void DOKTORLAR_BUTTON_Click(object sender, EventArgs e)
        {
            Doktorlar dkt = new Doktorlar();
            dkt.ShowDialog();
        }
    }
}
