using Database.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Model
{

    public static class Muayeneler
    {
        public static Hastanedb dbm = new Hastanedb();
        public static bool MuayeneEkle(MUAYENE muayene)
        {
            try
            {
               
                dbm.MUAYENE.Add(muayene);
                dbm.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;

            }

        }
        public static List<MUAYENE> GetMuayenelerByDoktorID(int doktorID)
        {
            return dbm.MUAYENE
                .Where(m => m.DOKTORID == doktorID && m.MuayeneTarihi >= DateTime.Now)
                .ToList();
        }





    }




}
