using Library_management.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_management
{
    public partial class ManageStaff : Form
    {
        public ManageStaff()
        {
            InitializeComponent();
        }

        private void ManageStaff_Load(object sender, EventArgs e)
        {
            gvListStaff.DataSource = staffDB.getList();
            DataGridViewImageColumn picInList = (DataGridViewImageColumn)gvListStaff.Columns["img"];
            picInList.ImageLayout = DataGridViewImageCellLayout.Stretch;
            gvListStaff.AllowUserToAddRows = false;
        }

        private void windowsUIButtonPanel1_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            switch (e.Button.Properties.Caption)
            {
                case "ADD":
                    addStaff();
                    break;
                case "DELETE":
                    removeStaff();
                    break;
                case "UPDATE":
                    updateStaff();
                    break;

                default:
                    break;
            }
            ManageStaff_Load(sender, e);
        }

        void addStaff()
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
                    RadioButton checkedButton = this.RoleBox.Controls.OfType<RadioButton>()
                                     .FirstOrDefault(r => r.Checked);
                    int staffRole = checkedButton.TabIndex - 148;
                    if (userDB.insertUser(4, id, fname, lname, birth, gender, phone, address, pic) && staffDB.insert(id, staffRole,"1234"))
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
        }
        void updateStaff()
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
                RadioButton checkedButton = this.RoleBox.Controls.OfType<RadioButton>()
                                   .FirstOrDefault(r => r.Checked);
                int staffRole = checkedButton.TabIndex - 148;
                if (userDB.updateUser(id, fname, lname, birth, gender, phone, address, pic) && staffDB.update(id, staffRole,"1234") )
                {
                    MessageBox.Show("Done", "Update successfully");
                }
                else
                {
                    MessageBox.Show("Something wrong ", "Unsuccessful");
                }
            }
        }
        void removeStaff()
        {
            int id = Int32.Parse(txtId.Text);
            if (userDB.deleteUser(id))
            {
                MessageBox.Show("Done", "Remove successfully");
            }
            else
            {
                MessageBox.Show("Something wrong ", "Unsuccessful");
            }
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

        private void FindBtn_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(txtId.Text);
            user std = staffDB.getById(id);
            int role = (int)staffDB.getByIdInStaff(id).role;
            if (std != null)
            {
                txtLname.Text = std.lname;
                txtFname.Text = std.fname;
                txtAddress.Text = std.address;
                txtPhone.Text = std.phone;
                try
                {

                    birthPicker.Value = (DateTime)std.BirthDate;
                Avatar.Image = Image.FromStream(new MemoryStream(std.img));
                }
                catch {
                    Avatar.Image = null;
                }
                if (std.gender == "male")
                {
                    maleRaBtn.Checked = true;
                }
                else
                {
                    femaleRaBtn.Checked = true;
                }
                RadioButton checkedButton = this.RoleBox.Controls.OfType<RadioButton>()
                                   .FirstOrDefault(r => r.TabIndex == (role + 148));
                checkedButton.Checked = true;
            }
            else
            {
                MessageBox.Show("Không tìm thấy sinh viên có mã " + id, "Không tìm thấy");
            }
        }

        private void gvListStaff_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = gvListStaff.CurrentRow.Cells[0].Value.ToString();
            FindBtn_Click(null, null);
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
