﻿using Database.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Model
{

    public static class Muayeneler
    {
        private static Hastanedb db = new Hastanedb();
        public static bool MuayeneEkle(MUAYENE muayene)
        {
            try
            {
                Hastanedb db = new Hastanedb();
                db.MUAYENE.Add(muayene);
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
