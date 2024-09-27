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
using WindowsFormsAppSelll.ENTITY;

namespace WindowsFormsAppSelll
{
    public partial class PersonelEkle : Form
    {
        private int selectedpersonelid;
        public PersonelEkle()
        {
            InitializeComponent();
        }
        //private void AddOrUpdateDoctor(int personelID)
        //{
        //    using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-99R82DT;Initial Catalog=_HASTANE;Integrated Security=True;Encrypt=False"))
        //    {
        //        con.Open();

        //        try
        //        {
        //            // Örnek olarak branş ve kat bilgilerini almak için sorgu
        //            SqlCommand getDoctorInfoCmd = new SqlCommand(
        //                "SELECT PersonelAdi,PersonelSoyadi FROM PERSONEL WHERE PERSONELID = @Pid AND PersonelGorev = 'Doktor'", con);
        //            getDoctorInfoCmd.Parameters.AddWithValue("@Pid", personelID);

        //            using (SqlDataReader reader = getDoctorInfoCmd.ExecuteReader())
        //            {
        //                if (reader.Read()) // Veriyi oku
        //                {
                          
                            

        //                    // Doktorlar tablosuna ekleme işlemi
        //                    SqlCommand insertDoctorCmd = new SqlCommand(
        //                        "INSERT INTO DOKTORLAR (DoktorAdi, DoktorSoyadi, PERSONELID) " +
        //                        "VALUES (@DoktorAdi, @DoktorSoyadi,  @Pid)", con);

        //                    insertDoctorCmd.Parameters.AddWithValue("@DoktorAdi", _PersonelAdi_textBox.Text);
        //                    insertDoctorCmd.Parameters.AddWithValue("@DoktorSoyadi", _PersonelSoyadi_textBox.Text);
        //                     // BranşID'yi ekle
                            
        //                    insertDoctorCmd.Parameters.AddWithValue("@Pid", personelID); // PersonelID'yi ekle

        //                    insertDoctorCmd.ExecuteNonQuery();
        //                    MessageBox.Show("Doktor başarıyla eklendi.");
        //                }
        //                else
        //                {
        //                    MessageBox.Show("Bu personel doktor değil veya daha önce eklenmiş.");
        //                }
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show("Hata: " + ex.Message);
        //        }
        //    }
        //    //using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-99R82DT;Initial Catalog=_HASTANE;Integrated Security=True;Encrypt=False"))
        //    //{
        //    //    con.Open();

        //    //    // Yeni bir personel doktor ise, doktorlar tablosuna ekleyelim
        //    //    SqlCommand insertDoctorCmd = new SqlCommand(
        //    //        "INSERT INTO DOKTORLAR (DoktorAdi, DoktorSoyadi, DoktorunBransi, Doktorun_kati, PERSONELID) " +
        //    //        "SELECT PersonelAdi, PersonelSoyadi, 'Branş Bilgisi', 'Kat Bilgisi', ersonelID " +
        //    //        "FROM PERSONEL WHERE PERSONELID = @Pid AND PersonelGorev = 'Doktor'", con);

        //    //    insertDoctorCmd.Parameters.AddWithValue("@Pid", personelID);

        //    //    insertDoctorCmd.ExecuteNonQuery();
        //    //}




        //}
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

            using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-99R82DT;Initial Catalog=_HASTANE;Integrated Security=True;Encrypt=False"))
            {
                conn.Open();

                // Aynı kullanıcı zaten atanmış mı kontrol etmek için sorgu
                string checkUserQuery = "SELECT COUNT(*) FROM PERSONEL WHERE KULLANICIID = @kullaniciId";
                SqlCommand checkCmd = new SqlCommand(checkUserQuery, conn);
                checkCmd.Parameters.AddWithValue("@kullaniciId", _kullanici_comboBox.SelectedValue);
                int count = (int)checkCmd.ExecuteScalar();

                if (count > 0)
                {
                    MessageBox.Show("Bu kullanıcı zaten bir personele atanmış!");
                    return;
                }

                // Personeli ekleme işlemi
                string insertPersonelQuery = "INSERT INTO PERSONEL (PersonelAdi, PersonelSoyadi, PersonelGorev, KULLANICIID) " +
                                             "VALUES (@adi, @soyadi, @gorev, @kullaniciId); " +
                                             "SELECT CAST(scope_identity() AS int);"; // Yeni eklenen ID'yi al

                SqlCommand cmd = new SqlCommand(insertPersonelQuery, conn);
                cmd.Parameters.AddWithValue("@adi", _PersonelAdi_textBox.Text);
                cmd.Parameters.AddWithValue("@soyadi", _PersonelSoyadi_textBox.Text);
                cmd.Parameters.AddWithValue("@gorev", comboBox1.SelectedItem); // Görev, combobox'tan alınmalı
                cmd.Parameters.AddWithValue("@kullaniciId", _kullanici_comboBox.SelectedValue);

                // Eklenen personelin ID'sini al
                int newPersonelID = (int)cmd.ExecuteScalar();

                // Eğer personel doktor ise doktorlar tablosuna ekle
                if (comboBox1.SelectedItem.ToString() == "Doktor") // Görev 'Doktor' ise
                {
                    AddDoctor(newPersonelID, _PersonelAdi_textBox.Text, _PersonelSoyadi_textBox.Text);
                }

                MessageBox.Show("Personel başarıyla eklendi.");

                // İlk formu güncelle ve göster
                Personeller form1 = Application.OpenForms.OfType<Personeller>().FirstOrDefault();
                if (form1 != null)
                {
                    form1.LoadDataIntoGridp(); // İlk formun veri yükleme metodunu çağır
                }

                this.Close();
            }
            ////bool isAnyEmpty = false;
            ////foreach (Control control in this.Controls)
            ////{
            ////    Sadece TextBox'ları kontrol et
            ////    if (control is TextBox && string.IsNullOrWhiteSpace(control.Text))
            ////    {
            ////        isAnyEmpty = true;
            ////        break;
            ////    }
            ////}

            ////if (isAnyEmpty)
            ////{
            ////    MessageBox.Show("Doldurmalısın!!", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ////}
            ////else
            ////{
            ////    using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-99R82DT;Initial Catalog=_HASTANE;Integrated Security=True;Encrypt=False"))
            ////    {
            ////        Aynı kullanıcı zaten atanmış mı kontrol etmek için sorgu
            ////        string checkUserQuery = "SELECT COUNT(*) FROM PERSONEL WHERE KULLANICIID = @kullaniciId";
            ////        SqlCommand checkCmd = new SqlCommand(checkUserQuery, conn);
            ////        checkCmd.Parameters.AddWithValue("@kullaniciId", _kullanici_comboBox.SelectedValue);

            ////        conn.Open();
            ////        int count = (int)checkCmd.ExecuteScalar();

            ////        if (count > 0)
            ////        {
            ////            MessageBox.Show("Bu kullanıcı zaten bir personele atanmış!");
            ////            return;
            ////        }

            ////        Personeli ekleme işlemi burada yapılır
            ////        string insertPersonelQuery = "INSERT INTO PERSONEL (PersonelAdi, PersonelSoyadi, PersonelGorev, KULLANICIID) " +
            ////                                     "VALUES (@adi, @soyadi, @gorev, @kullaniciId); " +
            ////                                     "SELECT CAST(scope_identity() AS int);"; // Yeni eklenen ID'yi al

            ////        SqlCommand cmd = new SqlCommand(insertPersonelQuery, conn);
            ////        cmd.Parameters.AddWithValue("@adi", _PersonelAdi_textBox.Text);
            ////        cmd.Parameters.AddWithValue("@soyadi", _PersonelSoyadi_textBox.Text);
            ////        cmd.Parameters.AddWithValue("@gorev", comboBox1.SelectedItem);
            ////        cmd.Parameters.AddWithValue("@kullaniciId", _kullanici_comboBox.SelectedValue);

            ////        Eklenen personelin ID'sini al
            ////        int newPersonelID = (int)cmd.ExecuteScalar();
            ////        AddOrUpdateDoctor(newPersonelID);
            ////        MessageBox.Show("Personel başarıyla eklendi.");

            ////        Eğer personel doktor ise doktorlar tablosuna ekle


            ////    }

            ////    İlk formu güncelle ve göster
            ////   Personeller form1 = Application.OpenForms.OfType<Personeller>().FirstOrDefault();
            ////    if (form1 != null)
            ////    {
            ////        form1.LoadDataIntoGridp(); // İlk formun veri yükleme metodunu çağır
            ////    }

            ////}
            ////this.Close();



        }
        private void AddDoctor(int personelID, string doktorAdi, string doktorSoyadi)
        {
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-99R82DT;Initial Catalog=_HASTANE;Integrated Security=True;Encrypt=False"))
            {
                con.Open();

                // Doktorlar tablosuna ekleme işlemi
                SqlCommand insertDoctorCmd = new SqlCommand(
                    "INSERT INTO DOKTORLAR (DoktorAdi, DoktorSoyadi, DoktorunBransi, Doktorun_kati, PERSONELID) " +
                    "VALUES (@DoktorAdi, @DoktorSoyadi, @BranşID, @KatID, @Pid)", con);

                insertDoctorCmd.Parameters.AddWithValue("@DoktorAdi", doktorAdi); // Personel adı
                insertDoctorCmd.Parameters.AddWithValue("@DoktorSoyadi", doktorSoyadi); // Personel soyadı
                insertDoctorCmd.Parameters.AddWithValue("@BranşID", _doktorunbransi_comboBox.SelectedItem); // Örneğin 1: Genel Cerrahi, bunu dinamik hale getirin
                insertDoctorCmd.Parameters.AddWithValue("@KatID", _doktorunkati_numericUpDown.Value); // Örneğin 1: 1. Kat, bunu dinamik hale getirin
                insertDoctorCmd.Parameters.AddWithValue("@Pid", personelID); // Personel ID'sini ekle

                insertDoctorCmd.ExecuteNonQuery();
                MessageBox.Show("Doktor başarıyla eklendi.");
            }
        }

        private void FillComboSeachCode()
        {
            _kullanici_comboBox.Items.Clear();
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-99R82DT;Initial Catalog=_HASTANE;Integrated Security=True;Encrypt=False");
            con.Open();
            SqlCommand Komut = new SqlCommand();
            Komut = con.CreateCommand();
            Komut.CommandType = CommandType.Text;
            Komut.CommandText = " SELECT g.KULLANICIID, g.KullaniciAdi \r\n            FROM GIRIS g\r\n            LEFT JOIN PERSONEL p ON g.KULLANICIID = p.KULLANICIID\r\n            WHERE p.KULLANICIID IS NULL";
            Komut.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(Komut);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                //comboBox1.Items.Add(dr["DoktorAdi"].ToString());


                _kullanici_comboBox.DataSource = dt;
                _kullanici_comboBox.ValueMember = "KULLANICIID";
                _kullanici_comboBox.DisplayMember = "KullaniciAdi";

            }
            con.Close();


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




//Hastanedb dh = new Hastanedb();
//var Personel = new PERSONEL();
//Personel.PersonelGorev = "Doktor";





//dh.PERSONEL.Add(Personel);
//dh.SaveChanges();

// bool isAnyEmpty = false;
//foreach (Control control in this.Controls)
//{
//    // Sadece TextBox'ları kontrol et
//    if (control is TextBox && string.IsNullOrWhiteSpace(control.Text))
//    {
//        isAnyEmpty = true;
//        break;
//    }
//}

//if (isAnyEmpty)
//{
//    MessageBox.Show("Doldurmalısın!!", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);
//}
//else { 



//using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-99R82DT;Initial Catalog=_HASTANE;Integrated Security=True;Encrypt=False"))
//{
//    // Aynı kullanıcı zaten atanmış mı kontrol etmek için sorgu
//    string checkUserQuery = "SELECT COUNT(*) FROM PERSONEL WHERE KULLANICIID = @kullaniciId";
//    SqlCommand checkCmd = new SqlCommand(checkUserQuery, conn);
//    checkCmd.Parameters.AddWithValue("@kullaniciId", _kullanici_comboBox.SelectedValue);

//        conn.Open();
//    int count = (int)checkCmd.ExecuteScalar();

//    if (count > 0)
//    {
//        MessageBox.Show("Bu kullanıcı zaten bir personele atanmış!");
//        return;
//    }

//    // Personeli ekleme işlemi burada yapılır
//    string insertPersonelQuery = "INSERT INTO PERSONEL (PersonelAdi, PersonelSoyadi, PersonelGorev, KULLANICIID) " +
//                                 "VALUES (@adi, @soyadi, @gorev, @kullaniciId)";
//    SqlCommand cmd = new SqlCommand(insertPersonelQuery, conn);

//    cmd.Parameters.AddWithValue("@adi", _PersonelAdi_textBox.Text);
//    cmd.Parameters.AddWithValue("@soyadi", _PersonelSoyadi_textBox.Text);
//    cmd.Parameters.AddWithValue("@gorev", comboBox1.SelectedItem);
//    cmd.Parameters.AddWithValue("@kullaniciId", _kullanici_comboBox.SelectedValue);

//    cmd.ExecuteNonQuery();
//    conn.Close();

//    MessageBox.Show("Personel başarıyla eklendi.");


//    AddOrUpdateDoctor(selectedpersonelid);



//}
//     }

//// İlk formu güncelle ve göster
//Personeller form1 = Application.OpenForms.OfType<Personeller>().FirstOrDefault();
//if (form1 != null)
//{
//    form1.LoadDataIntoGridp(); // İlk formun veri yükleme metodunu çağır
//}


//bool isAnyEmpty = false;
//foreach (Control control in this.Controls)
//{
//    // Sadece TextBox'ları kontrol et
//    if (control is TextBox && string.IsNullOrWhiteSpace(control.Text))
//    {
//        isAnyEmpty = true;
//        break;
//    }
//}

//if (isAnyEmpty)
//{
//    MessageBox.Show("Doldurmalısın!!", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);
//}
//else
//{
//    SqlConnection con = new SqlConnection("Data Source=DESKTOP-99R82DT;Initial Catalog=_HASTANE;Integrated Security=True;Encrypt=False");
//    string insertQuery = "INSERT INTO PERSONEL(PersonelAdi,PersonelSoyadi,PersonelGorev) VALUES(@Personeladi, @Personelsoyadi, @Personelgorev)";
//    con.Open();
//    SqlCommand cmd = new SqlCommand(insertQuery, con);
//    cmd.Parameters.AddWithValue("@Personeladi", _PersonelAdi_textBox.Text);
//    cmd.Parameters.AddWithValue("@Personelsoyadi", _PersonelSoyadi_textBox.Text);
//    cmd.Parameters.AddWithValue("@Personelgorev",comboBox1.SelectedItem);

//    int count = cmd.ExecuteNonQuery();
//    con.Close();
//    if (count > 0)
//    {
//        MessageBox.Show("KAYIT BAŞARIYLA TAMAMLANDI", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);
//    }
//    else
//    {
//        MessageBox.Show("KAYIT OLUŞTURULAMADI", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);
//    }
//}

//// İlk formu güncelle ve göster
//Personeller form1 = Application.OpenForms.OfType<Personeller>().FirstOrDefault();
//if (form1 != null)
//{
//    form1.LoadDataIntoGridp(); // İlk formun veri yükleme metodunu çağır
//}

//this.Close();
