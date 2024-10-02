using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Database.Entity;
using WindowsFormsAppSelll.KULLANICI;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WindowsFormsAppSelll
{
    public partial class Doktorlar : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-99R82DT;Initial Catalog=_HASTANE;Integrated Security=True;Encrypt=False");
        SqlDataAdapter da;
        DataTable dt;
        // Kullanıcı ID'yi alır (LINQ veya SQL sorgusu ile)
        private int currentUserId;
        private Hastanedb dbContext = new Hastanedb();


        public Doktorlar(int userId)
        {
            InitializeComponent();
            LoadDataIntoGrid();
            currentUserId = userId;
            yetkileriolustur();
           


        }
        private void yetkileriolustur()
        {
           
            var userPermissions = dbContext.PERSONELFORMYETKILERI
                                           .Where(p => p.KULLANICIID == currentUserId && p.Yetki == true)
                                           .ToList();

            
            foreach (var permission in userPermissions)
            {
                switch (permission.FormID)
                {
                    case 2:  
                        _Ekle_button.Enabled = true;
                        
                        break;
                    case 3:  
                        _GUNCELLE_button.Enabled = true;
                        _Sil_button.Enabled = true;
                        
                        break;
                   

                        
                }
            }
        }

        public void LoadDataIntoGrid()
        {
            var doktorlarList = dbContext.DOKTORLAR
            .Select(d => new
            {
                d.DOKTORID,
                d.DoktorAdi,
                d.DoktorSoyadi,
                d.DoktorunBransi,
                d.Doktorun_kati,
                d.PERSONELID
            })
            .ToList();

            _Doktorlar_dataGridView.DataSource = doktorlarList;
            //    _Doktorlar_dataGridView.AutoGenerateColumns = false;
            //    _Doktorlar_dataGridView.DataSource = Database.Model.Doktorlar.DoktorlariGetir();


            // DOKTORID sütununu gizle
            if (_Doktorlar_dataGridView.Columns.Contains("DOKTORID"))
            {
                _Doktorlar_dataGridView.Columns["DOKTORID"].Visible = false;
            }
           
        }


        private void Doktorlar_Load(object sender, EventArgs e)
        {

            _Doktorlar_dataGridView.RowHeadersVisible = false;

            //_Doktorlar_dataGridView.Columns["DoktorAdi"].ReadOnly = true;
            //_Doktorlar_dataGridView.Columns[1].ReadOnly = true;
            //_Doktorlar_dataGridView.Columns[2].ReadOnly = true;
            //_Doktorlar_dataGridView.Columns[3].ReadOnly = true;
            //_Doktorlar_dataGridView.Columns[4].ReadOnly = true;
        }

        private void _DoktorListele_button_Click(object sender, EventArgs e)
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

        private void _GUNCELLE_button_Click(object sender, EventArgs e)
        {



           
                
               



        }
        //private void verileriyükle()
        //{
        //    foreach (Control control in this.Controls)
        //    {
        //        if (control is TextBox)
        //        {
        //            control.Visible = false;
        //        }
        //        else if (control is NumericUpDown)
        //        {
        //            control.Visible = false;
        //        }
        //        else if (control is Label)
        //        {
        //            control.Visible = false;
        //        }
        //        else
        //        {
        //            control.Visible = true;
        //        }
        //    }
        //    SqlConnection con = new SqlConnection("Data Source=DESKTOP-99R82DT;Initial Catalog=_HASTANE;Integrated Security=True;Encrypt=False");
        //    string readQuery = "SELECT DoktorAdi,DoktorSoyadi,DoktorunBransi,Doktorun_kati FROM DOKTORLAR";
        //    SqlDataAdapter sda = new SqlDataAdapter(readQuery, con);
        //    SqlCommandBuilder cmd = new SqlCommandBuilder();
        //    DataTable dta = new DataTable();
        //    sda.Fill(dta);
        //    _Doktorlar_dataGridView.DataSource = dta;

        //}






        private void _Sil_button_Click(object sender, EventArgs e)
        {

            if (_Doktorlar_dataGridView.SelectedRows.Count > 0)
            {
                int selectedRowId = Convert.ToInt32(_Doktorlar_dataGridView.SelectedRows[0].Cells["DOKTORID"].Value);

                //var doktorToDelete = dbContext.DOKTORLAR.Find(selectedRowId);
                if (selectedRowId != 0)
                {
                    //dbContext.DOKTORLAR.Remove(selectedRowId);
                    var doktorlarsilindi =Database.Model.Doktorlar.DoktorlariSil(selectedRowId);
                    if(doktorlarsilindi)
                    {
                        MessageBox.Show("SİLME İŞLEMİ BAŞARIYLA TAMAMLANDI", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        dbContext.SaveChanges();

                        LoadDataIntoGrid();

                    }
                    else
                    {
                        MessageBox.Show("BAŞARISIZ SİLME İŞLEMİ", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }


                }
            }
            else
            {
                MessageBox.Show("Lütfen silinecek satırı seçin.");
            }

         

        }
        
        private void _Ekle_button_Click(object sender, EventArgs e)
        {
            
                doktorekle form3 = new doktorekle();
                form3.Show();
            


           
        }

        private void _Kayıt_button_Click(object sender, EventArgs e)
        {
         
        }
        private void UpdateRowInDatabase(int doktorID, string doktorAdi, string doktorSoyadi, string doktorBransi, string doktorunKati)
        {
           
        }
        private void _Doktorlar_dataGridView_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
           
        }

        private void _GUNCELLE_button_Click_1(object sender, EventArgs e)
        {
            if (_Doktorlar_dataGridView.SelectedRows.Count > 0)
            {
                int selectedDoctorID = Convert.ToInt32(_Doktorlar_dataGridView.SelectedRows[0].Cells["DoktorID"].Value);
                int selectedPersonelID = Convert.ToInt32(_Doktorlar_dataGridView.SelectedRows[0].Cells["PersonelID"].Value);

                DoktorGuncelle updateForm = new DoktorGuncelle(selectedDoctorID, selectedPersonelID);
                updateForm.ShowDialog();

                LoadDataIntoGrid(); // Güncelleme sonrası verileri tekrar yükle
            }
            else
            {
                MessageBox.Show("Lütfen güncellenecek bir doktor seçin.");
            }
        }

        private void _Doktorlar_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
