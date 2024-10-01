using Database.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Model
{
    public static class Kullanicilar
    {

        public static bool KullaniciEkle(GIRIS kullanici)
        {
            try
            {
                Hastanedb db = new Hastanedb();
                db.GIRIS.Add(kullanici);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;

            }

        }
        public static bool KullaniciGuncelle(GIRIS kullanici)
        {
            try
            {
                Hastanedb db = new Hastanedb();
                db.GIRIS.AddOrUpdate(kullanici);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;

            }

        }
        public static bool KullaniciSil(GIRIS kullanici)
        {
            try
            {
                Hastanedb db = new Hastanedb();
                db.GIRIS.Remove(kullanici);
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
