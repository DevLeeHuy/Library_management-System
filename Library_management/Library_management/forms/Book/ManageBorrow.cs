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
    public partial class ManageBorrow : Form
    {
        user u = userDB.getById(Globals.user);

        public ManageBorrow()
        {
            InitializeComponent();
            txtBorrowerId.Text = u.id.ToString();
            txtName.Text = u.lname + " " + u.fname;
            dtpBorrowDate.Value = DateTime.Now;
            dtpExpiredDate.Value = DateTime.Now.AddMonths(3);
            this.dtpBorrowDate.Enabled = false;
            cbCat.DataSource = categoryDB.getList();
            cbCat.ValueMember = "id";
            cbCat.DisplayMember = "catName";
            gvBook.DataSource = bookDB.getListInStock();

        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if(txtSearch.Text== "input information's book")
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.Black;
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                txtSearch.Text = "input information's book";
                txtSearch.ForeColor = Color.Silver;
            }
        }

       

        private void ManageBorrow_Load(object sender, EventArgs e)
        {
            txtBookID.DataBindings.Clear();
            txtBookID.DataBindings.Add("Text", gvBook.DataSource, "id");
            txtTitle.DataBindings.Clear();
            txtTitle.DataBindings.Add("Text", gvBook.DataSource, "title");
        }

        private void windowsUIButtonPanel_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            switch (e.Button.Properties.Caption)
            {
                case "Borrow":
                    borrow();
                    break;
                case "Cancel":
                    this.Close();
                    break;
                case "Print":
                    break;
                default:
                    break;
            }
            ManageBorrow_Load(sender, e);
        }
        void borrow()
        {
            if (borrowDB.insert(u.id, Convert.ToInt32(txtBookID.Text), dtpBorrowDate.Value, dtpExpiredDate.Value))
            {
                bookDB.updateQuantity(Convert.ToInt32(txtBookID.Text), -1);
                MessageBox.Show("Borrow successfully", " Borrow Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Borrow failed", "Book Record", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
        void print() { }

        private void cbCat_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                gvBook.DataSource = bookDB.getByCat(Convert.ToInt32(cbCat.SelectedValue));
                ManageBorrow_Load(sender, e);
            }
            catch
            { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
