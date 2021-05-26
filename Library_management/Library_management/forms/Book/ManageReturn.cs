using Library_management.config;
using Library_management.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        List<int> Fine = new List<int>();
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
            gvBorrow.DataSource = bookDB.getListBookBorrowByUid(u.id);
            txtBookID.DataBindings.Clear();
            txtBookID.DataBindings.Add("Text", gvBorrow.DataSource, "id");
        }
        void returnBook()
        {
            int exp = DateTime.Compare(DateTime.Now, dtpReturnDate.Value);
            if (exp > 0 && u.type != 2)
            {
                MessageBox.Show("You are fined because return book after expired date !!!", "Return record", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Fine.Add(Convert.ToInt32(txtBookID.Text));
            }
            if (borrowDB.delete(u.id, b.id))
            {
                MessageBox.Show("Successfully return", " Return Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Return failed", "Return Record", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void returnAllBook()
        {
            List<borrow> books = borrowDB.getListByUid(u.id);
            foreach (borrow br in books)
            {
                int exp = DateTime.Compare(DateTime.Now, (DateTime)br.expired);
                if (exp > 0)
                {
                    MessageBox.Show("You are fined because return book after expired date !!!\n Book ID: "+ br.bid, "Return record", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Fine.Add(Convert.ToInt32(br.bid));
                }
                if (!borrowDB.delete(u.id, br.id))
                {
                    MessageBox.Show("Return book id: " + br.bid + " failed", "Return Record", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtBookID_TextChanged(object sender, EventArgs e)
        {
            b = bookDB.getById(Convert.ToInt32(txtBookID.Text));
            txtTitle.Text = b.title;
            borrow br = borrowDB.getDate(u.id, b.id);
            dtpBorrowDate.Value = (DateTime)br.borrowDate;
            dtpReturnDate.Value = (DateTime)br.expired;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
