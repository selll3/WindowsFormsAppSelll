using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsAppSelll.ENTITY;

namespace WindowsFormsAppSelll.MUAYENE
{
    public partial class Muayeneler : Form
    {
        public Muayeneler()
        {
            InitializeComponent();
        }
        public void LoadDataMuayene()
        {
         Hastanedb dm = new Hastanedb();
          dataGridView1.DataSource = dm.MUAYENE;

            // FOREİGN KEY İLE ANAHTARLARI BAĞLAMAMIŞIM SQL BAĞLIYORUM
        }
        private void Muayeneler_Load(object sender, EventArgs e)
        {

        }
    }
}
