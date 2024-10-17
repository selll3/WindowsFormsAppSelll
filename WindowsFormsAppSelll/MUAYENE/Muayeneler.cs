using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using WindowsFormsAppSelll.ENTITY;
using Database.Entity;

namespace WindowsFormsAppSelll.MUAYENE
{
    public partial class Muayeneler : Form
    {
        private int Hid;
        public Muayeneler(int hastaid )
        {
            InitializeComponent();
            LoadDataMuayene();
            Hid = hastaid;
            yetkileriolustur();
        }
        private int currentUserId;
        private Hastanedb dbContext = new Hastanedb();
        private void yetkileriolustur()
        {

            var userPermissions = dbContext.PERSONELFORMYETKILERI
                                           .Where(p => p.KULLANICIID == currentUserId && p.Yetki == true)
                                           .ToList();


            foreach (var permission in userPermissions)
            {
                switch (permission.FormID)
                {
                    case 17:
                        _Ekle_button.Enabled = true;
                        break;
                    


                }
            }
        }

        public void LoadDataMuayene()
        {
            //Hastanedb dp = new Hastanedb();
            //dataGridView1.DataSource = dp.MUAYENE.ToList();

            Hastanedb dbm = new Hastanedb();
            dataGridView1.DataSource = dbm.MUAYENE
                .Select(r => new
                {
                    r.MUAYENEID,  // İstediğin sütunları buraya ekleyebilirsin
                    r.MuayeneTarihi,
                    r.Aciklama,
                    r.DOKTORID,
                    r.HASTAID,
                    r.islendiBilgisi
                    
                    // r.Bulgu gibi başka sütunlar da ekleyebilirsin
                }).ToList();

          
        }
        private void Muayeneler_Load(object sender, EventArgs e)
        {
            dataGridView1.RowHeadersVisible = false;
        }

        private void _Ekle_button_Click(object sender, EventArgs e)
        {
            MuayeneEkle mekle = new MuayeneEkle(Hid);
            mekle.Show();
        }

        private void vazgec_button_Click(object sender, EventArgs e)
        {
            //foreach (Control control in this.Controls)
            //{
            //    if (control is TextBox)
            //    {
            //        control.Text = string.Empty;
            //    }
            //}

            // Formu kapat
            this.Close();
        }
    }
}
