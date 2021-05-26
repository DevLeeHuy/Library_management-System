using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_management.models
{
    class staffDB
    {
        static LibraryEntities db = new LibraryEntities();
        public static List<user> getList()
        {
            var rs = from std in db.users
                     where std.type == userDB.staffType
                     select std;

            return rs.ToList();
        }

        public static user getById(int id)
        {
            var rs = from std in db.users
                     where std.id == id && std.type == userDB.staffType
                     select std;

            return rs.SingleOrDefault();
        }

        public static List<staff> getListInStaff()
        {
            var rs = from s in db.staffs
                     select s;
            return rs.ToList();
        }
        public static List<staff> getListStaffByRole(int role)
        {
            var rs = from s in db.staffs
                     where s.role == role
                     select s;
            return rs.ToList();
        }

        public static List<staff> getRandom(List<staff> staff, int n, int role)
        {
            Random rnd = new Random();
            var rs = from s in staff
                     where s.role == role
                     select s;
            List<staff> roles = rs.ToList();
            List<staff> result = new List<staff>();
            for (int i = 0; i < n; i++)
            {
                staff temp = roles[rnd.Next(0, roles.Count)];
                if (!result.Contains(temp))
                {
                    result.Add(temp);
                }
                else
                {
                    i--;
                }
                roles.Remove(temp);
                if (roles.Count == 0) break;
            }
            return result;
        }
        public static int countStaff(List<staff> staffs,int role)
        {
            return staffs.Count(s => s.role == role);
        }
    }
}
