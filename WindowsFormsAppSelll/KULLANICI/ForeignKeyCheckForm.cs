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

namespace WindowsFormsAppSelll.KULLANICI
{
    public partial class ForeignKeyCheckForm : Form
    {
        public ForeignKeyCheckForm()
        {
            InitializeComponent();
        }

        private void ForeignKeyCheckForm_Load(object sender, EventArgs e)
        {

        }

        private void _CheckForeignKeyButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-99R82DT;Initial Catalog=_HASTANE;Integrated Security=True;Encrypt=False"))
            {
                try
                {
                    con.Open();
                    string query = @"
                    SELECT *
                    FROM INFORMATION_SCHEMA.REFERENTIAL_CONSTRAINTS 
                    WHERE CONSTRAINT_NAME = 'FK_YETKILER_FORMLAR'";

                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // Sonuçları DataGridView'e bağlayın
                    _resultDataGridView.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }
    }
}
