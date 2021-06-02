using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library_management.config;
using Library_management.forms.Student;
using Library_management.forms.Teacher;
using Library_management.forms.Admin;
using Library_management.models;

namespace Library_management
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            account valid = userDB.checkAccount(txtUsername.Text, txtPassword.Text);
            RadioButton checkedButton = this.Controls.OfType<RadioButton>()
                                      .FirstOrDefault(r => r.Checked);
            if (valid != null)
            {
                user u = userDB.getById(valid.id);
                Globals.setUser(valid.id);
                Form mainform = new Form();
                bool invalid = false;
                if (checkedButton.Text == "Student")
                {
                    if (u.type != 3)
                        invalid = true;
                    else
                        mainform = new mainFrmStudent();
                }
                else if(checkedButton.Text == "Teacher")
                {
                    if (u.type != 2)
                        invalid = true;
                    else
                        mainform = new mainFrmTeacher();
                }
                else
                {
                    if (u.type != 1)
                        invalid = true;
                    else
                        mainform = new mainFrmAdmin();
                }
                if(invalid)
                    MessageBox.Show("You choose invalid type", "FAILED", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    mainform.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Invalid username or password", "FAILED", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorUname.SetError(txtUsername, "Please input your username");
                errorPass.SetError(txtPassword, "Please input your password");
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void linkSignUp_Click(object sender, EventArgs e)
        {
            Form regis = new frmRegister();
            regis.ShowDialog();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Username")
            {
                txtUsername.Text = "";
                txtUsername.ForeColor = Color.Black;
            }
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                txtUsername.Text = "Username";
                txtUsername.ForeColor = Color.Silver;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.Black;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Password";
                txtPassword.ForeColor = Color.Black;
            }
        }

        private void linkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form regis = new frmRegister();
            regis.ShowDialog();
        }

        private void checkLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form f = new CheckIn();
            f.ShowDialog();
        }
    }
}
