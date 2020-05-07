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
    public partial class RemovebyIDForm : Form
    {
        public RemovebyIDForm()
        {
            InitializeComponent();
        }
        public string con = @"Data Source=LAPTOP-CBHLNUT7\SQLEXPRESS;Initial Catalog=blueprints;Integrated Security=True";
        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(textBox1.Text);
            try
            {
                SqlConnection connect = new SqlConnection(con);
                connect.Open();
                if (textBox1.Text != "")
                {
                    if (connect.State == System.Data.ConnectionState.Open)
                    {

                        string query = "DELETE FROM dbo.employee WHERE ID=@id";
                        string query2 = "DELETE FROM dbo.SHIFTWORK WHERE EID=@id";
                        string query3 = "DELETE FROM dbo.Salary WHERE ID=@id";
                        SqlCommand cmd = new SqlCommand(query, connect);
                        SqlCommand cmd2 = new SqlCommand(query2, connect);
                        SqlCommand cmd3 = new SqlCommand(query3, connect);
                        cmd.Parameters.Add("@ID", SqlDbType.Int).Value = textBox1.Text;
                        cmd2.Parameters.Add("@ID", SqlDbType.Int).Value = textBox1.Text;
                        cmd3.Parameters.Add("@ID", SqlDbType.Int).Value = textBox1.Text;
                        if (cmd.ExecuteNonQuery() == 1 && cmd2.ExecuteNonQuery() == 1&& cmd3.ExecuteNonQuery()==1)
                        {
                            MessageBox.Show("Remove successfully ", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("wrong id ", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                    }
                    connect.Close();
                }
                else
                {
                    MessageBox.Show("blank isn't allowed", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch(Exception e1)
            {
                MessageBox.Show(e1.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }   }
}
