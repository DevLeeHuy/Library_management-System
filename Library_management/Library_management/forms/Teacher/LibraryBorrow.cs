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
                               Convert.ToInt32(cboCategory.SelectedValue), Convert.ToInt32(txtQuantity.Text), pic))
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
    }
}
