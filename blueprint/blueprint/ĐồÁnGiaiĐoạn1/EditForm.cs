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
    public partial class EditForm : Form
    {
        public string con = @"Data Source=LAPTOP-CBHLNUT7\SQLEXPRESS;Initial Catalog=blueprints;Integrated Security=True";
        public EditForm()
        {
            InitializeComponent();
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connect = new SqlConnection(con);
                connect.Open();
                if ( tbFN.Text != "" && tbLN.Text != "" && tbP.Text != "" && tbIDN.Text != "" && RBA.Text != "" && tbH.Text != "")
                {
                    if (connect.State == System.Data.ConnectionState.Open)
                    {
                        string FN = tbFN.Text;
                        string LN = tbLN.Text;
                        string P = tbP.Text;
                        DateTime dateTime = dateTimePicker1.Value;
                        string A = RBA.Text;
                        string IDN = tbIDN.Text;
                        string H = tbH.Text;
                        string query = "UPDATE dbo.employee SET FIRSTNAME=@FN, LASTNAME=@LN,PHONE=@P, BIRHDAY=@date,EMPLOYEEADDRESS=@A,IDNUMBER=@IDN,HOURSOFWORK=@H WHERE ID=@ID";
                        SqlCommand cmd = new SqlCommand(query, connect);
                        cmd.Parameters.Add("@ID", SqlDbType.Int).Value = comboBox1.SelectedValue;
                        cmd.Parameters.Add("@FN", SqlDbType.VarChar).Value = FN;
                        cmd.Parameters.Add("@LN", SqlDbType.VarChar).Value = LN;
                        cmd.Parameters.Add("@P", SqlDbType.VarChar).Value = P;
                        cmd.Parameters.Add("@date", SqlDbType.Date).Value = dateTime;
                        cmd.Parameters.Add("@A", SqlDbType.VarChar).Value = A;
                        cmd.Parameters.Add("@IDN", SqlDbType.VarChar).Value = IDN;
                        cmd.Parameters.Add("@H", SqlDbType.Int).Value = H;

                        if (cmd.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Edit successfully ", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }
        void getdata2(string query)
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
                    comboBox1.DataSource = ds;
                    comboBox1.ValueMember = "id";
                    comboBox1.DisplayMember = "id";
                }
                connect.Close();
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }
        void getdatabyid(int id)
        {
            try
            {
                string query = "SELECT * FROM	dbo.employee WHERE id =" + id;
                SqlConnection connect = new SqlConnection(con);
                SqlCommand cmd = new SqlCommand(query, connect);
                connect.Open();
                if (connect.State == System.Data.ConnectionState.Open)
                {

                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable ds = new DataTable();
                    da.Fill(ds);
                    tbFN.Text = ds.Rows[0][1].ToString();
                    tbLN.Text = ds.Rows[0][2].ToString();
                    tbP.Text = ds.Rows[0][3].ToString();
                    dateTimePicker1.Value = Convert.ToDateTime(ds.Rows[0][4]);
                    RBA.Text = ds.Rows[0][5].ToString();
                    tbIDN.Text = ds.Rows[0][6].ToString();
                    tbH.Text = ds.Rows[0][7].ToString();
                }
                connect.Close();
            }
            catch
            {
                MessageBox.Show("error happened", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void EditForm_Load(object sender, EventArgs e)
        {
            string query = "select * from dbo.employee";
            getdata2(query);
            getdatabyid(Convert.ToInt32(comboBox1.SelectedValue));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
           
            if((comboBox1.SelectedValue).ToString()!= "System.Data.DataRowView")
            {
                getdatabyid(Convert.ToInt32(comboBox1.SelectedValue));
            }
        }
    }
}
