using Library_management.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_management.forms.Schedule
{
    public partial class viewSchedule : Form
    {
        LibraryEntities db = new LibraryEntities();
        public viewSchedule()
        {
            InitializeComponent();
            drawSchedule();
        }

        private void viewSchedule_Load(object sender, EventArgs e)
        {
            cbStaffId.DataSource = staffDB.getListInStaff();
            cbStaffId.DisplayMember = "id";
            cbStaffId.ValueMember = "id";
            xuat();
        }
        public Label[,] lbs = new Label[3, 8];
        void drawSchedule()
        {
            pnlSchedule.Controls.Clear();
            Label oldLabel = new Label() { Width = 0, Location = new Point(30, 0) };
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Label lb = new Label()
                    {

                        Width = 110,
                        Height = 110,
                        Location = new Point(oldLabel.Location.X + oldLabel.Width, oldLabel.Location.Y)
                    };
                    if ((j + i) % 2 == 0)
                        lb.BackColor = Color.LightBlue;
                    else
                        lb.BackColor = Color.LightGray;

                    oldLabel = lb;
                    lbs[i, j] = lb;
                    pnlSchedule.Controls.Add(lb);

                }
                oldLabel.Location = new Point(30, oldLabel.Location.Y + 110);
                oldLabel.Width = 0;
                oldLabel.Height = 0;
            }
        }
        List<shift> getListShift()
        {
            var rs = from s in db.shifts
                     select s;
            return rs.ToList();
        }
        public void xuat()
        {
            pnlSchedule.Controls.Clear();
            drawSchedule();
            List<shift> listShift = this.getListShift();
            foreach(shift s in listShift)
            {
                int i = 0;
                int j = 0;
                GetXY(s, ref i, ref j);
                print(j,i, s);
            }
        }
        public void print(int i, int j,shift s)
        {
            lbs[i, j].Text = lbs[i, j].Text +" "+ s.sid+ "," ;
        }
        public void GetXY(shift s, ref int x, ref int y)
        {
            for (int i = 0; i < 3; i++)
            {
                if (s.ca == i+1)
                {
                    y = i;
                }
            }
            for (int j = 0; j <8; j++)
            {
                if (s.thu == j+2)
                    x = j;
            }
        }

        private void cbStaffId_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                pnlSchedule.Controls.Clear();
                drawSchedule();
                List<shift> listShift = this.getListShift();
                foreach (shift s in listShift)
                {
                    int id = Convert.ToInt32(cbStaffId.SelectedValue);
                    if (s.sid == id)
                    {
                        int i = 0;
                        int j = 0;
                        GetXY(s, ref j, ref i);
                        lbs[i, j].Text = "✖️";
                        lbs[i, j].Font = new Font("tahoma", 24, FontStyle.Bold);
                        lbs[i, j].TextAlign = ContentAlignment.MiddleCenter;
                    }
                }
            }
            catch { }
        }
    }
}
