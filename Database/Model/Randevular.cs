using Database.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Model
{
    public static class Randevular
    {
        public static bool RandevuEkle(RANDEVULAR randevular)
        {
            try
            {
                Hastanedb db = new Hastanedb();
                db.RANDEVULAR.Add(randevular);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;

            }

        }

        public static bool RandevuGuncelle(RANDEVULAR randevular)
        {
            try
            {
                Hastanedb db = new Hastanedb();
                db.RANDEVULAR.AddOrUpdate(randevular);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;

            }

        }
        public static bool RandevuSil(RANDEVULAR randevular)
        {
            try
            {
                Hastanedb db = new Hastanedb();
                db.RANDEVULAR.Remove(randevular);
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
