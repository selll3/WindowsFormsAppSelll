using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Diagnostics.Eventing.Reader;
//using WindowsFormsAppSelll.ENTITY;
using Database.Entity;

namespace WindowsFormsAppSelll
{
    public partial class PersonelEkle : Form
    {
        private int selectedpersonelid;
        public PersonelEkle()
        {
            InitializeComponent();
        }
  
        private void _kaydet_button_Click(object sender, EventArgs e)
        {
            bool isAnyEmpty = false;
            foreach (Control control in this.Controls)
            {
                if (control is TextBox && string.IsNullOrWhiteSpace(control.Text))
                {
                    isAnyEmpty = true;
                    break;
                }
            }

            if (isAnyEmpty)
            {
                MessageBox.Show("Doldurmalısın!!", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (var context = new Hastanedb()) // Entity Framework DbContext sınıfı
            {
                // Aynı kullanıcı zaten atanmış mı kontrol etmek için sorgu
                var kullaniciId = (int)_kullanici_comboBox.SelectedValue;
                bool kullaniciZatenAtanmis = context.PERSONEL.Any(p => p.KULLANICIID == kullaniciId);

                if (kullaniciZatenAtanmis)
                {
                    MessageBox.Show("Bu kullanıcı zaten bir personele atanmış!");
                    return;
                }

                // Yeni personel ekleme
                var yeniPersonel = new PERSONEL
                {
                    PersonelAdi = _PersonelAdi_textBox.Text,
                    PersonelSoyadi = _PersonelSoyadi_textBox.Text,
                    PersonelGorev = comboBox1.SelectedItem.ToString(),
                    KULLANICIID = kullaniciId
                };

                context.PERSONEL.Add(yeniPersonel);
                context.SaveChanges(); // Veritabanına ekleme işlemi yapılır

                // Eğer personel doktor ise doktorlar tablosuna da ekle
                if (comboBox1.SelectedItem.ToString() == "Doktor")
                {
                    AddDoctor(yeniPersonel.PERSONELID, _PersonelAdi_textBox.Text, _PersonelSoyadi_textBox.Text);
                }

                MessageBox.Show("Personel başarıyla eklendi.");

                // İlk formu güncelle ve göster
                var form1 = Application.OpenForms.OfType<Personeller>().FirstOrDefault();
                if (form1 != null)
                {
                    form1.LoadDataIntoGridp();
                }

                this.Close();
            }
        }
          



        
        private void AddDoctor(int personelID, string doktorAdi, string doktorSoyadi)
        {
            using (var context = new Hastanedb())
            {
                var yeniDoktor = new DOKTORLAR
                {
                    DoktorAdi = doktorAdi,
                    DoktorSoyadi = doktorSoyadi,
                    DoktorunBransi = _doktorunbransi_comboBox.SelectedItem.ToString(), // Branş ID yerine ismi kullanıyoruz
                    Doktorun_kati = (int)_doktorunkati_numericUpDown.Value,
                    PERSONELID = personelID
                };

                context.DOKTORLAR.Add(yeniDoktor);
                context.SaveChanges();

                MessageBox.Show("Doktor başarıyla eklendi.");
            }
        }

        private void FillComboSeachCode()
        {
            using (var context = new Hastanedb())
            {
                var kullaniciListesi = context.GIRIS
                    .Where(g => !context.PERSONEL.Any(p => p.KULLANICIID == g.KULLANICIID)
                                && g.KullaniciAdi.ToLower() != "admin") // "admin" olanları büyük-küçük harf duyarsız olarak hariç tut
                    .Select(g => new
                    {
                        g.KULLANICIID,
                        g.KullaniciAdi
                    }).ToList();

                _kullanici_comboBox.DataSource = kullaniciListesi;
                _kullanici_comboBox.ValueMember = "KULLANICIID";
                _kullanici_comboBox.DisplayMember = "KullaniciAdi";
            }

            //_kullanici_comboBox.Items.Clear();
            //SqlConnection con = new SqlConnection("Data Source=DESKTOP-99R82DT;Initial Catalog=_HASTANE;Integrated Security=True;Encrypt=False");
            //con.Open();
            //SqlCommand Komut = new SqlCommand();
            //Komut = con.CreateCommand();
            //Komut.CommandType = CommandType.Text;
            //Komut.CommandText = " SELECT g.KULLANICIID, g.KullaniciAdi \r\n            FROM GIRIS g\r\n            LEFT JOIN PERSONEL p ON g.KULLANICIID = p.KULLANICIID\r\n            WHERE p.KULLANICIID IS NULL";
            //Komut.ExecuteNonQuery();
            //DataTable dt = new DataTable();
            //SqlDataAdapter da = new SqlDataAdapter(Komut);
            //da.Fill(dt);
            //foreach (DataRow dr in dt.Rows)
            //{
            //    //comboBox1.Items.Add(dr["DoktorAdi"].ToString());


            //    _kullanici_comboBox.DataSource = dt;
            //    _kullanici_comboBox.ValueMember = "KULLANICIID";
            //    _kullanici_comboBox.DisplayMember = "KullaniciAdi";

            //}
            //con.Close();


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

        private void PersonelEkle_Load(object sender, EventArgs e)
        {
            FillComboSeachCode();
        }
    }
}




