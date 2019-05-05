using Nakliye.DAL;
using Nakliye.ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nakliye.BLL
{
   public class NakliyeciBLL
    {
        //RepositoryPattern<Photo> repo1 = new RepositoryPattern<Photo>();
        RepositoryPattern<Nakliyeciler> repo = new RepositoryPattern<Nakliyeciler>();
        DataContext db = new DataContext();
        Nakliyeciler nakliyeciler = new Nakliyeciler();
        //Photo photo = new Photo();


        public List<Nakliyeciler> GetNakliyecilers()
        {
            return repo.List();
        }

        //public void NakliyeciEkle(int id, string nakliyecisirketadi, string nakliyeciTel, string nakliyecisehir, string nakliyecisemt)
        //{
        //	//nakliyeciler.NakliyeciID = id;
        //	//nakliyeciler.NakliyeSirketininAdı = nakliyecisirketadi;
        //	//nakliyeciler.NakliyeciTelefon1 = nakliyeciTel;
        //	//nakliyeciler.NakliyeciSehir = nakliyecisehir;
        //	//nakliyeciler.NakliyeciSemt = nakliyecisemt;
        //	////photo.Photo1= fotograf;
        //	//repo.Add(nakliyeciler);
        //	////repo1.Add(photo);
        //	//db.SaveChanges();

        //}

    }
}
