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
    public partial class doktorekle : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-99R82DT;Initial Catalog=_HASTANE;Integrated Security=True;Encrypt=False");
        SqlDataAdapter da;
        DataTable dt;


        public doktorekle()
        {
            InitializeComponent();
            //LoadData();
        }
        private void LoadData()
        {
            //dt = new DataTable();
            //string readQuery = "SELECT DoktorAdi, DoktorSoyadi, DoktorunBransi, Doktorun_kati FROM DOKTORLAR WHERE DOKTORID = 0";
            //da = new SqlDataAdapter(readQuery, con);
            //da.Fill(dt);
            //dataGridView1.DataSource = dt;

            //// DOKTORID sütununu gizle
            //if (dataGridView1.Columns.Contains("DOKTORID"))
            //{
            //    dataGridView1.Columns["DOKTORID"].Visible = false;
            //}
        }
        private void doktorekle_Load(object sender, EventArgs e)
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
                //    // DOKTORLAR dr = new DOKTORLAR();
                //    //  dr.DoktorAdi = _DoktorAdi_textBox.Text;
                //    // dr.DoktorSoyadi = _DoktorSoyadi_textBox.Text;
                //    // dr.DoktorSoyadi = _DoktorBranşi_textBox.Text;
                //    // dr.DoktorSoyadi = _DoktorunKati_textBox.Text;


                //    //  Hastanedb db = new Hastanedb();

                //    // db.DOKTORLAR.Add(dr);
                //    // db.SaveChanges();


                SqlConnection con = new SqlConnection("Data Source=DESKTOP-99R82DT;Initial Catalog=_HASTANE;Integrated Security=True;Encrypt=False");
                string insertQuery = "INSERT INTO DOKTORLAR(DoktorAdi,DoktorSoyadi,DoktorunBransi,Doktorun_kati) VALUES(@DoktorAdi, @DoktorSoyadi, @Doktorbransi, @Doktorunkati) ";
                con.Open();
                SqlCommand cmd = new SqlCommand(insertQuery, con);
                cmd.Parameters.AddWithValue("@DoktorAdi", _DoktorAdi_textBox.Text);
                cmd.Parameters.AddWithValue("@DoktorSoyadi", _DoktorSoyadi_textBox.Text);
                cmd.Parameters.AddWithValue("@DoktorBransi", _DoktorBransi_textBox.Text);
                cmd.Parameters.AddWithValue("@Doktorunkati", numericUpDown1.Value);
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
            //foreach (DataGridViewRow row in dataGridView1.Rows)
            //{
            //    //dataGridView1.Columns["DOKTORID"].Visible = false;
            //    if (!row.IsNewRow) // Yeni satır değilse
            //    {
            //        SqlCommand cmd = new SqlCommand("INSERT INTO DOKTORLAR (DoktorAdi, DoktorSoyadi, DoktorunBransi, Doktorun_kati) VALUES (@adi, @soyadi, @brans, @kat)", con);
            //        cmd.Parameters.AddWithValue("@adi", row.Cells["DoktorAdi"].Value ?? (object)DBNull.Value);
            //        cmd.Parameters.AddWithValue("@soyadi", row.Cells["DoktorSoyadi"].Value ?? (object)DBNull.Value);
            //        cmd.Parameters.AddWithValue("@brans", row.Cells["DoktorunBransi"].Value ?? (object)DBNull.Value);
            //        cmd.Parameters.AddWithValue("@kat", row.Cells["Doktorun_kati"].Value ?? (object)DBNull.Value);

            //        cmd.ExecuteNonQuery();
            //    }
            //}
            //con.Close();

            // İlk formu güncelle ve göster
            Doktorlar form1 = Application.OpenForms.OfType<Doktorlar>().FirstOrDefault();
            if (form1 != null)
            {
                form1.LoadDataIntoGrid(); // İlk formun veri yükleme metodunu çağır
            }

            this.Close();
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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
    
}
