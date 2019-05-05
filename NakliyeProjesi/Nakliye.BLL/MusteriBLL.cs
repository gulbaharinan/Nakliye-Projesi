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
        //RepositoryPattern<Müsteriler> repo = new RepositoryPattern<Müsteriler>();
        DataContext db = new DataContext();
        public void AddCustomers(Müsteriler musteri)
        {
            Müsteriler must = new Müsteriler();
            must.MüsteriAdı = musteri.MüsteriAdı;
            must.MüsteriSoyadı = musteri.MüsteriSoyadı;
            must.TelNo = musteri.TelNo;
            must.EMail = musteri.EMail;
            must.Password = musteri.Password;

            db.Müsteriler.Add(must);
            db.SaveChanges();
        }
    }
}
