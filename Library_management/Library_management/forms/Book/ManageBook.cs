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

namespace Library_management.forms.Book
{
    public partial class ManageBook : Form
    {
        public ManageBook()
        {
            InitializeComponent();
            cboCategory.DataSource = categoryDB.getList();
            cboCategory.ValueMember = "id";
            cboCategory.DisplayMember = "catName";
        }

        private void ManageBook_Load(object sender, EventArgs e)
        {
            gvBook.DataSource = bookDB.getList();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void windowsUIButtonPanel1_Click(object sender, EventArgs e)
        {

        }

        private void windowsUIButtonPanel1_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            switch (e.Button.Properties.Caption)
            {
                case "ADD":
                    addBook();
                    break;
                case "DELETE":
                    deleteBook();
                    break;
                case "UPDATE":
                    updateBook();
                    break;
                case "UPLOAD":
                    upload();
                    break;
                default:
                    break;
            }
            ManageBook_Load(sender, e);

        }
        void addBook()
        {
            MemoryStream pic = new MemoryStream();
            Avatar.Image.Save(pic, Avatar.Image.RawFormat);
            if (bookDB.insert(txtTitle.Text, txtDesc.Text, txtAuthor.Text, dtpDatePublish.Value, txtPublisher.Text,
                                Convert.ToInt32(cboCategory.SelectedValue), Convert.ToInt32(txtQuantity.Text), pic, Convert.ToInt32(txtPrice.Text)))
            {
                MessageBox.Show("Successfully Added", " Book Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Add failed", "Book Record", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void deleteBook()
        {
            int id = Convert.ToInt32(txtId.Text);
            if (bookDB.delete(id))
            {
                MessageBox.Show("Successfully Remove", " Book Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Remove failed", "Book Record", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void updateBook()
        {
            MemoryStream pic = new MemoryStream();
            Avatar.Image.Save(pic, Avatar.Image.RawFormat);
            int id = Convert.ToInt32(txtId.Text);
            if (bookDB.update(id, txtTitle.Text, txtDesc.Text, txtAuthor.Text, dtpDatePublish.Value, txtPublisher.Text,
                             Convert.ToInt32(cboCategory.SelectedValue), Convert.ToInt32(txtQuantity.Text), pic, Convert.ToInt32(txtPrice.Text)))
            {
                MessageBox.Show("Successfully Updated", " Book Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Updated failed", "Book Record", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
        void upload()
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
