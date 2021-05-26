using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_management.models
{
    class borrowDB
    {
        static LibraryEntities db = new LibraryEntities();

        public static List<borrow> getList()
        {
            var rs = from b in db.borrows
                     select b;

            return rs.ToList();
        }
        public static List<borrow> getListByUid(int uid)
        {
            var rs = from b in db.borrows
                     where b.uid == uid
                     select b;

            return rs.ToList();
        }
        public static borrow getById(int id)
        {
            var rs = from cat in db.borrows
                     where cat.id == id
                     select cat;

            return rs.SingleOrDefault();
        }
        public static bool insert(int uid , int bid, DateTime start, DateTime exp)
        {
            try
            {

                db.borrows.Add(new borrow()
                {
                    uid = uid,
                    bid = bid,
                    borrowDate = start,
                    expired = exp
                });
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public static bool delete(int uid, int bid)
        {
            try
            {
                borrow cat = db.borrows.Where(p => p.bid == bid && p.uid == uid).SingleOrDefault();
                db.borrows.Remove(cat);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static bool update(int id, int uid, int bid, DateTime start, DateTime exp)
        {
            try
            {
                borrow b = db.borrows.Find(id);
                b.uid = uid;
                b.bid = bid;
                b.borrowDate = start;
                b.expired = exp;
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }

        }
        public static borrow getDate(int uid, int bid)
        {
            var rs = from br in db.borrows
                     where br.uid == uid && br.bid == bid
                     select br;

            return rs.SingleOrDefault();
        }
    }
}
