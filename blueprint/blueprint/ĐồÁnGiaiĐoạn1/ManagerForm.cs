using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ĐồÁnGiaiĐoạn1
{
    public partial class ManagerForm : Form
    {
        public string con = @"Data Source=LAPTOP-CBHLNUT7\SQLEXPRESS;Initial Catalog=blueprints;Integrated Security=True";
        public ManagerForm()
        {
            InitializeComponent();
        }

        private void ManagerForm_Load(object sender, EventArgs e)
        {

            string query = "SELECT * FROM dbo.ShiftWork";
            getdata(query);
            this.label2.Name = "staff";
            Bill a = new Bill();
            DateTime date = dateTimePicker1.Value;
            int totalIncome = a.getTotalIncome(date);
            tbTotalIncome.Text = totalIncome.ToString()+" VND";
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddForm frm = new AddForm();
            frm.label1.Text = "ADD EMLOYEE";
            frm.Show();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditForm frm = new EditForm();
            frm.label1.Text = "EDIT EMPLOYEE";
            frm.Show();
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemovebyIDForm frm = new RemovebyIDForm();
            frm.Show();
        }

        private void btViewAll_Click(object sender, EventArgs e)
        {
            ManagerIFF frm = new ManagerIFF();
            frm.Show();
        }

        private void changePassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePassForm frm = new ChangePassForm();
            frm.label1.Name = "manager";
            frm.Show();
        }

        private void informationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InformationForm frm = new InformationForm();
            frm.label2.Name = label4.Name;
            frm.Show();
        }

        private void btArrange_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM dbo.ShiftWork";
            getdata(query);
            int j;
            
            for (int i=1;i< dataGridView1.Rows.Count;i++)
            {
                j = i;
                string query1="";
                if (j%3==0)
                {
                    j = 3;
                }
                if(j>3)
                {
                    j = j - (j / 3) * 3;
                }
                if(j==1)
                {
                    query1 = "UPDATE dbo.ShiftWork SET MORNING=1,AFTERNOON=1,EVENING=0 WHERE EID=@id";
                }
                if(j==2)
                {

                     query1 = "UPDATE dbo.ShiftWork SET MORNING=1,AFTERNOON=0,EVENING=1 WHERE EID=@id";
                }
                if(j==3)
                {

                     query1 = "UPDATE dbo.ShiftWork SET MORNING=0,AFTERNOON=1,EVENING=1 WHERE EID=@id";
                }
                try
                {
                    SqlConnection connect = new SqlConnection(con);                   
                    connect.Open();
                    if (connect.State == System.Data.ConnectionState.Open)
                    {
                        SqlCommand cmd = new SqlCommand(query1, connect);
                        cmd.Parameters.Add("@ID", SqlDbType.Int).Value = i;
                        cmd.ExecuteNonQuery();
                    }
                    connect.Close();
                }
                catch(Exception e1)
                {
                    MessageBox.Show(e1.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                getdata(query);

            }
        }
        void getdata(string query)
        {
            try
            {
                SqlConnection connect = new SqlConnection(con);

                SqlCommand cmd = new SqlCommand(query, connect);
                dataGridView1.ReadOnly = true;
                dataGridView1.RowTemplate.Height = 50;
                connect.Open();
                if (connect.State == System.Data.ConnectionState.Open)
                {

                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable ds = new DataTable();
                    da.Fill(ds);
                    dataGridView1.DataSource = ds;
                }
                connect.Close();
            }
            catch(Exception e1)
            {
                MessageBox.Show(e1.ToString());
            }
        }

        private void btShowEmpoyee_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM dbo.employee";
            getdata(query);
            this.label2.Name = "staff";
        }

        private void btShowManager_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM  dbo.manager";
            getdata(query);
            this.label2.Name = "manager";
        }

        private void btSW_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM  dbo.ShiftWork";
            getdata(query);
        }

        private void btChangeShiftWork_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM dbo.ShiftWork";
            getdata(query);
            int j;

            for (int i = 1; i < dataGridView1.Rows.Count; i++)
            {
                j = i;
                string query1 = "";
                if (j % 3 == 0)
                {
                    j = 3;
                }
                if (j > 3)
                {
                    j = j - (j / 3) * 3;
                }
                if (j == 1)
                {
                    query1 = "UPDATE dbo.ShiftWork SET MORNING=0,AFTERNOON=1,EVENING=1 WHERE EID=@id";
                }
                if (j == 2)
                {

                    query1 = "UPDATE dbo.ShiftWork SET MORNING=1,AFTERNOON=1,EVENING=0 WHERE EID=@id";
                }
                if (j == 3)
                {

                    query1 = "UPDATE dbo.ShiftWork SET MORNING=1,AFTERNOON=0,EVENING=1 WHERE EID=@id";
                }
                try
                {
                    SqlConnection connect = new SqlConnection(con);
                    connect.Open();
                    if (connect.State == System.Data.ConnectionState.Open)
                    {
                        SqlCommand cmd = new SqlCommand(query1, connect);
                        cmd.Parameters.Add("@ID", SqlDbType.Int).Value = i;
                        cmd.ExecuteNonQuery();
                    }
                    connect.Close();
                }
                catch (Exception e1)
                {
                    MessageBox.Show(e1.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                getdata(query);
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
           
            InformationForm frm = new InformationForm();
            frm.label3.Name = label2.Name;
            frm.label2.Name = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frm.Show();

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void salaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalaryForm frm = new SalaryForm();
            frm.Show();
        }

        private void btBook_Click(object sender, EventArgs e)
        {
            Booking frm = new Booking();
            frm.Show();
        }
    }
}
