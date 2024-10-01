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
