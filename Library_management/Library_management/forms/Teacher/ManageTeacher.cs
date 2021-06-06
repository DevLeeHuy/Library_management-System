using Library_management.config;
using Library_management.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_management.forms.Teacher
{
    public partial class ManageTeacher : Form
    {
        user u = userDB.getById(Globals.user);
        public ManageTeacher()
        {
            InitializeComponent();
        }

        private void FindBtn_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(txtId.Text);
            user std = teacherDB.getTeacherById(id);
            if (std != null)
            {
                txtLname.Text = std.lname;
                txtFname.Text = std.fname;
                txtAddress.Text = std.address;
                txtPhone.Text = std.phone;
                birthPicker.Value = (DateTime)std.BirthDate;
                if (std.gender == "male")
                {
                    maleRaBtn.Checked = true;
                }
                else
                {
                    femaleRaBtn.Checked = true;
                }
                Avatar.Image = Image.FromStream(new MemoryStream(std.img));
            }
            else
            {
                MessageBox.Show("Không tìm thấy giáo viên có mã " + id, "Không tìm thấy");
            }
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string fname = txtFname.Text;
                string lname = txtLname.Text;
                int id = Int32.Parse(txtId.Text);
                DateTime birth = birthPicker.Value;

                int bornYear = birthPicker.Value.Year;
                int thisYear = DateTime.Now.Year;
                if (thisYear - bornYear < 10 || thisYear - bornYear > 100)
                {
                    MessageBox.Show("The student age must be between 10 and 100 years old", "Invalid birth date", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string phone = txtPhone.Text;
                    string address = txtAddress.Text;


                    //File.Copy(Avatar.ImageLocation, Path.Combine(Application.StartupPath + "\\Images\\", Path.GetFileName(Avatar.ImageLocation)), true);
                    MemoryStream pic = new MemoryStream();
                    Avatar.Image.Save(pic, Avatar.Image.RawFormat);
                    RadioButton ckb = null;
                    foreach (RadioButton item in genderBox.Controls)
                    {
                        if (item != null)
                            if (item.Checked)
                            {
                                ckb = item;
                                break;
                            }
                    }
                    string gender = ckb.Text == "male" ? "male" : "female";
                    if (userDB.insertUser(2, id, fname, lname, birth, gender, phone, address, pic))
                    {
                        MessageBox.Show("Done", "Add successfully");
                    }
                    else
                    {
                        MessageBox.Show("Something wrong ", "Unsuccessful");
                    }
                    
                }
            }
            catch
            {
                MessageBox.Show("Something was wrong!!!");
            }
            ManageTeacher_Load(sender, e);
        }

        private void ManageTeacher_Load(object sender, EventArgs e)
        {
            gvTeacher.DataSource = teacherDB.getListTeacher();
            DataGridViewImageColumn picInList = (DataGridViewImageColumn)gvTeacher.Columns["img"];
            picInList.ImageLayout = DataGridViewImageCellLayout.Stretch;
            gvTeacher.AllowUserToAddRows = false;
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string fname = txtFname.Text;
                string lname = txtLname.Text;
                int id = Int32.Parse(txtId.Text);
                DateTime birth = birthPicker.Value;

                int bornYear = birthPicker.Value.Year;
                int thisYear = DateTime.Now.Year;
                if (thisYear - bornYear < 10 || thisYear - bornYear > 100)
                {
                    MessageBox.Show("The student age must be between 10 and 100 years old", "Invalid birth date", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string phone = txtPhone.Text;
                    string address = txtAddress.Text;


                    //File.Copy(Avatar.ImageLocation, Path.Combine(Application.StartupPath + "\\Images\\", Path.GetFileName(Avatar.ImageLocation)), true);
                    MemoryStream pic = new MemoryStream();
                    Avatar.Image.Save(pic, Avatar.Image.RawFormat);
                    RadioButton ckb = null;
                    foreach (RadioButton item in genderBox.Controls)
                    {
                        if (item != null)
                            if (item.Checked)
                            {
                                ckb = item;
                                break;
                            }
                    }
                    string gender = ckb.Text == "male" ? "male" : "female";
                    if (userDB.updateUser(id, fname, lname, birth, gender, phone, address, pic))
                    {
                        MessageBox.Show("Done", "Update successfully");
                    }
                    else
                    {
                        MessageBox.Show("Something wrong ", "Unsuccessful");
                    }
                    
                }
            }
            catch { }
            ManageTeacher_Load(sender, e);
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Int32.Parse(txtId.Text);
                if (userDB.deleteUser(id))
                {
                    MessageBox.Show("Done", "Remove successfully");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Something wrong ", "Unsuccessful");
                }
            }
            catch { }
            ManageTeacher_Load(sender, e);

        }

        private void upImgBtn_Click(object sender, EventArgs e)
        {
            try
            {
                String imageLocation = "";
                OpenFileDialog dialog = new OpenFileDialog();
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;
                }
                Avatar.ImageLocation = imageLocation;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Upload image unsuccessfully!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            SaveFileDialog svf = new SaveFileDialog();
            svf.FileName = ("student_" + txtId.Text);
            if (Avatar.Image == null)
            {
                MessageBox.Show("NO image in the picturebox");
            }
            else if (svf.ShowDialog() == DialogResult.OK)
            {
                Avatar.Image.Save(svf.FileName + ("." + ImageFormat.Jpeg.ToString()));
                MessageBox.Show("Save successful" + svf.FileName + ("." + ImageFormat.Jpeg.ToString()));
            }
        }

        private void gvListStudent_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = gvTeacher.CurrentRow.Cells[0].Value.ToString();
            FindBtn_Click(null, null);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
