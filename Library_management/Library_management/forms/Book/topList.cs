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
    public partial class topList : Form
    {
        public topList()
        {
            InitializeComponent();
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if(txtSearch.Text== "Search information of books")
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.Black;
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {

            if (txtSearch.Text == "")
            {
                txtSearch.Text = "Search information of books";
                txtSearch.ForeColor = Color.Silver;
            }
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

        private void txtTitle_Enter(object sender, EventArgs e)
        {
            if(txtTitle.Text=="Title of Book")
            {
                txtTitle.Text = "";
                txtTitle.ForeColor = Color.Black;
            }
        }

        private void txtTitle_Leave(object sender, EventArgs e)
        {
            if (txtTitle.Text == "")
            {
                txtTitle.Text = "Title of Book";
                txtTitle.ForeColor = Color.Black;
            }
        }

        private void txtCategory_Enter(object sender, EventArgs e)
        {
            if (txtCategory.Text == "Catagories")
            {
                txtCategory.Text = "";
                txtCategory.ForeColor = Color.Black;
            }
        }

        private void txtCategory_Leave(object sender, EventArgs e)
        {

            if (txtCategory.Text == "")
            {
                txtCategory.Text = "Catagories";
                txtCategory.ForeColor = Color.Silver;
            }
        }

        private void txtAuthor_Enter(object sender, EventArgs e)
        {
            if (txtAuthor.Text == "Author")
            {
                txtAuthor.Text = "";
                txtAuthor.ForeColor = Color.Black;
            }
        }

        private void txtAuthor_Leave(object sender, EventArgs e)
        {
            if (txtAuthor.Text == "")
            {
                txtAuthor.Text = "Author";
                txtAuthor.ForeColor = Color.Silver;
            }
        }
    }
}
