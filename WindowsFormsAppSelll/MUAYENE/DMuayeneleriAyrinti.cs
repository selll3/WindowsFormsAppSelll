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

namespace WindowsFormsAppSelll.MUAYENE
{
    public partial class DMuayeneleriAyrinti : Form
    {
        private int hastaID;
        public DMuayeneleriAyrinti(int _hastaID)
        {
            InitializeComponent();
            hastaID = _hastaID; // Hasta ID'sini form yüklenirken alıyoruz
            LoadHastaBilgileri();
            LoadHastaMuayeneGecmisi();
        }
        private void LoadHastaMuayeneGecmisi()
        {
            using (var context = new Hastanedb())
            {
                var muayeneGeçmişi = context.MUAYENE
                    .Where(m => m.HASTAID == hastaID)
                    .Select(m => new
                    {
                        m.MUAYENEID,
                        m.MuayeneTarihi,
                        m.Aciklama
                    })
                    .ToList();

                dataGridView1.DataSource = muayeneGeçmişi; // Geçmiş muayeneleri DataGridView'e bağla
            }
        }

        private void LoadHastaBilgileri()
        {
            using (var context = new Hastanedb())
            {
                var hasta = context.HASTALAR
                    .Where(h => h.HASTAID == hastaID)
                    .Select(h => new
                    {
                        h.HastaAdi,
                        h.HastaSoyadi,
                        h.HastaYasi
                    })
                    .FirstOrDefault();

                if (hasta != null)
                {
                    _hastaAdi_textBox.Text = hasta.HastaAdi;
                    _hastaSoyadi_textBox.Text = hasta.HastaSoyadi;
                    _hastaYasi_textBox.Text = hasta.HastaYasi.ToString();
                }
            }
        }

        private void DMuayeneleriAyrinti_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns["MUAYENEID"].Visible = false;
            dataGridView1.Columns["MuayeneTarihi"].HeaderText = "Muayene Tarihi";
           dataGridView1.Columns["Aciklama"].HeaderText = "Açıklama";

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
