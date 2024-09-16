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
using WindowsFormsAppSelll.ENTITY;

namespace WindowsFormsAppSelll
{
    public partial class Hastalar : Form
    {
        public Hastalar()
        {
            InitializeComponent();
            _Hastalar_dataGridView.Visible = false;
        }

        private void _HastalariListele_button_Click(object sender, EventArgs e)
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
            string readQuery = "Select HastaAdi,HastaSoyadi,HastaYasi from HASTALAR";
            SqlDataAdapter sdh = new SqlDataAdapter(readQuery, con);
            SqlCommandBuilder cmd = new SqlCommandBuilder();
            DataTable dth = new DataTable();
            sdh.Fill(dth);
            _Hastalar_dataGridView.DataSource = dth;


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
            string readQuery = "Select HastaAdi,HastaSoyadi,HastaYasi from HASTALAR";
            SqlDataAdapter sdh = new SqlDataAdapter(readQuery, con);
            SqlCommandBuilder cmd = new SqlCommandBuilder();
            DataTable dth = new DataTable();
            sdh.Fill(dth);
            _Hastalar_dataGridView.DataSource = dth;

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


            if (_Hastalar_dataGridView.SelectedRows.Count > 0)
            {
                int selectedRowId = Convert.ToInt32(_Hastalar_dataGridView.SelectedRows[0].Cells["DOKTORID"].Value); // ID sütununu kullanarak silme işlemi yapacağız
                string connectionString = "Data Source=DESKTOP-99R82DT;Initial Catalog=_HASTANE;Integrated Security=True;Encrypt=False";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "DELETE FROM HASTALAR WHERE HASTAID = @HASTAID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@HASTAID", selectedRowId);
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
                //HASTALAR hst = new HASTALAR();
                //hst.HastaAdi = _HastaAdi_textBox.Text;
                //hst.HastaSoyadi = _HastaSoyadi_textBox.Text;
                //hst.HastaYasi = Convert.ToInt32(_HastaYasi_textBox.Text);
                //// int.TryParse

                //Hastanedb dbh = new Hastanedb();

                //dbh.HASTALAR.Add(hst);
                //dbh.SaveChanges();


                SqlConnection con = new SqlConnection("Data Source=DESKTOP-99R82DT;Initial Catalog=_HASTANE;Integrated Security=True;Encrypt=False");
                string insertQuery = "INSERT INTO HASTALAR(HastaAdi,HastaSoyadi,HastaYasi) VALUES(@Hastaadi, @Hastasoyadi, @Hastayasi) ";
                con.Open();
                SqlCommand cmd = new SqlCommand(insertQuery, con);
                cmd.Parameters.AddWithValue("@Hastaadi", _HastaAdi_textBox.Text);
                cmd.Parameters.AddWithValue("@Hastasoyadi", _HastaSoyadi_textBox.Text);
                cmd.Parameters.AddWithValue("@Hastayasi", _HastaYasi_textBox.Text);
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

        private void Hastalar_Load(object sender, EventArgs e)
        {

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

        private void _GUNCELLE_button_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-99R82DT;Initial Catalog=_HASTANE;Integrated Security=True;Encrypt=False");
            con.Open();
            string updateQuery = "UPDATE HASTALAR SET HastaAdi=@HastaAdi,HastaSoyadi=@HastaSoyadi,HastaYasi=@HastaYasi WHERE HASTAID=@HASTAID ";
            SqlCommand cmd = new SqlCommand(updateQuery, con);
            cmd.Parameters.AddWithValue("@HastaAdi", _HastaAdi_textBox.Text);
            cmd.Parameters.AddWithValue("@HastaSoyadi", _HastaSoyadi_textBox.Text);
            cmd.Parameters.AddWithValue("@HastaYasi", _HastaYasi_textBox.Text);
            cmd.Parameters.AddWithValue("@HASTAID", _Hastalar_numericUpDown.Value);

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
    }
}
