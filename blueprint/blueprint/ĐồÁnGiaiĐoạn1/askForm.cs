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
    public partial class askForm : Form
    {
        public askForm()
        {
            InitializeComponent();
        }

        private void btStaff_Click(object sender, EventArgs e)
        {
            
            loginForm frm = new loginForm();
            frm.label1.Text = "STAFF LOGIN";
            frm.Show();
            this.Hide();
        }

        private void btManager_Click(object sender, EventArgs e)
        {
          
            loginForm frm = new loginForm();
            frm.label1.Text = "MANAGER LOGIN";
            frm.Show();
            this.Hide();
        }
    }
}
