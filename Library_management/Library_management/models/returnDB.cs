using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_management.models
{
    class returnDB
    {
        static LibraryEntities db = new LibraryEntities();
        public static List<returnBook> getList()
        {
            var rs = from b in db.returnBooks
                     select b;

            return rs.ToList();
        }
        public static List<returnBook> getListByUid(int uid)
        {
            var rs = from b in db.returnBooks
                     where b.uid == uid
                     select b;

            return rs.ToList();
        }
        //public static book getById(int id)
        //{
        //    var rs = from cat in db.books
        //             where cat.id == id
        //             select cat;

        //    return rs.SingleOrDefault();
        //}
        public static bool insert(int uid, int bid, bool isExpired,bool isLost)
        {
            try
            {
                var rs = db.returnBooks.Add(new returnBook()
                {
                    uid = uid,
                    bid = bid,
                    isExpired = isExpired,
                    isDamaged = false,
                    isLost = isLost,
                    pending = false,
                }) ;
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
        public static bool updateStatus(int id, bool isDamged,bool isLost)
        {
            try
            {
                returnBook r = db.returnBooks.Find(id);
                r.isDamaged = isDamged;
                r.isLost = isLost;
                r.pending = true;
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }

        }
    }
}
