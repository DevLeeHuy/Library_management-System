

using Library_management.models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using Label = System.Windows.Forms.Label;

namespace Library_management.forms.Schedule
{
    class Schedule
    {

        List<int> soNv;

        private List<staff> listStaff = staffDB.getListInStaff();
        private List<Shift> result = new List<Shift>();
        static List<String> Dates = new List<string>()
        {   "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday"
        };

        internal List<Shift> Result { get => result; set => result = value; }

        public Schedule(int soQuanLy, int soGiaoNhan, int soXepSach)
        {
            this.soNv = new List<int>() { soQuanLy, soGiaoNhan, soXepSach };
        }
        public void makeSchedule()
        {
            listStaff.AddRange(listStaff);
            for (int i = 1; i <= 7; i++)
            {
                for (int j = 1; j <= 3; j++)
                {
                    List<staff> temp = new List<staff>(); //Nhân viên của 1 ca
                    for (int k = 1; k <= 3; k++)
                    {
                        List<staff> role = staffDB.getRandom(listStaff, soNv[k - 1], k);
                        temp.AddRange(role);
                    }
                    Shift s = new Shift(temp, j, i+1);
                    result.Add(s);
                    xoaNvDaCoCa(ref listStaff, temp);

                    if (staffDB.countStaff(listStaff, 1) < soNv[0])
                    {
                        themMoiNv(listStaff, 1);
                    } 
                    if(staffDB.countStaff(listStaff, 2) < soNv[1])
                    {
                        themMoiNv(listStaff, 2);
                    }
                    if(staffDB.countStaff(listStaff, 3) < soNv[2])
                    {
                        themMoiNv(listStaff, 3);
                    }
                  
                    //if (staffDB.countStaff(listStaff, 1) ==0 || staffDB.countStaff(listStaff, 2) ==0|| staffDB.countStaff(listStaff, 3) ==0)
                    //{
                    //    listStaff = staffDB.getListInStaff();
                    //    listStaff.AddRange(listStaff);
                    //}
                }
            }
        }
        void themMoiNv(List<staff> staffs, int role)
        {
            List<staff> sup = staffDB.getListStaffByRole(role);
            //sup.AddRange(sup);
            staffs.AddRange(sup);
        }
        void xoaNvDaCoCa(ref List<staff> total,List<staff> shift)
        {
            for(int i = 0; i < shift.Count; i++)
            {
                total.Remove(shift[i]);
            }
        }
    }
}
