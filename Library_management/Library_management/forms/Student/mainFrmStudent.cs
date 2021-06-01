using Library_management.config;
using Library_management.forms.Book;
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

namespace Library_management.forms.Student
{
    public partial class mainFrmStudent : Form
    {
        user u = userDB.getById(Globals.user);
        public mainFrmStudent()
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
    
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void windowsUIButtonPanel1_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            Form f = new Form();
            switch (e.Button.Properties.Caption)
            {
                case "Borrow":
                    f = new ManageBorrow();
                    break;
                case "Return":
                    f = new ManageReturn();
                    break;
                case "STAFF":
                    break;
                default:
                    break;
            }
            f.ShowDialog();
        }

        private void mainFrmStudent_Load(object sender, EventArgs e)
        {
            lbAmoutBorrow.Text = borrowDB.getListByUid(u.id).Count.ToString();
            lbAmountReturnd.Text = returnDB.getListByUid(u.id).Count.ToString();
            lbAmountFineMoney.Text = fineDB.getById(u.id).fine.ToString() + "$";
        }

        private void btnLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Globals.setUser(-1);
            this.Close();
            Form f = new frmLogin();
            f.Show();
        }

        private void profileType_Click(object sender, EventArgs e)
        {

        }
    }
}
