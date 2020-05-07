using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ĐồÁnGiaiĐoạn1
{
    class Ingredient
    {
        public string con = @"Data Source=LAPTOP-CBHLNUT7\SQLEXPRESS;Initial Catalog=blueprints;Integrated Security=True";
        private int id;
        private string i1;
        private string i2;
        private string i3;
        private int q1;
        private int q2;
        private int q3;
        private int error;

        public int Id { get => id; set => id = value; }
        public string I1 { get => i1; set => i1 = value; }
        public string I2 { get => i2; set => i2 = value; }
        public string I3 { get => i3; set => i3 = value; }
        public int Q1 { get => q1; set => q1 = value; }
        public int Q2 { get => q2; set => q2 = value; }
        public int Q3 { get => q3; set => q3 = value; }
        public int Error { get => error; set => error = value; }
        public Ingredient()
        {

        }
        public Ingredient(DataRow row)
        {
            this.I1 = row["ING1"].ToString();
            this.I2 = row["ING2"].ToString();
            this.I3 = row["ING3"].ToString();
            this.Id = (int)row["ID"];
            this.Error = (int)row["Error"];
            this.Q1 = (int)row["Quantity1"];
            this.Q2 = (int)row["Quantity2"];
            this.Q3 = (int)row["Quantity3"];
        }
        public List<Ingredient> GetIngredients()
        {
            List<Ingredient> listbill = new List<Ingredient>();
            try
            {
                string query = "SELECT MAX(DISTINCT  quantity) AS quantity ,ID,Name,Price,DayCheckOut  FROM dbo.FoodBills GROUP BY ID,Price,Name,DayCheckOut ORDER BY quantity DESC";
                SqlConnection connect = new SqlConnection(con);
                SqlCommand cmd = new SqlCommand(query, connect);
                connect.Open();
                if (connect.State == System.Data.ConnectionState.Open)
                {

                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable ds = new DataTable();
                    da.Fill(ds);
                    foreach (DataRow item in ds.Rows)
                    {
                        Ingredient tb = new Ingredient(item);
                        listbill.Add(tb);
                    }
                }
                connect.Close();
                return listbill;
            }
            catch
            {
                MessageBox.Show("error happened", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return listbill;
        }
        public List<Ingredient> GetIngredientsbyName(string name)
        {
            List<Ingredient> listbill = new List<Ingredient>();
            try
            {
                string query = "SELECT ID FROM dbo.Dish WHERE Name=@N";

                SqlConnection connect = new SqlConnection(con);
                SqlCommand cmd = new SqlCommand(query, connect);
                cmd.Parameters.Add("@N", SqlDbType.NVarChar).Value = name.ToString();
                
                connect.Open();
                if (connect.State == System.Data.ConnectionState.Open)
                {
                    object a = cmd.ExecuteScalar();
                    string query1 = "SELECT * FROM dbo.Ingredients WHERE ID='"+Convert.ToInt32(a).ToString()+"'";
                    SqlDataAdapter da = new SqlDataAdapter(query1, con);
                    DataTable ds = new DataTable();
                    da.Fill(ds);
                    foreach (DataRow item in ds.Rows)
                    {
                        Ingredient tb = new Ingredient(item);
                        listbill.Add(tb);
                    }
                }
                connect.Close();
                return listbill;
        }
            catch
            {
                MessageBox.Show("error happened", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return listbill;
        }
    }
}
