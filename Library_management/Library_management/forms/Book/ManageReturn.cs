using Library_management.config;
using Library_management.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_management.forms.Book
{
    public partial class ManageReturn : Form
    {
        user u = userDB.getById(Globals.user);
        book b = new book();
        float expFine = 5;
        public ManageReturn()
        {
            InitializeComponent();
            txtBorrowerId.Text = u.id.ToString();
            txtName.Text = u.lname + " " + u.fname;
        }

        private void windowsUIButtonPanel_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            switch (e.Button.Properties.Caption)
            {
                case "Return":
                    returnBook();
                    break;
                case "Return ALL":
                    returnAllBook();
                    break;
                case "Cancel":
                    this.Close();
                    break;
                case "Print":
                    break;
                default:
                    break;
            }
            ManageReturn_Load(sender, e);
        }

        private void ManageReturn_Load(object sender, EventArgs e)
        {
            cbLost.Checked = false;
            gvBorrow.DataSource = bookDB.getListBookBorrowByUid(u.id);
            txtBookID.DataBindings.Clear();
            txtBookID.DataBindings.Add("Text", gvBorrow.DataSource, "id");
        }
        void returnBook()
        {
            try
            {
                int exp = DateTime.Compare(DateTime.Now, dtpReturnDate.Value);
                if (!cbLost.Checked)
                {
                    if (exp > 0 && u.type != 2)
                    {
                        if (fineDB.getById(u.id) != null)
                        {
                            float fine = (float)(fineDB.getById(u.id).fine) + expFine;
                            fineDB.update(u.id, fine);
                        }
                        else
                        {
                            float fine = expFine;
                            fineDB.insert(u.id, fine);
                        }
                        MessageBox.Show("You are fined because return book after expired date !!!", "Return record", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                }
                else
                {
                    if (u.type != 2)
                    {
                        if (fineDB.getById(u.id) != null)
                        {
                            float fine = (float)((float)(fineDB.getById(u.id).fine) + b.price);
                            fineDB.update(u.id, fine);
                        }
                        else
                        {
                            float fine = (float)b.price;
                            fineDB.insert(u.id, fine);
                        }
                        MessageBox.Show("You are fined because because you lost the book !!!", "Return record", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                if (returnDB.insert(u.id, b.id, exp > 0, cbLost.Checked) && borrowDB.delete(u.id, b.id))
                {
                    bookDB.updateQuantity(b.id, 1);
                    MessageBox.Show("Successfully return", " Return Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Return failed", "Return Record", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch { }
        }
        void returnAllBook()
        {
            try
            {
                List<borrow> books = borrowDB.getListByUid(u.id);
                foreach (borrow br in books)
                {
                    int exp = DateTime.Compare(DateTime.Now, (DateTime)br.expired);
                    if (exp > 0)
                    {
                        if (fineDB.getById(u.id) != null)
                        {
                            float fine = (float)(fineDB.getById(u.id).fine) + expFine;
                            fineDB.update(u.id, fine);
                        }
                        else
                        {
                            float fine = expFine;
                            fineDB.insert(u.id, fine);
                        }
                        MessageBox.Show("You are fined because return book after expired date !!!\n Book ID: " + br.bid, "Return record", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    if (returnDB.insert(u.id, (int)br.bid, exp > 0, false))
                    {
                        if (!borrowDB.delete(u.id, (int)br.bid))
                        {
                            bookDB.updateQuantity((int)br.bid, 1);

                            MessageBox.Show("Return book id: " + br.bid + " failed", "Return Record", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                    else
                    {

                        MessageBox.Show("Return book id: " + br.bid + " failed", "Return Record", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch { }
        }

        private void txtBookID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                b = bookDB.getById(Convert.ToInt32(txtBookID.Text));
                txtTitle.Text = b.title;
                borrow br = borrowDB.getDate(u.id, b.id);
                dtpBorrowDate.Value = (DateTime)br.borrowDate;
                dtpReturnDate.Value = (DateTime)br.expired;
            }
            catch { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbLost_CheckedChanged(object sender, EventArgs e)
        {
        
        }
    }
}
