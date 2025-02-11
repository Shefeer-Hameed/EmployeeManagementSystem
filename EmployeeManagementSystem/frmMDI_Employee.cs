using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmployeeManagementSystem;

namespace EmployeeManagementSystem
{
    public partial class frmMDI_Employee : Form
    {
        public frmMDI_Employee()
        {
            InitializeComponent();
        }

        private void employeeDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmployeeDetails objfrmEmployeeDetails = new frmEmployeeDetails();
            objfrmEmployeeDetails.MdiParent = this;
            objfrmEmployeeDetails.Show();
        }
    }
}
