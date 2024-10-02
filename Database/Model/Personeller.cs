using Database.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Model
{
    public static class Personeller
    { public static Hastanedb dp = new Hastanedb();
        public static string PersoneliGetir(int selectedPersonelId)
        {
            
              // DbContext sınıfınızı kullanıyoruz
                
                    // Sadece personelin görevini almak için LINQ sorgusuyla doğrudan sorguluyoruz
                    var gorev = dp.PERSONEL
                                      .Where(p => p.PERSONELID == selectedPersonelId)
                                      .Select(p => p.PersonelGorev)
                                      .FirstOrDefault();

                    return gorev; // Görevi döndürüyoruz, personel bulunmazsa null döner
                
            

        }
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
               
                    dp.Entry(Personel).State = EntityState.Modified; // Güncelleme durumunu belirt
                    dp.SaveChanges(); // Değişiklikleri kaydet
                    return true; // Güncelleme başarılı
                
            }
            //try
            //{

            //    dp.PERSONEL.AddOrUpdate(Personel);
            //    dp.SaveChanges();
            //    return true;
            //}
            catch
            {
                return false;

            }

        }
        public static bool PersonelSil(int selectedPersonelId)
        {
            try
            {

                var personel = dp.PERSONEL.Where(x => x.PERSONELID == selectedPersonelId).FirstOrDefault();
                dp.PERSONEL.Remove(personel);
                dp.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
             
                return false; // Hata durum

            }
        }
    }
}
