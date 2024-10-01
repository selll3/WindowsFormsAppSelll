﻿using Database.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Model
{
    public static class Personeller
    { private static Hastanedb dp = new Hastanedb();
        public static bool PersonelEkle(PERSONEL Personel)
        {
            try
            {
                
                dp.PERSONEL.Add(Personel);
                dp.SaveChanges();
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
                
                dp.PERSONEL.AddOrUpdate(Personel);
                dp.SaveChanges();
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
             
                dp.PERSONEL.Remove(Personel);
                dp.SaveChanges();
                return true;
            }
            catch
            {
                return false;

            }

        }
    }
}
