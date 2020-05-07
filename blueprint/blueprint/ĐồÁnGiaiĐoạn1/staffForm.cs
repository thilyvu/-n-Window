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
    public partial class staffForm : Form
    {
        public string con = @"Data Source=LAPTOP-CBHLNUT7\SQLEXPRESS;Initial Catalog=blueprints;Integrated Security=True";
        public staffForm()
        {
            InitializeComponent();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePassForm frm = new ChangePassForm();
            frm.label1.Name = "staff";
            frm.Show();
        }

        private void informationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InformationForm frm = new InformationForm();
            frm.label2.Name = label4.Name;
            frm.label3.Name = "staff";
            frm.Show();
        }
        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void managerInformationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ManagerIFF frm = new ManagerIFF();
            frm.Show();
        }

        private void changeInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditForm frm = new EditForm();
            frm.label1.Text = "CHANGE INFORMATION";
            frm.btEdit.Text = "CHANGE";
            frm.comboBox1.Enabled = false;
            frm.Show();
        }
        int i = 0;// gioi han so lan bam nut 
        private void btCheckIn_Click(object sender, EventArgs e)
        {
           
            DateTime a = dateTimePicker1.Value;
            int b = a.Hour;
            string username = this.label5.Name;
            if(i==1)
            {
                return;
            }
            if(b==7 || b==11 || b==6)
            {
                try
                {
                    SqlConnection connect = new SqlConnection(con);
                    connect.Open();
                    if (connect.State == System.Data.ConnectionState.Open)
                    {

                        DateTime dateTime = dateTimePicker1.Value;
                        string query = "UPDATE dbo.Salary SET checkin=checkin+1 WHERE ID=@ID";
                        string query2 = "SELECT ID FROM dbo.StaffAcount WHERE username=@user";
                        SqlCommand cmd = new SqlCommand(query, connect);
                        SqlCommand cmd2 = new SqlCommand(query2, connect);
                        cmd2.Parameters.Add("@user", SqlDbType.NVarChar).Value = username;
                        int ID =Convert.ToInt32(cmd2.ExecuteScalar());
                        cmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID;
                        if (cmd.ExecuteNonQuery() == 1 )
                        {
                            MessageBox.Show("CheckIn successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.lbCheckin.Text = "CheckIn status : V";
                            i++;
                        }
                        else
                        {
                            MessageBox.Show("wrong id ", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                    }
                    connect.Close();
                }
                catch(Exception e1)
                {
                    MessageBox.Show(e1.Message,"error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    SqlConnection connect = new SqlConnection(con);
                    connect.Open();
                    if (connect.State == System.Data.ConnectionState.Open)
                    {

                        DateTime dateTime = dateTimePicker1.Value;
                        string query = "UPDATE dbo.Salary SET checkin=checkin+1,subtractpoint=1 WHERE ID=@ID";
                        string query2 = "SELECT ID FROM dbo.StaffAcount WHERE username=@user";
                        SqlCommand cmd = new SqlCommand(query, connect);
                        SqlCommand cmd2 = new SqlCommand(query2, connect);
                        cmd2.Parameters.Add("@user", SqlDbType.NVarChar).Value = username;
                        int ID = Convert.ToInt32(cmd2.ExecuteScalar());
                        cmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID;
                        if (cmd.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Checkin successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.lbCheckin.Text = "CheckIn status : V";
                            i++;
                        }
                        else
                        {
                            MessageBox.Show("wrong id ", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                    }
                    connect.Close();
                }
                catch (Exception e1)
                {
                    MessageBox.Show(e1.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        int j;//gioi han so lan bam 
        private void btCheckOut_Click(object sender, EventArgs e)
        {
            DateTime a = dateTimePicker1.Value;
            int b = a.Hour;
            string username = this.label5.Name;
            if (j == 1)
            {
                return;
            }
            if (b == 11 || b == 2 || b == 10)
            {
                try
                {
                    SqlConnection connect = new SqlConnection(con);
                    connect.Open();
                    if (connect.State == System.Data.ConnectionState.Open)
                    {

                        DateTime dateTime = dateTimePicker1.Value;
                        string query = "UPDATE dbo.Salary SET checkout=checkout+1 WHERE ID=@ID";
                        string query2 = "SELECT ID FROM dbo.StaffAcount WHERE username=@user";
                        SqlCommand cmd = new SqlCommand(query, connect);
                        SqlCommand cmd2 = new SqlCommand(query2, connect);
                        cmd2.Parameters.Add("@user", SqlDbType.NVarChar).Value = username;
                        int ID = Convert.ToInt32(cmd2.ExecuteScalar());
                        cmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID;
                        if (cmd.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Checkout successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.lbCheckout.Text = "CheckIn status : V";
                            j++;
                        }
                        else
                        {
                            MessageBox.Show("wrong id ", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                    }
                    connect.Close();
                }
                catch (Exception e1)
                {
                    MessageBox.Show(e1.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    SqlConnection connect = new SqlConnection(con);
                    connect.Open();
                    if (connect.State == System.Data.ConnectionState.Open)
                    {

                        DateTime dateTime = dateTimePicker1.Value;
                        string query = "UPDATE dbo.Salary SET checkout=checkout+1,subtractpoint=1 WHERE ID=@ID";
                        string query2 = "SELECT ID FROM dbo.StaffAcount WHERE username=@user";
                        SqlCommand cmd = new SqlCommand(query, connect);
                        SqlCommand cmd2 = new SqlCommand(query2, connect);
                        cmd2.Parameters.Add("@user", SqlDbType.NVarChar).Value = username;
                        int ID = Convert.ToInt32(cmd2.ExecuteScalar());
                        cmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID;
                        if (cmd.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Checkout successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.lbCheckout.Text = "CheckIn status : V";
                            j++;
                        }
                        else
                        {
                            MessageBox.Show("wrong id ", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                    }
                    connect.Close();
                }
                catch (Exception e1)
                {
                    MessageBox.Show(e1.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}
