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
    public partial class SalaryForm : Form
    {
        public string con = @"Data Source=LAPTOP-CBHLNUT7\SQLEXPRESS;Initial Catalog=blueprints;Integrated Security=True";
        public SalaryForm()
        {
            InitializeComponent();
        }
        void getdata(string query)
        {
            try
            {
                SqlConnection connect = new SqlConnection(con);

                SqlCommand cmd = new SqlCommand(query, connect);

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
            catch (Exception e1)
            {
                MessageBox.Show(e1.ToString());
            }
        }

        void countSalary()
        {
            try
            {
                string query = "UPDATE dbo.Salary SET salary=checkin*50000-subtractpoint*100000+pluspoint*100000";
                SqlConnection connect = new SqlConnection(con);
                SqlCommand cmd = new SqlCommand(query, connect);
                connect.Open();
                if (connect.State == System.Data.ConnectionState.Open)
                {
                    cmd.ExecuteNonQuery();
                }
                connect.Close();
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.ToString());
            }
        }
        private void SalaryForm_Load(object sender, EventArgs e)
        {
          //  countSalary();
            string query = "SELECT dbo.ShiftWork.EID,MORNING,AFTERNOON,EVENING,checkin,checkout,pluspoint,subtractpoint,salary FROM dbo.Salary,dbo.ShiftWork WHERE Salary.ID=dbo.ShiftWork.EID";
            getdata(query);
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show(dataGridView1.CurrentRow.Cells[7].Value.ToString());
             try
             {
                 string query = "UPDATE dbo.Salary SET salary=@salary,pluspoint=@plus,subtractpoint=@subtract WHERE ID= @ID";
                 SqlConnection connect = new SqlConnection(con);
                 SqlCommand cmd = new SqlCommand(query, connect);
              //  MessageBox.Show(dataGridView1.CurrentRow.Cells[7].Value.ToString());
                cmd.Parameters.Add("@salary", SqlDbType.Int).Value = dataGridView1.CurrentRow.Cells[8].Value;
                cmd.Parameters.Add("@plus", SqlDbType.Int).Value = dataGridView1.CurrentRow.Cells[6].Value;
                cmd.Parameters.Add("@subtract", SqlDbType.Int).Value = dataGridView1.CurrentRow.Cells[7].Value;
                cmd.Parameters.Add("@ID", SqlDbType.Int).Value = dataGridView1.CurrentRow.Cells[0].Value;
                connect.Open();
                 if (connect.State == System.Data.ConnectionState.Open)
                 {
                     if(cmd.ExecuteNonQuery()==1)
                    {
                        MessageBox.Show("changed","information",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                     else
                    {
                        MessageBox.Show("you can only change salary,pluspoint and subtract point","warning", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    }
                 }
                 connect.Close();
             }
             catch (Exception e1)
             {
                 MessageBox.Show(e1.ToString());
             }

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            InformationForm frm = new InformationForm();
            //frm.label3.Name = label2.Name;
            frm.labelINFO.Text = "EMPLOYEE INFORMATION";
            frm.label2.Name = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frm.Show();
        }
    }

}
