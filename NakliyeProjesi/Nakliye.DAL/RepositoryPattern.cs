using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace Nakliye.DAL
{
   public class RepositoryPattern<T> where T:class
    {
        DataContext db = new DataContext();
        public List<T> List()
        {
            return db.Set<T>().ToList();
        }
      
    }
}
