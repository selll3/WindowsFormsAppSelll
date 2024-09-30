using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database.Entity;
using System.Data.Entity.Migrations;

namespace Database.Model
{
    public static class Doktorlar
    {
       private static Hastanedb db = new Hastanedb();
        /// <summary>
        /// Database'den tüm doktorları çağırır
        /// </summary>
        /// <returns></returns>
        /// 
        public static List<DOKTORLAR> DoktorlariGetir()
        {
            

            //SqlConnection con = new SqlConnection("Data Source=DESKTOP-99R82DT;Initial Catalog=_HASTANE;Integrated Security=True;Encrypt=False");
            //string readQuery = "SELECT  DoktorAdi,DoktorSoyadi,DoktorunBransi,Doktorun_kati FROM DOKTORLAR";
            //SqlDataAdapter da = new SqlDataAdapter(readQuery, con);

            //DataTable dt = new DataTable();


            //da = new SqlDataAdapter(readQuery, con);
            //da.Fill(dt);

            return db.DOKTORLAR.ToList();
        }

        public static bool DoktorEkle(DOKTORLAR doktor)
        {
            try
            {
                Hastanedb db = new Hastanedb();
                db.DOKTORLAR.Add(doktor);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;

            }

        }
        ////public static 
        ////{
        ////    try
        ////    {
        ////        Hastanedb db = new Hastanedb();
        ////        db.DOKTORLAR.AddOrUpdate(doktor);
        ////        db.SaveChanges();
        ////        return true;
        ////    }
        ////    catch
        ////    {
        ////        return false;

        ////    }
        //}
    }
}
