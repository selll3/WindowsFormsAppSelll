using Database.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Model
{
    public static class Yetkiler
    {
        public static Hastanedb dby = new Hastanedb();
        public static bool YetkiEkle(PERSONELFORMYETKILERI PFY)
        {
            try
            {
               
                dby.PERSONELFORMYETKILERI.Add(PFY);
                dby.SaveChanges();
                return true;
            }
            catch
            {
                return false;

            }

        }

    }
}
