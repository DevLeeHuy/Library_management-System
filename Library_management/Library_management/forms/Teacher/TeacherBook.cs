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

namespace Library_management.forms.Teacher
{
    public partial class TeacherBook : Form
    {
        user u = userDB.getById(Globals.user);

        public TeacherBook()
        {
            InitializeComponent();
            gvBook.DataSource = bookDB.getListBookOfTeacherById(u.id);
        }
    }
}
