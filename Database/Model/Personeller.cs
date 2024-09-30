using Database.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Model
{
    public static class Personeller
    {
        public static bool PersonelEkle(PERSONEL Personel)
        {
            try
            {
                Hastanedb db = new Hastanedb();
                db.PERSONEL.Add(Personel);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;

            }

        }
        public static bool PersonelGuncelle(PERSONEL Personel)
        {
            try
            {
                Hastanedb db = new Hastanedb();
                db.PERSONEL.AddOrUpdate(Personel);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;

            }

        }
        public static bool PersonelSil(PERSONEL Personel)
        {
            try
            {
                Hastanedb db = new Hastanedb();
                db.PERSONEL.Remove(Personel);
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
