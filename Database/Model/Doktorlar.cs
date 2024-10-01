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
            


            return db.DOKTORLAR.ToList();
        }

        //public static bool DoktorEkle(DOKTORLAR doktor)
        //{
        //    try
        //    {
               
        //        db.DOKTORLAR.Add(doktor);
        //        db.SaveChanges();
        //        return true;
        //    }
        //    catch
        //    {
        //        return false;

        //    }

        //}
        public static bool DoktorGuncelle(DOKTORLAR doktor)
        {
            try
            {
              
                db.DOKTORLAR.AddOrUpdate(doktor);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;

            }

        }
        public static bool DoktorSil(DOKTORLAR doktor)
        {
            try
            {
               
                db.DOKTORLAR.Remove(doktor);
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
