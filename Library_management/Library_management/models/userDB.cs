using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_management.models
{
    class userDB
    {
        static LibraryEntities db = new LibraryEntities();
        public static int staffType = 4;
        public static int stdType = 3;
        public static int teacherType = 2;
        public static user getById(int id)
        {
            try
            {
                user u = db.users.Where(p => p.id == id).SingleOrDefault();
                return u;
            }
            catch
            {
                return null;
            }
        }
        public static bool insertUser(int type, int id, string fname, string lname, DateTime Birth, string gender, string phone,  string address, MemoryStream img)
        {
            try
            {

                db.users.Add(new user()
                {
                    id = id,
                    type = type,
                    lname = lname,
                    fname = fname,
                    BirthDate = Birth,
                    gender = gender,
                    phone = phone,
                    address = address,
                    img = img.ToArray(),
                });
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public static bool deleteUser(int id)
        {
            try
            {
            user std = db.users.Where(p => p.id == id).SingleOrDefault();
            db.users.Remove(std);
            db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static bool updateUser(int id, string fname, string lname, DateTime Birth, string gender, string phone, string address, MemoryStream img)
        {
            try {
                user std = db.users.Find(id);
                std.fname = fname;
                std.lname = lname;
                std.BirthDate = Birth;
                std.gender = gender;
                std.phone = phone;
                std.address = address;
                std.img = img.ToArray();
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
           
        }
        public static account checkAccount(string uname, string pass)
        {
            try {
                account acc = db.accounts.Where(p => p.username == uname && p.password == pass).Single();
                return acc;
            }
            catch
            {
                return null;
            }
            
        }
        public static bool addAccount(int id, string uname,string pass)
        {
            try
            {

                db.accounts.Add(new account()
                {
                    id = id,
                    username = uname,
                    password = pass
                });
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static int getGender(int type, string gender)
        {
            return db.users.Count(u => u.type == type && u.gender == gender);
        }
        public static int getTotal(int type)
        {
            return db.users.Count(u => u.type == type);
        }

    }
}

