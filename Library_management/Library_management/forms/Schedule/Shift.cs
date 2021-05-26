using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_management.forms.Schedule
{
    class Shift
    {
        public List<staff> nv;
        public int ca;
        public int thu;


        public Shift(List<staff> nv, int ca, int thu)
        {
            this.nv = nv;
            this.ca = ca;
            this.thu = thu;
        }
        public Shift() { }
    }
}
