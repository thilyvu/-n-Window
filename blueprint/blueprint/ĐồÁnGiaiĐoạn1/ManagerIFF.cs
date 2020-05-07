using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ĐồÁnGiaiĐoạn1
{
    public partial class ManagerIFF : Form
    {
        public ManagerIFF()
        {
            InitializeComponent();
        }

        private void AddEditRemoveForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'blueprintsDataSet2.manager' table. You can move, or remove it, as needed.
            this.managerTableAdapter.Fill(this.blueprintsDataSet2.manager);
            // TODO: This line of code loads data into the 'blueprintsDataSet1.employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.blueprintsDataSet1.employee);

        }
    }
}
