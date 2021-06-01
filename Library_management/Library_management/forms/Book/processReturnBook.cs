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
    }
}
