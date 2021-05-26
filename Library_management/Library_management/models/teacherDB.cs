using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_management.models
{
    class teacherDB
    {
        static LibraryEntities db = new LibraryEntities();
        public static List<user> getListTeacher()
        {
            var rs = from std in db.users
                     where std.type == userDB.teacherType
                     select std;

            return rs.ToList();
        }
        public static user getTeacherById(int id)
        {
            var rs = from std in db.users
                     where std.id == id && std.type == userDB.teacherType
            select std;

            return rs.SingleOrDefault();
        }
    }
}
