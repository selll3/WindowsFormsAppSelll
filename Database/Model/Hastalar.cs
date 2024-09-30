using Database.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Model
{
    public static class Hastalar
    {
        public static List<HASTALAR>HastalariGetir()
        {
            Hastanedb db = new Hastanedb();

            //SqlConnection con = new SqlConnection("Data Source=DESKTOP-99R82DT;Initial Catalog=_HASTANE;Integrated Security=True;Encrypt=False");
            //string readQuery = "SELECT  DoktorAdi,DoktorSoyadi,DoktorunBransi,Doktorun_kati FROM DOKTORLAR";
            //SqlDataAdapter da = new SqlDataAdapter(readQuery, con);

            //DataTable dt = new DataTable();


            //da = new SqlDataAdapter(readQuery, con);
            //da.Fill(dt);

            return db.HASTALAR.ToList();
        }

        public static bool HastaEkle(HASTALAR Hasta)
        {
            try
            {
                Hastanedb db = new Hastanedb();
                db.HASTALAR.Add(Hasta);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;

            }

        }
        public static bool HastaGuncelle(HASTALAR Hasta)
        {
            try
            {
                Hastanedb db = new Hastanedb();
                db.HASTALAR.AddOrUpdate(Hasta);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;

            }
        }

        public static bool HastalariSil(HASTALAR Hasta)
        {
            try
            {
                Hastanedb db = new Hastanedb();
                db.HASTALAR.Remove(Hasta);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;

            }
        }
    }
}
