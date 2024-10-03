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
        public static Hastanedb dbh = new Hastanedb();
        public static List<dynamic> HastalariGetir()
        {
           
            
                var hastalar = dbh.HASTALAR
                    .Select(h => new
                    {
                        h.HASTAID,               // Hasta ID
                        h.HastaAdi,              // Hasta Adı
                        h.HastaSoyadi,           // Hasta Soyadı
                        h.HastaYasi          // Doğum Tarihi (Eğer varsa)
                    })
                    .ToList<dynamic>();          // Dinamik olarak listeye dönüştür

                return hastalar;
            
        }


        public static bool HastaEkle(HASTALAR Hasta)
        {
            try
            {
                
                dbh.HASTALAR.Add(Hasta);
                dbh.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;

            }

        }
        public static bool HastaGuncelle(HASTALAR Hasta)
        {
            try
            {
                
                dbh.HASTALAR.AddOrUpdate(Hasta);
                dbh.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;

            }
        }

        public static bool HastalariSil(int selectedHastaId)
        {
            try
            {
                
                var Hasta = dbh.HASTALAR.Where(x => x.HASTAID == selectedHastaId).FirstOrDefault();
                dbh.HASTALAR.Remove(Hasta);
                dbh.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;

            }
        }
    }
}
