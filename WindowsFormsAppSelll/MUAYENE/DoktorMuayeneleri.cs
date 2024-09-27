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
using WindowsFormsAppSelll.KULLANICI;

namespace WindowsFormsAppSelll.MUAYENE
{
    public partial class DoktorMuayeneleri : Form
    {
        //private int doktorid;
        public DoktorMuayeneleri(/*int DoktorId*/)
        {
            InitializeComponent();
            DoktorMuayeneleriniListele();
            //doktorid = DoktorId;
        }

        public void DoktorMuayeneleriniListele()
        {
            //using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-99R82DT;Initial Catalog=_HASTANE;Integrated Security=True;Encrypt=False"))
            //{
            //    con.Open();

            //    İlk olarak KULLANICIID'ye karşılık gelen DOKTORID'yi bulalım
            //    string doktorQuery = "SELECT DOKTORID FROM DOKTORLAR WHERE KULLANICIID = @KULLANICIID";
            //    SqlCommand doktorCmd = new SqlCommand(doktorQuery, con);
            //    doktorCmd.Parameters.AddWithValue("@KULLANICIID", kullaniciID);

            //    object doktorIDObj = doktorCmd.ExecuteScalar(); // DoktorID'yi alalım

            //    if (doktorIDObj != null)
            //    {
            //        int doktorID = Convert.ToInt32(doktorIDObj); // DoktorID'yi int'e çeviriyoruz

            //        Doktor bulunduysa onun DOKTORID'sine göre muayeneleri filtreleyelim
            //        string muayeneQuery = "SELECT MUAYENEID, MuayeneTarihi, RANDEVUID, DOKTORID, HASTAID, Aciklama, islendiBilgisi " +
            //                              "FROM MUAYENE WHERE DOKTORID = @DOKTORID";
            //        SqlCommand muayeneCmd = new SqlCommand(muayeneQuery, con);
            //        muayeneCmd.Parameters.AddWithValue("@DOKTORID", doktorID);

            //        SqlDataAdapter da = new SqlDataAdapter(muayeneCmd);
            //        DataTable dt = new DataTable();
            //        da.Fill(dt);

            //        DataGridView'e sonucu bağlayalım
            //        _DoktorMuayeneleri_dataGridView.DataSource = dt;
            //    }
            //    else
            //    {
            //        Eğer doktor bulunamazsa bir uyarı gösterebilirsiniz
            //        MessageBox.Show("Bu kullanıcı bir doktor değil veya doktor kaydı bulunamadı.");
            //    }

            //    con.Close();
            //}

            // Giriş yapan kullanıcının KULLANICIID'sini alalım
            //GIRIS gIRIS = new GIRIS();
            //int kullaniciID = gIRIS.KULLANICIID; // Giriş yapılan KULLANICIID buradan geliyor

            //using (Hastanedb dbm = new Hastanedb())
            //{
            //    // İlk olarak KULLANICIID'ye karşılık gelen DOKTORID'yi bulalım
            //    var doktor = dbm.DOKTORLAR.FirstOrDefault(d => d.KULLANICIID == kullaniciID);

            //    if (doktor != null)
            //    {
            //        // Doktor bulunduysa onun DOKTORID'sine göre muayeneleri filtreleyelim
            //        int doktorID = doktor.DOKTORID;

            //        // Muayeneleri filtreleyip DataGridView'e aktaralım
            //        _DoktorMuayeneleri_dataGridView.DataSource = dbm.MUAYENE
            //            .Where(m => m.DOKTORID == doktorID) // Filtreleme işlemi
            //            .Select(r => new
            //            {
            //                r.MUAYENEID,
            //                r.MuayeneTarihi,
            //                r.RANDEVUID,
            //                r.DOKTORID,
            //                r.HASTAID,
            //                r.Aciklama,
            //                r.islendiBilgisi
            //            }).ToList();
            //    }
            //    else
            //    {
            //        // Eğer doktor bulunamazsa bir uyarı gösterebilirsiniz
            //        MessageBox.Show("Bu kullanıcı bir doktor değil veya doktor kaydı bulunamadı.");
            //    }
            //}
            //GIRIS gIRIS = new GIRIS();


            //Hastanedb dbm = new Hastanedb();
            //_DoktorMuayeneleri_dataGridView.DataSource = dbm.MUAYENE
            //    .Select(r => new
            //    {   /*if (r.DOKTORID) { }
            //        r.MUAYENEID,  // İstediğin sütunları buraya ekleyebilirsin
            //        r.MuayeneTarihi,
            //        r.RANDEVUID,
            //        r.DOKTORID,
            //        r.HASTAID,
            //        r.Aciklama,
            //        r.islendiBilgisi
            //         r.Bulgu gibi başka sütunlar da ekleyebilirsin
            //    }).ToList();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DoktorMuayeneleri_Load(object sender, EventArgs e)
        {

        }
    }
}
