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
    public partial class Category : Form
    {
        public Category()
        {
            InitializeComponent();
        }

        private void Category_Load(object sender, EventArgs e)
        {
            gvList.DataSource = categoryDB.getList();
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            if (categoryDB.insert(txtCategory.Text))
            {
                MessageBox.Show("Done", "Add successfully");
            }
            else
            {
                MessageBox.Show("Something wrong ", "Unsuccessful");
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (categoryDB.update(Convert.ToInt32(txtId.Text),txtCategory.Text))
            {
                MessageBox.Show("Done", "Update successfully");
            }
            else
            {
                MessageBox.Show("Something wrong ", "Unsuccessful");
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (categoryDB.delete(Convert.ToInt32(txtId.Text)))
            {
                MessageBox.Show("Done", "Delete successfully");
            }
            else
            {
                MessageBox.Show("Something wrong ", "Unsuccessful");
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
