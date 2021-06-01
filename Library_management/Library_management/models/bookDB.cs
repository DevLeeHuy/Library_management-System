using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_management.models
{
    class bookDB
    {
        static LibraryEntities db = new LibraryEntities();
        public static List<book> getListBookBorrowByUid(int uid)
        {
            var rs = from b in db.books
                     join br in db.borrows
                     on b.id equals br.bid
                     where br.uid == uid
                     select b;
           
            return rs.ToList();
        }
        public static List<book> getListInStock()
        {
            var rs = from b in db.books
                     where b.quantity > 0
                     select b;

            return rs.ToList();
        }
        public static List<book> getList()
        {
            var rs = from b in db.books
                     select b;

            return rs.ToList();
        }
        public static List<book> getByCat(int id)
        {
            var rs = from b in db.books
                     where b.categoryId == id
                     select b;

            return rs.ToList();
        }
        public static book getById(int id)
        {
            var rs = from cat in db.books
                     where cat.id == id
                     select cat;

            return rs.SingleOrDefault();
        }
        public static bool insert(string title, string des, string author, DateTime pub, string publisher, int catId, int quantity, MemoryStream img,int price)
        {
            try
            {
                var rs = db.books.Add(new book()
                {
                    title = title,
                    description = des,
                    author = author,
                    pubDate = pub,
                    publisher = publisher,
                    categoryId = catId, 
                    quantity = quantity,
                    price = price,
                    img = img.ToArray()
                }) ;
                Debug.WriteLine(rs.id);
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
                book cat = db.books.Where(p => p.id == id).SingleOrDefault();
                db.books.Remove(cat);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static bool update(int id, string title, string des, string author, DateTime pub, string publisher, int catId, int quantity,MemoryStream img,int price)
        {
            try
            {
                book b = db.books.Find(id);
                b.title = title;
                b.description = des;
                b.author = author;
                b.pubDate = pub;
                b.publisher = publisher;
                b.categoryId = catId;
                b.quantity = quantity;
                b.price = price;
                b.img = img.ToArray();
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }

        }
        public static bool exist(int id)
        {
            return db.books.Find(id) != null ? true:false;
        }

        public static bool updateQuantity(int id,int quantity)
        {
            try
            {
                book b = db.books.Find(id);
                b.quantity = b.quantity + quantity;
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static void addTeacherBook(int tid , int bid, int quantity)
        {
            try
            {
                db.bookOfTeachers.Add(new bookOfTeacher()
                {
                   tid = tid,
                   bid = bid,
                   quantity = quantity
                });
                db.SaveChanges();
            }
            catch (Exception ex)
            { }
        }
        public static List<book> getListBookOfTeacher()
        {
            var rs = from b in db.books
                     join bot in db.bookOfTeachers
                     on b.id equals bot.bid
                     select b;
            return rs.ToList();
        }
        public static List<book> getListBookOfTeacherById(int tid)
        {
            var rs = from b in db.books
                     join bot in db.bookOfTeachers
                     on b.id equals bot.bid
                     where bot.tid == tid
                     select b;
            return rs.ToList();
        }
        public static int getIdByTitle(string title)
        {
            book b = db.books.Where(p => p.title == title).SingleOrDefault();
            return b.id;
        }

        public static List<int?> getTop3()
        {
            var rs = from b in db.top3Book()
                     orderby b.quantity descending
                     select b.bid;
            return rs.Take(3).ToList();
        }
    }
}
