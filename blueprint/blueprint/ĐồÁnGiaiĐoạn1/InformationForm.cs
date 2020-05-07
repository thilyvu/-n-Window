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

    public partial class InformationForm : Form
    {
        public string con = @"Data Source=LAPTOP-CBHLNUT7\SQLEXPRESS;Initial Catalog=blueprints;Integrated Security=True";
        public InformationForm()
        {
            InitializeComponent();
        }

        private void InformationForm_Load(object sender, EventArgs e)
        {
            tbID.Text = label2.Name;
            getdatabyid((tbID.Text));
        }
        void getdatabyid(string id)
        {
            try
            {
                string query;
                if (label3.Name == "staff")
                {
                    query = "SELECT * FROM	dbo.employee WHERE id =" + id;
                    this.labelINFO.Text = "STAFF INFORMATION";
                }
                else
                {
                    query = "SELECT * FROM	dbo.manager WHERE id =" + id;
                    labelHours.Text = "SHIFTWORK";
                    this.labelINFO.Text = "MANAGER INFORMATION";
                }
                
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
    }
}
