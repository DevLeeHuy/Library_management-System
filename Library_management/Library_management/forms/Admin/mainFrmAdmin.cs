using Library_management.config;
using Library_management.forms.Book;
using Library_management.forms.Student;
using Library_management.forms.Teacher;
using Library_management.models;
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
            profileId.Text = "User ID: " + u.id;
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
                    break;
                case "TEACHER":
                    f = new ManageTeacher();
                    break;
                case "STAFF":
                    f = new Form();
                    break;
                case "BORROW":
                    f = new Form();
                    break;
                case "RETURN":
                    f = new Form();
                    break;
                case "BOOK":
                    f = new ManageBook();
                    break;
                default:
                    break;
            }
            f.ShowDialog();
        }

        private void mainFrmAdmin_Load(object sender, EventArgs e)
        {
            lbAmountBook.Text = bookDB.getList().Count.ToString();
        }

        private void btnLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Globals.setUser(-1);
            this.Close();
            Form f = new frmLogin();
            f.Show();
        }
    }
}
