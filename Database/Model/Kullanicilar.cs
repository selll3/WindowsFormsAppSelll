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
    {  public static Hastanedb dbk = new Hastanedb();
        public static List<dynamic> KullanicilariGetir()
        {


            var kullanicilarigetir = dbk.GIRIS
                .Select(k => new
                {  k.KULLANICIID,
                   k.KullaniciAdi,
                   k.Parola
                })
                .ToList<dynamic>();          // Dinamik olarak listeye dönüştür

            return kullanicilarigetir;

        }
        public static bool KullaniciEkle(GIRIS kullanici)
        {
            try
            {
               
                dbk.GIRIS.Add(kullanici);
                dbk.SaveChanges();
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
               
                dbk.GIRIS.AddOrUpdate(kullanici);
                dbk.SaveChanges();
                return true;
            }
            catch
            {
                return false;

            }

        }
        public static bool KullaniciSil(int selectedKullaniciId)
        {
            try
            {
                // DbContext sınıfınızı burada belirtin
               
                    // İşlem için bir transaction başlatıyoruz
                    using (var transaction = dbk.Database.BeginTransaction())
                    {
                        // İlk olarak PERSONELFORMYETKILERI tablosundan ilgili kullanıcıyı sil
                        var userPermissions = dbk.PERSONELFORMYETKILERI
                            .Where(p => p.KULLANICIID == selectedKullaniciId);
                    dbk.PERSONELFORMYETKILERI.RemoveRange(userPermissions);
                    dbk.SaveChanges(); // Değişiklikleri kaydediyoruz

                        // Ardından GIRIS tablosundan kullanıcıyı sil
                        var user = dbk.GIRIS.Find(selectedKullaniciId);
                        if (user != null)
                        {
                        dbk.GIRIS.Remove(user);
                        dbk.SaveChanges(); // Değişiklikleri kaydediyoruz
                        }

                        // İşlemi başarılı bir şekilde tamamladıysak commit ediyoruz
                        transaction.Commit();
                        return true; // Silme başarılı
                   }
                
            }
            catch (Exception ex)
            {
                return false;

            }

        }
    }

}
