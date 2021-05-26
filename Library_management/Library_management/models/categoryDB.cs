using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_management.models
{
    class categoryDB
    {
        static LibraryEntities db = new LibraryEntities();
        public static List<bookCategory> getList()
        {
            try
            {
                var rs = from cat in db.bookCategories
                         select cat;

                return rs.ToList();
            }
            catch
            {
                return null;
            }
        }
        public static bookCategory getCatById(int id)
        {
            var rs = from cat in db.bookCategories
                     where cat.id == id 
                     select cat;

            return rs.SingleOrDefault();
        }
        public static bool insert(string name)
        {
            try
            {

                db.bookCategories.Add(new bookCategory()
                {
                    catName = name
                });
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public static bool delete(int id)
        {
            try
            {
                bookCategory cat = db.bookCategories.Where(p => p.id == id).SingleOrDefault();
                db.bookCategories.Remove(cat);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static bool update(int id,string name)
        {
            try
            {
                bookCategory cat = db.bookCategories.Find(id);
                cat.catName = name;
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
