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

namespace Library_management.forms.Admin
{
    public partial class CheckIn : Form
    {
        LibraryEntities db = new LibraryEntities();

        public CheckIn()
        {
            InitializeComponent();
        }
        private void txtStaffID_Enter(object sender, EventArgs e)
        {
            if (txtStaffID.Text == "Staff ID")
            {
                txtStaffID.Text = "";
                txtStaffID.ForeColor = Color.Black;
            }
        }

        private void txtStaffID_Leave(object sender, EventArgs e)
        {
            if (txtStaffID.Text == "")
            {
                txtStaffID.Text = "Staff ID";
                txtStaffID.ForeColor = Color.Silver;
            }
        }

        private void txtStaffName_Enter(object sender, EventArgs e)
        {
            if (txtStaffName.Text == "Staff Code")
            {
                txtStaffName.Text = "";
                txtStaffName.ForeColor = Color.Black;
            }
        }

        private void txtStaffName_Leave(object sender, EventArgs e)
        {
            if (txtStaffName.Text == "")
            {
                txtStaffName.Text = "Staff Code";
                txtStaffName.ForeColor = Color.Silver;
            }
        }

        private void windowsUIButtonPanel1_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            if (e.Button.Properties.Caption == "CHECK IN")
            {
                staff st = staffDB.getByIdInStaff(Convert.ToInt32(txtStaffID.Text));
                if (st != null)
                {
                    if (st.code == txtStaffName.Text)
                    {
                        DateTime checkin = DateTime.Now;
                        int ca = getShift(checkin);
                        int thu = Convert.ToInt32(checkin.DayOfWeek) + 1;
                        shift sh = getShiftinSche(st.id, ca, thu);
                        string status = "welldone";
                        if(ca == 1)
                        {
                            if(checkin.Hour >= 7 && checkin.Minute > 0)
                            {
                                status = "late";
                            }
                        }
                        else if(ca == 2){
                            if (checkin.Hour >= 12 && checkin.Minute > 10)
                            {
                                status = "late";
                            }
                        }
                        else
                            if (checkin.Hour >= 16 && checkin.Minute > 10)
                            {
                                status = "late";
                            }
                        updateStatus(sh, status);
                        MessageBox.Show("Đã ghi nhận: " + status, "Chấm công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Sai code ", "Chấm công", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                    MessageBox.Show("Không tìm thấy id ", "Chấm công", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                Form attend = new attendance();
                attend.ShowDialog();
            }
        }
        int getShift(DateTime checkin)
        {
            int ca = 1;
            if (checkin.Hour >= 8 && checkin.Minute > 15)
            {
                ca = 2;
            }
            if (checkin.Hour >= 13 && checkin.Minute > 15)
            {
                ca = 3;
            }
            return ca;
        }
        shift getShiftinSche(int sid, int ca, int thu)
        {
            return db.shifts.Where(s => s.sid == sid && s.ca == ca && s.thu == thu).SingleOrDefault();
        }
        void updateStatus(shift s, string status)
        {
            s.status = status;
            db.SaveChanges();
        }
    }
}
