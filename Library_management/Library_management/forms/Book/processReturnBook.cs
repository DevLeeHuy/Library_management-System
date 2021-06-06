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
    public partial class processReturnBook : Form
    {
      
        public processReturnBook()
        {
            InitializeComponent();
        }

        private void txtIDBook_Enter(object sender, EventArgs e)
        {
            if(txtIDBook.Text=="ID Book")
            {
                txtIDBook.Text = "";
                txtIDBook.ForeColor = Color.Black;
            }
        }

        private void txtIDBook_Leave(object sender, EventArgs e)
        {
            if (txtIDBook.Text == "")
            {
                txtIDBook.Text = "ID Book";
                txtIDBook.ForeColor = Color.Silver;
            }
        }

        private void txtNameBook_Enter(object sender, EventArgs e)
        {
            if(txtNameBook.Text=="Name of Book")
            {
                txtNameBook.Text = "";
                txtNameBook.ForeColor = Color.Black;
            }

        }

        private void txtNameBook_Leave(object sender, EventArgs e)
        {

            if (txtNameBook.Text == "")
            {
                txtNameBook.Text = "Name of Book";
                txtNameBook.ForeColor = Color.Silver;
            }
        }

        private void processReturnBook_Load(object sender, EventArgs e)
        {
            gvReturn.DataSource = returnDB.getListPending();
            txtIDBook.DataBindings.Clear();
            txtIDBook.DataBindings.Add("Text", gvReturn.DataSource, "bid");
            txtRid.DataBindings.Clear();
            txtRid.DataBindings.Add("Text", gvReturn.DataSource, "id");
            txtUid.DataBindings.Clear();
            txtUid.DataBindings.Add("Text", gvReturn.DataSource, "uid");
        }

        private void txtIDBook_TextChanged(object sender, EventArgs e)
        {
            try
            {
                List<returnBook> rtBook = returnDB.getListPending();
                returnBook temp = rtBook.Where(r => r.bid == Convert.ToInt32(txtIDBook.Text)).SingleOrDefault();
                txtNameBook.Text = temp.book.title;
                ckLost.Checked = (bool)temp.isLost;
            }
            catch { }
        }

        private void windowsUIButtonPanel1_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txtRid.Text);
                int uid = Convert.ToInt32(txtUid.Text);
                book b = bookDB.getById(Convert.ToInt32(txtIDBook.Text));
                if (e.Button.Properties.Caption == "CONFIRM")
                {
                    if (returnDB.updateStatus(id, ckDamage.Checked, ckLost.Checked))
                    {
                        if (ckLost.Checked)
                        {
                            fineDB.fine(uid, (float)b.price);
                        }
                        else
                        {
                            fineDB.fine(uid, (float)b.price / 2);
                        }
                        processReturnBook_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Đã có lỗi không mong muốn");
                    }
                }
                else
                    this.Close();
            }
            catch { }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
