using Nakliye.DAL;
using Nakliye.ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nakliye.BLL
{
   public class MusteriBLL
    {
        //RepositoryPattern<Musteriler> repo = new RepositoryPattern<Musteriler>();
        DataContext db = new DataContext();
        public void AddCustomers(Musteriler musteri)
        {
            Musteriler must = new Musteriler();
            must.MusteriAdi = musteri.MusteriAdi;
            must.MusteriSoyadi = musteri.MusteriSoyadi;
            must.TelNo = musteri.TelNo;
            must.EMail = musteri.EMail;
            must.KullaniciAdi = musteri.KullaniciAdi;
            must.Password = musteri.Password;
            must.AdresID =2;

            db.Musteriler.Add(must);
            db.SaveChanges();
        }
    }
}
