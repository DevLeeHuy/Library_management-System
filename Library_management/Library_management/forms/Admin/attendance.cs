using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_management.forms.Admin
{
    public partial class attendance : Form
    {
        LibraryEntities db = new LibraryEntities();
        public attendance()
        {
            InitializeComponent();
        }

        private void attendance_Load(object sender, EventArgs e)
        {
            gvAttend.DataSource = db.getAttendance();
        }
    }
}
