using Library_management.config;
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

namespace Library_management
{
    public partial class LibraryBorrow : Form
    {
        user u =userDB.getById(Globals.user);
        public LibraryBorrow()
        {
            InitializeComponent();
        }

        private void windowsUIButtonPanel1_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            switch (e.Button.Properties.Caption)
            {
                case "GIVE":
                    giveBook();
                    break;
                case "CANCEL":
                    this.Close();
                    break;            
                default:
                    break;
            }
        }
        void giveBook()
        {
            MemoryStream pic = new MemoryStream();
            Avatar.Image.Save(pic, Avatar.Image.RawFormat);
            if (txtId.Text != "")
            {
                
                int id = Convert.ToInt32(txtId.Text);
                if(bookDB.updateQuantity(id, Convert.ToInt32(txtQuantity.Text)))
                {
                    bookDB.addTeacherBook(u.id, id, Convert.ToInt32(txtQuantity.Text));
                    MessageBox.Show("Thank you 💖💖", " Book Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Add failed", "Book Record", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (bookDB.insert(txtTitle.Text, txtDesc.Text, txtAuthor.Text, dtpDatePublish.Value, txtPublisher.Text,
                               Convert.ToInt32(cboCategory.SelectedValue), Convert.ToInt32(txtQuantity.Text), pic,0))
                {
                    bookDB.addTeacherBook(u.id, bookDB.getIdByTitle(txtTitle.Text), Convert.ToInt32(txtQuantity.Text));
                    MessageBox.Show("Thank you 💖💖", " Book Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Add failed", "Book Record", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LibraryBorrow_Load(object sender, EventArgs e)
        {
            gvBook.DataSource = bookDB.getList();
            cboCategory.DataSource = categoryDB.getList();
            cboCategory.DisplayMember = "catName";
            cboCategory.ValueMember = "id";
        }

        private void windowsUIButtonPanel2_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
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

        private void gvBook_Click(object sender, EventArgs e)
        {

            txtId.DataBindings.Clear();
            txtId.DataBindings.Add("Text", gvBook.DataSource, "id");
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {
            getInfo(Convert.ToInt32(txtId.Text));
        }
        void getInfo(int id)
        {
            book b = bookDB.getById(id);
            if (b != null)
            {
                txtTitle.Text = b.title;
                txtDesc.Text = b.description;
                txtAuthor.Text = b.author;
                txtPublisher.Text = b.publisher;
                dtpDatePublish.Value = (DateTime)b.pubDate;
                cboCategory.SelectedValue = b.categoryId;
                Avatar.Image = Image.FromStream(new MemoryStream(b.img));
            }
            else
            {
                MessageBox.Show("Không tìm thấy sách có mã " + id, "Không tìm thấy");
            }
        }
    }
}
