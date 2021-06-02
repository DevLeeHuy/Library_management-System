using DevExpress.XtraReports.UI;
using Library_management.config;
using Library_management.forms.Book;
using Library_management.forms.Chart;
using Library_management.forms.Schedule;
using Library_management.forms.Student;
using Library_management.forms.Teacher;
using Library_management.models;
using Library_management.Report;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_management.forms.Admin
{
    public partial class mainFrmAdmin : Form
    {
        user u = userDB.getById(Globals.user);

        public mainFrmAdmin()
        {
            InitializeComponent();
            showProfile();
        }
        void showProfile()
        {
            profileId.Text = "User ID: " + u.id + $" ({ u.userType.typeName})";
            profileName.Text = "Name: " + u.fname + " " + u.lname;
            profileImg.Image = Image.FromStream(new MemoryStream(u.img));
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void windowsUIButtonPanel1_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            Form f = new Form();
            switch (e.Button.Properties.Caption)
            {
                case "STUDENT":
                    f = new ManageStd();
                    f.ShowDialog();
                    break;
                case "TEACHER":
                    f = new ManageTeacher();
                    f.ShowDialog();
                    break;
                case "STAFF":
                    f = new ManageStaff();
                    f.ShowDialog();
                    break;
                case "BOOK":
                    f = new ManageBook();
                    f.ShowDialog();
                    break;
                case "RETURN":
                    f = new processReturnBook();
                    f.ShowDialog();
                    break;
                case "PRINT USERS":
                    printUser();
                    break;
                case "PRINT BOOK":
                    printBook();
                    break;
                case "SCHEDULE":
                    f= new frmSchedule();
                    f.ShowDialog();
                    break;
                default:
                    break;
            }
            
        }

        private void mainFrmAdmin_Load(object sender, EventArgs e)
        {
            lbAmountBook.Text = bookDB.getList().Count.ToString();
            lbAmountBorrow.Text = borrowDB.getList().Count.ToString();
            lbAmountTeacher.Text = teacherDB.getListTeacher().Count.ToString();
            lbAmountStudent.Text = studentDB.getListStd().Count.ToString();
            lbAmountStaff.Text = staffDB.getListInStaff().Count.ToString();
            lbAmountReturn.Text = returnDB.getList().Count.ToString();
            lbAmountLibraryBorrow.Text = bookDB.getListBookOfTeacher().Count.ToString();
            lbAmountFineMoney.Text = fineDB.Total().ToString();
        }

        private void btnLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Globals.setUser(-1);
            this.Close();
            Form f = new frmLogin();
            f.Show();
        }
        void printUser()
        {
            User_list report = new User_list();
            report.Parameters["Print_date"].Value = DateTime.Now;
            ReportPrintTool preview = new ReportPrintTool(report);
            preview.ShowRibbonPreview();
        }
        void printBook()
        {
            Book_List report = new Book_List();
            ReportPrintTool preview = new ReportPrintTool(report);
            preview.ShowRibbonPreview();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Form chart = new ChartStudent();
            chart.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            mainFrmAdmin_Load(sender, e);
        }
    }
}
