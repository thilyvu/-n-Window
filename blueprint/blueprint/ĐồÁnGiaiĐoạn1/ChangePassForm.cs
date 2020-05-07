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
    public partial class ChangePassForm : Form
    {
        public string con = @"Data Source=LAPTOP-CBHLNUT7\SQLEXPRESS;Initial Catalog=blueprints;Integrated Security=True";
        public ChangePassForm()
        {
            InitializeComponent();
        }

        private void btSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connect = new SqlConnection(con);
                connect.Open();
                if (tbNewPass.Text == tbNewPass2.Text)
                {
                    if (connect.State == System.Data.ConnectionState.Open)
                    {
                        string u = tbUser.Text;
                        string p = tbNewPass.Text;
                        string query;
                        if (label1.Name == "staff")
                        {
                            query= "UPDATE dbo.StaffAcount SET pass=@pass WHERE username=@name ";
                        }
                        else
                        {
                            query = "UPDATE dbo.ManagerAcount SET pass=@pass WHERE username=@name ";
                        }
                        SqlCommand cmd = new SqlCommand(query, connect);  
                        cmd.Parameters.Add("@pass", SqlDbType.NChar).Value = p;
                        cmd.Parameters.Add("@name", SqlDbType.NChar).Value = u;
                        if(cmd.ExecuteNonQuery()==1)
                        {
                            MessageBox.Show("your's password have been updated ","Notice",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("wrong username ", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                       
                    }
                    connect.Close();
                }
                else
                {
                    MessageBox.Show("ReEnterPass doesn't match new pass", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }
    }
}
