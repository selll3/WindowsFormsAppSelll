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
    public partial class Personeller : Form
    {
        public Personeller()
        {
            InitializeComponent();
        }






        private void _PersonelilListele_button_Click(object sender, EventArgs e)
        {
            verileriyükle();

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
            string readQuery = "Select PersonelAdi,PersonelSoyadi,PersonelGorev from PERSONEL";
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
            
                using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-99R82DT;Initial Catalog=_HASTANE;Integrated Security=True;Encrypt=False"))
                {
                    con.Open(); // Bağlantıyı aç

                    for (int item = 0; item < _Personeller_dataGridView.Rows.Count; item++)
                {
                    // Satırdaki PERSONELID'nin null olup olmadığını kontrol et
                    //var personelId = _Personeller_dataGridView.Rows[item].Cells["PERSONELID"].Value;
                    //if (personelId == null || personelId == DBNull.Value)
                    //{
                    //    MessageBox.Show("PERSONELID değeri eksik veya null.");
                    //    continue; // Eğer ID yoksa, bu satırı atla
                    //}

                    SqlCommand cmd2 = new SqlCommand("UPDATE PERSONEL SET PersonelAdi=@PersonelAdi, PersonelSoyadi=@PersonelSoyadi, PersonelGorev=@PersonelGorev WHERE PERSONELID=@PERSONELID", con);

                        // Parametreleri ekle
                        cmd2.Parameters.AddWithValue("@PersonelAdi", _Personeller_dataGridView.Rows[item].Cells["PersonelAdi"].Value ?? (object)DBNull.Value);
                        cmd2.Parameters.AddWithValue("@PersonelSoyadi", _Personeller_dataGridView.Rows[item].Cells["PersonelSoyadi"].Value ?? (object)DBNull.Value);
                        cmd2.Parameters.AddWithValue("@PersonelGorev", _Personeller_dataGridView.Rows[item].Cells["PersonelGorev"].Value ?? (object)DBNull.Value);

                    //cmd2.Parameters.AddWithValue("@PERSONELID", personelId);


                    // Sorguyu çalıştır
                    cmd2.ExecuteNonQuery();
                    }

                    con.Close(); // Bağlantıyı kapat
                }

                MessageBox.Show("Satır güncellemesi başarılı");
            


        }


    }

            








    
    
}
