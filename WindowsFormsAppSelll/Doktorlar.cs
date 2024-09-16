﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppSelll
{
    public partial class Doktorlar : Form
    {
        public Doktorlar()
        {
            InitializeComponent();
            _Doktorlar_dataGridView.Visible = false;
        }

        private void Doktorlar_Load(object sender, EventArgs e)
        {

        }

        private void _DoktorListele_button_Click(object sender, EventArgs e)
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
            string readQuery = "Select DOKTORID,DoktorAdi,DoktorSoyadi,DoktorunBransi,Doktorun_kati from DOKTORLAR ";
            SqlDataAdapter sda = new SqlDataAdapter(readQuery, con);
            SqlCommandBuilder cmd = new SqlCommandBuilder();
            DataTable dta = new DataTable();
            sda.Fill(dta);
            _Doktorlar_dataGridView.DataSource = dta;

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



           
                
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-99R82DT;Initial Catalog=_HASTANE;Integrated Security=True;Encrypt=False");
                con.Open();
                string updateQuery = "UPDATE DOKTORLAR SET DoktorAdi=@DoktorAdi,DoktorSoyadi=@DoktorSoyadi,DoktorunBransi=@DoktorunBransi,Doktorun_kati=@Doktorunkati WHERE DOKTORID=@DOKTORID ";
                SqlCommand cmd = new SqlCommand(updateQuery, con);
                cmd.Parameters.AddWithValue("@DoktorAdi", _DoktorAdi_textBox.Text);
                cmd.Parameters.AddWithValue("@DoktorSoyadi", _DoktorSoyadi_textBox.Text);
                cmd.Parameters.AddWithValue("@DoktorunBransi", _DoktorBranşi_textBox.Text);
                cmd.Parameters.AddWithValue("@Doktorunkati", _DoktorunKati_textBox.Text);
                cmd.Parameters.AddWithValue("@DOKTORID", numericUpDown1.Value);

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
            string readQuery = "Select DOKTORID,DoktorAdi,DoktorSoyadi,DoktorunBransi,Doktorun_kati from DOKTORLAR ";
            SqlDataAdapter sda = new SqlDataAdapter(readQuery, con);
            SqlCommandBuilder cmd = new SqlCommandBuilder();
            DataTable dta = new DataTable();
            sda.Fill(dta);
            _Doktorlar_dataGridView.DataSource = dta;

        }






        private void _Sil_button_Click(object sender, EventArgs e)
        {
            
            
                if (_Doktorlar_dataGridView.SelectedRows.Count > 0)
                {
                    int selectedRowId = Convert.ToInt32(_Doktorlar_dataGridView.SelectedRows[0].Cells["DOKTORID"].Value); // ID sütununu kullanarak silme işlemi yapacağız
                    string connectionString = "Data Source=DESKTOP-99R82DT;Initial Catalog=_HASTANE;Integrated Security=True;Encrypt=False";
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string query = "DELETE FROM DOKTORLAR WHERE DOKTORID = @DOKTORID";
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@DOKTORID", selectedRowId);
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
                // DOKTORLAR dr = new DOKTORLAR();
                //  dr.DoktorAdi = _DoktorAdi_textBox.Text;
                // dr.DoktorSoyadi = _DoktorSoyadi_textBox.Text;
                // dr.DoktorSoyadi = _DoktorBranşi_textBox.Text;
                // dr.DoktorSoyadi = _DoktorunKati_textBox.Text;


                //  Hastanedb db = new Hastanedb();

                // db.DOKTORLAR.Add(dr);
                // db.SaveChanges();


                SqlConnection con = new SqlConnection("Data Source=DESKTOP-99R82DT;Initial Catalog=_HASTANE;Integrated Security=True;Encrypt=False");
                string insertQuery = "INSERT INTO DOKTORLAR(DoktorAdi,DoktorSoyadi,DoktorunBransi,Doktorun_kati) VALUES(@DoktorAdi, @DoktorSoyadi, @Doktorbransi, @Doktorunkati) ";
                con.Open();
                SqlCommand cmd = new SqlCommand(insertQuery, con);
                cmd.Parameters.AddWithValue("@DoktorAdi", _DoktorAdi_textBox.Text);
                cmd.Parameters.AddWithValue("@DoktorSoyadi", _DoktorSoyadi_textBox.Text);
                cmd.Parameters.AddWithValue("@DoktorBransi", _DoktorBranşi_textBox.Text);
                cmd.Parameters.AddWithValue("@Doktorunkati", _DoktorunKati_textBox.Text);
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

        private void _Kayıt_button_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control is DataGridView)
                {
                    control.Visible = false;
                }
                else
                {
                    control.Visible = true;
                }

            }
        }
    }
}
