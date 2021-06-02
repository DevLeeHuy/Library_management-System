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
    public partial class frmSchedule : Form
    {
        LibraryEntities db = new LibraryEntities();
        public frmSchedule()
        {
            InitializeComponent();
        }

    
        void saveSchedule(List<Shift> sche)
        {
           
            List<shift> records = getListShift();
            foreach (var record in records)
            {
                db.shifts.Remove(record);
            }
            foreach (Shift shift in sche)
            {
                foreach(staff staff in shift.nv)
                {
    
                         db.shifts.Add(new shift()
                        {
                           sid = staff.id,
                           ca = shift.ca,
                           thu = shift.thu,
                           status = "absence"
                        });
                        db.SaveChanges();
                }
            }
        }
        List<shift> getListShift()
        {
            var rs = from s in db.shifts
                     select s;
            return rs.ToList();
        }

        private void frmSchedule_Load(object sender, EventArgs e)
        {

        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                truncateShift();
                int mn = Convert.ToInt32(txtManager.Text);
                int dl = Convert.ToInt32(txtDelivery.Text);
                int ar = Convert.ToInt32(txtArrange.Text);
                Schedule sche = new Schedule(mn, dl, ar);
                sche.makeSchedule();
                saveSchedule(sche.Result);
                gvShift.DataSource = null;
                gvShift.DataSource = getListShift();
            }
            catch(Exception ex) {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin." + ex.Message);
            }
}

        private void windowsUIButtonPanel1_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            if(e.Button.Properties.Caption == "View")
            {
                Form view = new viewSchedule();
                view.ShowDialog();
            }
            else
            {
                this.Close();
            }
        }
        void truncateShift()
        {
            var records = from s in db.shifts
                          select s;
            List<shift> shifts = records.ToList();
            foreach (shift s in shifts)
            {
                db.shifts.Remove(s);
                db.SaveChanges();
            }
            db.Database.ExecuteSqlCommand("truncate table shifts");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
