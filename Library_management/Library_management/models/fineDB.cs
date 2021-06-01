using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_management.models
{
    class fineDB
    {
        static LibraryEntities db = new LibraryEntities();
        public static List<fineMoney> getList()
        {
            var rs = from b in db.fineMoneys
                     select b;

            return rs.ToList();
        }
        public static fineMoney getById(int id)
        {
            var rs = from cat in db.fineMoneys
                     where cat.id == id
                     select cat;

            return rs.SingleOrDefault();
        }
        public static bool insert(int uid, float fine)
        {
            try
            {
                var rs = db.fineMoneys.Add(new fineMoney()
                {
                   id = uid,
                   fine = fine
                });
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        //public static bool delete(int id)
        //{
        //    try
        //    {
        //        book cat = db.books.Where(p => p.id == id).SingleOrDefault();
        //        db.books.Remove(cat);
        //        db.SaveChanges();
        //        return true;
        //    }
        //    catch
        //    {
        //        return false;
        //    }
        //}
        public static bool update(int id, float fine)
        {
            try
            {
                fineMoney r = db.fineMoneys.Find(id);
                r.fine = fine;
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }

        }
        public static double? Total()
        {
            return db.fineMoneys.Sum(f => f.fine);
        }
    }
}
