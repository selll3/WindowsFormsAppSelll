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
        public static Hastanedb dbr = new Hastanedb();
        public static bool RandevuEkle(RANDEVULAR randevular)
        {
            try
            {
               
                dbr.RANDEVULAR.Add(randevular);
                dbr.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;

            }

        }

        public static bool RandevuGuncelle(RANDEVULAR randevular)
        {
            try
            {
                
                dbr.RANDEVULAR.AddOrUpdate(randevular);
                dbr.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;

            }

        }
        public static bool RandevuSil(int selectedRandevuId)
        {
            try
            {

                var randevu = dbr.RANDEVULAR.Where(x => x.RANDEVUID == selectedRandevuId).FirstOrDefault();
                dbr.RANDEVULAR.Remove(randevu);
                dbr.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;

            }
        }
    }

}
