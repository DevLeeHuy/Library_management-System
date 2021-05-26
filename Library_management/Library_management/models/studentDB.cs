using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Library_management.models
{
    class studentDB
    {
        static LibraryEntities db = new LibraryEntities();
        public static List<user> getListStd()
        {
            var rs = from std in db.users
                     where std.type == userDB.stdType
                     select std;

            return rs.ToList();
        }
        public static user getStudentById(int id)
        {
            var rs = from std in db.users
                     where std.id == id && std.type == userDB.stdType
                     select std;

            return rs.SingleOrDefault();
        }
    }
}
