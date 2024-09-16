using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsAppSelll.ENTITY;

namespace WindowsFormsAppSelll
{
    public partial class Personeller : Form
    {
        public Personeller()
        {
            InitializeComponent();
            _Personeller_dataGridView.Visible = false;

        }






        private void _PersonelilListele_button_Click(object sender, EventArgs e)
        {

            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    control.Visible = false;
                }
                else if (control is NumericUpDown)
                {
                    control.Visible = false;
                }
                else if (control is Label)
                {
                    control.Visible = false;
                }
                else
                {
                    control.Visible = true;
                }
            }
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-99R82DT;Initial Catalog=_HASTANE;Integrated Security=True;Encrypt=False");
            string readQuery = "Select PERSONELID,PersonelAdi,PersonelSoyadi,PersonelGorev from PERSONEL";
            SqlDataAdapter sdp = new SqlDataAdapter(readQuery, con);
            SqlCommandBuilder cmd = new SqlCommandBuilder();
            DataTable dtp = new DataTable();
            sdp.Fill(dtp);
            _Personeller_dataGridView.DataSource = dtp;


        }


        private void verileriyükle()
        {


            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    control.Visible = false;
                }
                else if (control is NumericUpDown)
                {
                    control.Visible = false;
                }
                else if (control is Label)
                {
                    control.Visible = false;
                }
                else
                {
                    control.Visible = true;
                }
            }
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-99R82DT;Initial Catalog=_HASTANE;Integrated Security=True;Encrypt=False");
            string readQuery = "Select PERSONELID,PersonelAdi,PersonelSoyadi,PersonelGorev from PERSONEL";
            SqlDataAdapter sdp = new SqlDataAdapter(readQuery, con);
            SqlCommandBuilder cmd = new SqlCommandBuilder();
            DataTable dtp = new DataTable();
            sdp.Fill(dtp);
            _Personeller_dataGridView.DataSource = dtp;



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

        private void _Sil_button_Click(object sender, EventArgs e)
        {

            if (_Personeller_dataGridView.SelectedRows.Count > 0)
            {
                int selectedRowId = Convert.ToInt32(_Personeller_dataGridView.SelectedRows[0].Cells["PERSONELID"].Value); // ID sütununu kullanarak silme işlemi yapacağız
                string connectionString = "Data Source=DESKTOP-99R82DT;Initial Catalog=_HASTANE;Integrated Security=True;Encrypt=False";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "DELETE FROM PERSONEL WHERE PERSONELID = @PERSONELID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PERSONELID", selectedRowId);
                        command.ExecuteNonQuery();
                        MessageBox.Show("SİLME İŞLEMİ BAŞARIYLA TAMAMLANDI", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

            }
            else
            {
                MessageBox.Show("Lütfen silinecek satırı seçin.");
            }
            verileriyükle();
        }

        private void _GUNCELLE_button_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-99R82DT;Initial Catalog=_HASTANE;Integrated Security=True;Encrypt=False");
            con.Open();
            string updateQuery = "UPDATE PERSONEL SET PersonelAdi=@PersonelAdi,PersonelSoyadi=@PersonelSoyadi,PersonelGorev=@PersonelGorev WHERE PERSONELID=@PERSONELID ";
            SqlCommand cmd = new SqlCommand(updateQuery, con);
            cmd.Parameters.AddWithValue("@PersonelAdi", _PersonelAdi_textBox.Text);
            cmd.Parameters.AddWithValue("@PersonelSoyadi", _PersonelSoyadi_textBox.Text);
            cmd.Parameters.AddWithValue("@PersonelGorev",_Gorevi_textBox.Text);
            cmd.Parameters.AddWithValue("@PERSONELID", _PERSONEL_numericUpDown.Value);

            int count = cmd.ExecuteNonQuery();
            con.Close();
            if (count > 0)
            {
                MessageBox.Show("GÜNCELLEME BAŞARIYLA TAMAMLANDI", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("GÜNCELLEME BAŞARISIZ", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }



        private void _Ekle_button_Click(object sender, EventArgs e)
            {
                bool isAnyEmpty = false;
                foreach (Control control in this.Controls)
                {
                    // Sadece TextBox'ları kontrol et
                    if (control is TextBox && string.IsNullOrWhiteSpace(control.Text))
                    {
                        isAnyEmpty = true;
                        break;
                    }
                }

                if (isAnyEmpty)
                {
                    MessageBox.Show("Doldurmalısın!!", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    SqlConnection con = new SqlConnection("Data Source=DESKTOP-99R82DT;Initial Catalog=_HASTANE;Integrated Security=True;Encrypt=False");
                    string insertQuery = "INSERT INTO PERSONEL(PersonelAdi,PersonelSoyadi,PersonelGorev) VALUES(@Personeladi, @Personelsoyadi, @Personelgorev)";
                    con.Open();
                    SqlCommand cmd = new SqlCommand(insertQuery, con);
                    cmd.Parameters.AddWithValue("@Personeladi", _PersonelAdi_textBox.Text);
                    cmd.Parameters.AddWithValue("@Personelsoyadi", _PersonelSoyadi_textBox.Text);
                    cmd.Parameters.AddWithValue("@Personelgorev", _Gorevi_textBox.Text);

                    int count = cmd.ExecuteNonQuery();
                    con.Close();
                    if (count > 0)
                    {
                        MessageBox.Show("KAYIT BAŞARIYLA TAMAMLANDI", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("KAYIT OLUŞTURULAMADI", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }

        

        private void _Personeller_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void Personeller_Load(object sender, EventArgs e)
        {

        }

        private void _Kayıt_button_Click(object sender, EventArgs e)
        {
              foreach(Control control in this.Controls)
            {
                if (control is DataGridView)
                {
                    control.Visible=false;
                }
                else
                {
                    control.Visible=true;
                }

            }
            
        }
    }



    //using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-99R82DT;Initial Catalog=_HASTANE;Integrated Security=True;Encrypt=False"))
    //{
    //    con.Open(); // Bağlantıyı aç

    //    for (int item = 0; item < _Personeller_dataGridView.Rows.Count; item++)
    //{
    //    // Satırdaki PERSONELID'nin null olup olmadığını kontrol et
    //    //var personelId = _Personeller_dataGridView.Rows[item].Cells["PERSONELID"].Value;
    //    //if (personelId == null || personelId == DBNull.Value)
    //    //{
    //    //    MessageBox.Show("PERSONELID değeri eksik veya null.");
    //    //    continue; // Eğer ID yoksa, bu satırı atla
    //    //}

    //    SqlCommand cmd2 = new SqlCommand("UPDATE PERSONEL SET PersonelAdi=@PersonelAdi, PersonelSoyadi=@PersonelSoyadi, PersonelGorev=@PersonelGorev WHERE PERSONELID=@PERSONELID", con);

    //        // Parametreleri ekle
    //        cmd2.Parameters.AddWithValue("@PersonelAdi", _Personeller_dataGridView.Rows[item].Cells["PersonelAdi"].Value ?? (object)DBNull.Value);
    //        cmd2.Parameters.AddWithValue("@PersonelSoyadi", _Personeller_dataGridView.Rows[item].Cells["PersonelSoyadi"].Value ?? (object)DBNull.Value);
    //        cmd2.Parameters.AddWithValue("@PersonelGorev", _Personeller_dataGridView.Rows[item].Cells["PersonelGorev"].Value ?? (object)DBNull.Value);

    //    //cmd2.Parameters.AddWithValue("@PERSONELID", personelId);

    //    // Sorguyu çalıştır
    //    cmd2.ExecuteNonQuery();
    //    }

    //    con.Close(); // Bağlantıyı kapat
    //}

    //MessageBox.Show("Satır güncellemesi başarılı");


    // PERSONEL prs = new PERSONEL();
    //prs.PersonelAdi = _PersonelAdi_textBox.Text;
    // prs.PersonelSoyadi = _PersonelSoyadi_textBox.Text;
    // prs.PersonelGorev = _Gorevi_textBox.Text;


    // Hastanedb dbp = new Hastanedb();

    // dbp.PERSONEL.Add(prs);
    // dbp.SaveChanges();







}
