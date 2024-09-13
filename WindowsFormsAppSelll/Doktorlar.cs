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

namespace WindowsFormsAppSelll
{
    public partial class Doktorlar : Form
    {
        public Doktorlar()
        {
            InitializeComponent();
        }

        private void Doktorlar_Load(object sender, EventArgs e)
        {

        }

        private void _DoktorListele_button_Click(object sender, EventArgs e)
        {

            verileriyükle();

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

            
            
                //if (_Doktorlar_dataGridView.SelectedRows.Count > 0)
                //{
                //    int selectedRowId = Convert.ToInt32(_Doktorlar_dataGridView.SelectedRows[0].Cells["DOKTORID"].Value);
                //    string existingName = _Doktorlar_dataGridView.SelectedRows[0].Cells["DoktorAdi"].Value.ToString();
                //    string existingsurname = _Doktorlar_dataGridView.SelectedRows[0].Cells["DoktorSoyadi"].Value.ToString();
                //    string existingbrans = _Doktorlar_dataGridView.SelectedRows[0].Cells["DoktorunBransi"].Value.ToString();
                //    int existingkat = Convert.ToInt32(_Doktorlar_dataGridView.SelectedRows[0].Cells["Doktorun_kati"].Value);
               
                
                //Doktorlar updateForm = new Doktorlar();
                
                

                //if (updateForm.ShowDialog() == DialogResult.OK)
                //    {
                //    verileriyükle(); // Güncelleme işleminden sonra verileri yeniden yükle
                //    }
                //}
                //else
                //{
                //    MessageBox.Show("Lütfen güncellenecek satırı seçin.");
                //}
            


            //SqlConnection con = new SqlConnection("Data Source=DESKTOP-99R82DT;Initial Catalog=_HASTANE;Integrated Security=True;Encrypt=False");
            //con.Open();
            //string updateQuery = "UPDATE DOKTORLAR SET DoktorAdi=@DoktorAdi,DoktorSoyadi=@DoktorSoyadi,DoktorunBransi=@DoktorunBransi,Doktorun_kati=@Doktorunkati WHERE DOKTORID=@DOKTORID ";
            //SqlCommand cmd = new SqlCommand(updateQuery, con);
            //cmd.Parameters.AddWithValue("@DoktorAdi");
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
    }
}
