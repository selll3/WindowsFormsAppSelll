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
    public partial class HastaEkle : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-99R82DT;Initial Catalog=_HASTANE;Integrated Security=True;Encrypt=False");
        SqlDataAdapter daHE;
        DataTable dtHE;
        public HastaEkle()
        {
            InitializeComponent();
            //LoadDataHE();
        }
        private void LoadDataHE()
        {
            //    dtHE = new DataTable();
            //    string readQuery = "SELECT HASTAID, HastaAdi,HastaSoyadi, HastaYasi from HASTALAR WHERE HASTAID = 0";
            //    daHE = new SqlDataAdapter(readQuery, con);
            //    daHE.Fill(dtHE);
            //    _hastaekle_dataGridView.DataSource = dtHE;

            //    // DOKTORID sütununu gizle
            //    if (_hastaekle_dataGridView.Columns.Contains("HASTAID"))
            //    {
            //        _hastaekle_dataGridView.Columns["HASTAID"].Visible = false;
            //    }
        }
        private void HastaEkle_Load(object sender, EventArgs e)
        {

        }

        private void _kaydet_button_Click(object sender, EventArgs e)
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
                cmd.Parameters.AddWithValue("@Hastayasi", numericUpDown1.Value);
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


            //con.Open();
            //foreach (DataGridViewRow row in _hastaekle_dataGridView.Rows)
            //{
            //    //dataGridView1.Columns["DOKTORID"].Visible = false;
            //    if (!row.IsNewRow) // Yeni satır değilse
            //    {
            //        SqlCommand cmd = new SqlCommand("INSERT INTO HASTALAR ( HastaAdi,HastaSoyadi, HastaYasi) VALUES (@Hadi, @Hsoyadi, @HYasi)", con);
            //        cmd.Parameters.AddWithValue("@Hadi", row.Cells["HastaAdi"].Value ?? (object)DBNull.Value);
            //        cmd.Parameters.AddWithValue("@Hsoyadi", row.Cells["HastaSoyadi"].Value ?? (object)DBNull.Value);
            //        cmd.Parameters.AddWithValue("@HYasi", row.Cells["HastaYasi"].Value ?? (object)DBNull.Value);


            //        cmd.ExecuteNonQuery();
            //    }
            //}
            //con.Close();

            // İlk formu güncelle ve göster
            Hastalar formh = Application.OpenForms.OfType<Hastalar>().FirstOrDefault();
            if (formh != null)
            {
                formh.LoadDataIntoGridh(); // İlk formun veri yükleme metodunu çağır
            }

            this.Close();
        }

        private void _vazgec_button_Click(object sender, EventArgs e)
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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
