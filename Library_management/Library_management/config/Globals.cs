using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_management.config
{
    public static class Globals
    {
        static Globals() { }

        public static int user { get; private set; }
        public static LibraryEntities db = new LibraryEntities();

        public static void setUser(int user)
        {
            Globals.user = user;
        }
    }
}
