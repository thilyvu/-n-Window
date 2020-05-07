using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ĐồÁnGiaiĐoạn1
{
    class Dish
    {
        public string con = @"Data Source=LAPTOP-CBHLNUT7\SQLEXPRESS;Initial Catalog=blueprints;Integrated Security=True";
        private int id;
        private string name;
        private int price;
        private string dishStatus;
        private int total;
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Price { get => price; set => price = value; }
        public string DishStatus { get => dishStatus; set => dishStatus = value; }
        public int Total { get => total; set => total = value; }
        public Dish()
        {

        }
        public Dish( int total,string name)
        {
            this.Name = name;
            this.Total = total;
        }
        public Dish(int id ,string name, int price, string dishStatus,int total)
        {
            this.Id = id;
            this.Name = name;
            this.Price = price;
            this.DishStatus = dishStatus;
            this.Total = total;
        }
        public Dish(DataRow row)
        {
            this.Id = (int)row["ID"];
            this.Name = row["Name"].ToString();
            this.Price = (int)row["Price"];
            this.DishStatus = row["DishStatus"].ToString();
            this.Total = (int)row["Total"];
        }
        public List<Dish> LoadTable()
        {
            List<Dish> dishlist = new List<Dish>();
            try
            {
                string query = "SELECT * FROM dbo.Dish";
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
                        Dish tb = new Dish(item);
                        dishlist.Add(tb);
                    }
                }
                connect.Close();
                return dishlist;
            }
            catch
            {
                MessageBox.Show("error happened", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return dishlist;
        }
        
        public void updatedish(Dish a )
        {
            int total = a.total;
            string name = a.name;
            try
            {
                string query = "UPDATE dbo.Dish SET Total=Total-@T WHERE Name=@N";
                string query1 = "UPDATE dbo.Dish SET DishStatus='out of stock' WHERE Total <=0";
                SqlConnection connect = new SqlConnection(con);
              
                connect.Open();
                if (connect.State == System.Data.ConnectionState.Open)
                {
                    SqlCommand cmd = new SqlCommand(query, connect);
                    cmd.Parameters.Add("@N", SqlDbType.NVarChar).Value = name.ToString();
                    cmd.Parameters.Add("@T", SqlDbType.Int).Value = Convert.ToInt32(total);
                    SqlCommand cmd1 = new SqlCommand(query1, connect);
                    if(cmd.ExecuteNonQuery()==1)
                    {
                        //MessageBox.Show("Update successfull");
                    }
                    else
                    {
                        MessageBox.Show("error", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
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
