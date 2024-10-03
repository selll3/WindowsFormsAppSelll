using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using WindowsFormsAppSelll.ENTITY;
using Database.Entity;
using WindowsFormsAppSelll.KULLANICI;
using WindowsFormsAppSelll.MUAYENE;

namespace WindowsFormsAppSelll
{
    public partial class Main : Form
    {
        private int currentUserId;
        
        private Hastanedb dbContext = new Hastanedb();

        //private int currentUserId;
        //private Hastanedb dbContext = new Hastanedb();
        public Main(int userId)
        {
            InitializeComponent();
           
            currentUserId = userId;  // Login formundan gelen kullanıcı ID'si
            yetkileriolustur();
           
            //_DOK_button1.Enabled = false;
            //_hastalar_button.Enabled = false;
            //_PERS_button4.Enabled = false;
            //_RANDE_button2.Enabled = false;
            //_kullanicilarb.Enabled = false;
            //currentUserId = userId;  // Login formundan gelen kullanıcı ID'si
            //LoadUserPermissions();


        }
        public void yetkileriolustur()
        {
            
            var userPermissions = dbContext.PERSONELFORMYETKILERI
                                           .Where(p => p.KULLANICIID == currentUserId && p.Yetki == true)
                                           .ToList();

            foreach (var permission in userPermissions)
            {
                switch (permission.FormID)
                {
                    case 1:  
                        _DOK_button1.Enabled = true;       
                        break;
                    case 4: 
                        _hastalar_button.Enabled = true;  
                        break;
                    case 7:  
                              _PERS_button4.Enabled = true;
                        break;

                    case 10: _RANDE_button2.Enabled = true;
                        
                        break;
                    case 15: _kullanicilarb.Enabled = true;
                       
                        break;
                    case 18: _Muayene_button.Enabled= true;
                        break;
                    case 20: _DoktorMuayeneleri_button.Enabled = true;
                        break;
                        
                }
            }
        }

        //private void LoadUserPermissions()
        //{
        //    // Kullanıcının yetkilerini PERSONELFORMYETKILERI tablosundan alıyoruz
        //    var userPermissions = dbContext.PERSONELFORMYETKILERI
        //                                   .Where(p => p.KULLANICIID == currentUserId && p.Yetki == true)
        //                                   .ToList();

        //    // Yetkilere göre ana formdaki butonları kontrol ediyoruz
        //    foreach (var permission in userPermissions)
        //    {
        //        switch (permission.FormID)
        //        {
        //            case 1:  // Doktorlar Formu yetkisi
        //                btnDoktorlar.Enabled = true;
        //                break;
        //            case 2:  // Hastalar Formu yetkisi
        //                btnHastalar.Enabled = true;
        //                break;
        //            case 3:  // Raporlar Formu yetkisi
        //                btnRaporlar.Enabled = true;
        //                break;
        //                // Diğer butonlar için yetkileri ekleyebilirsiniz
        //        }
        //    }
        //}
        private void Main_Load(object sender, EventArgs e)
        {
         KullaniciGiris klnc = new KullaniciGiris();

            //Doktorlar doktorlar = new Doktorlar();
            //doktorlar._Ekle_button.Enabled = false;
            //doktorlar._GUNCELLE_button.Enabled = false;
            //doktorlar._Sil_button.Enabled = false;

        }

        public void _DOK_button1_Click(object sender, EventArgs e)
        {



            Doktorlar doktorlar = new Doktorlar(currentUserId);

            //doktorlar._Ekle_button.Enabled = false;
            //doktorlar._GUNCELLE_button.Enabled = false;
            //doktorlar._Sil_button.Enabled = false;



            doktorlar.Show();
        }

        private void _RANDE_button2_Click(object sender, EventArgs e)
        {
            Randevular randevular1 = new Randevular(currentUserId);
           
            //randevular1._Ekle_button.Enabled = false;
            //randevular1._GUNCELLE_button.Enabled = false;
            //randevular1._Sil_button.Enabled = false;

            randevular1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hastalar hastalar1 = new Hastalar(currentUserId);
          
            //hastalar1._Ekle_button.Enabled = false;
            //hastalar1._GUNCELLE_button.Enabled = false;
            //hastalar1._Sil_button.Enabled = false;

            hastalar1.Show();
        }

        private void _PERS_button4_Click(object sender, EventArgs e)
        {
            Personeller personeller1 = new Personeller(currentUserId);
          
            //personeller1._Ekle_button.Enabled = false;
            //personeller1._GUNCELLE_button.Enabled = false;
            //personeller1._Sil_button.Enabled = false;

            personeller1.Show();
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

        private void _kullanicilarb_Click(object sender, EventArgs e)
        {
            Kullanicilar kullanicilar1 = new Kullanicilar(currentUserId);

            
            //kullanicilar1._Guncelle_button.Enabled = false;
            //kullanicilar1._SIL_button.Enabled = false;
            //kullanicilar1._EKLE_button.Enabled = false;
            //kullanicilar1._Yetkilerigor_button.Enabled = false;

            kullanicilar1.Show();
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //foreach (Control control in this.Controls)
            //{
            //    if (control is Button)
            //    {
            //        control.Enabled = true;
            //    }
            //}

            // Formu kapat
            this.Close();
            //foreach (Control control in this.Controls)
            //{
            //    if (control is TextBox)
            //    {
            //        control.Text = string.Empty;
            //    }
            //}

            // Formu kapat


            //this.Close();

        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            //this.Close();
            Application.Exit();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            //this.Close();
        }

        private void _Muayene_button_Click(object sender, EventArgs e)
        {
            //Muayeneler mm = new Muayeneler(currentUserId);
            Muayeneler mm = new Muayeneler(currentUserId);
            mm.Show();
            //mm.Show();


        }

        private void _DoktorMuayeneleri_button_Click(object sender, EventArgs e)
        {
            DoktorMuayeneleri dm = new DoktorMuayeneleri(currentUserId);
            dm.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}

