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
    class Table
    {
        public string con = @"Data Source=LAPTOP-CBHLNUT7\SQLEXPRESS;Initial Catalog=blueprints;Integrated Security=True";
        private int id;

        public int Id { get => id; set => id = value; }
        public string TableStatus1 { get => TableStatus; set => TableStatus = value; }
        public string Name { get => name; set => name = value; }
        public int NumberOfPeople { get => numberOfPeople; set => numberOfPeople = value; }

        private string TableStatus;
        private string name;
        private int numberOfPeople;
        public static double tbHeight = 100;
        public static double tbwidth = 200;
        public Table()
        {

        }
        public Table (int id, string Table, string name,int num)
        {
            this.Id = id;
            this.TableStatus = Table;
            this.Name = name;
            this.NumberOfPeople = num;
        }
        public Table(DataRow row)
        {
            this.Id = (int)row["id"];
            this.Name = row["name"].ToString();
            this.TableStatus1 = row["Tablestatus"].ToString();
            this.NumberOfPeople=(int)row["NumberOfPeople"];
        }
        public List<Table> LoadTable()
        {
            List<Table> tableList = new List<Table>();
            try
            {
                string query = "SELECT * FROM dbo.EatTable";
                SqlConnection connect = new SqlConnection(con);
                SqlCommand cmd = new SqlCommand(query, connect);
                connect.Open();
                if (connect.State == System.Data.ConnectionState.Open)
                {

                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable ds = new DataTable();
                    da.Fill(ds);
                    foreach(DataRow item in ds.Rows)
                    {
                        Table tb = new Table(item);
                        tableList.Add(tb);
                    }
                }
                connect.Close();
                return tableList;
            }
            catch
            {
                MessageBox.Show("error happened", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return tableList;
        }
        public Table addTable()
        {
            Table l = new Table();
            try
            {
                SqlConnection connect = new SqlConnection(con);
                connect.Open();

                if (connect.State == System.Data.ConnectionState.Open)
                {
                    string query = "INSERT INTO dbo.EatTable ( id ,name ,Tablestatus ,NumberOfPeople)VALUES  ( @ID,@N,@S,@NP )";
                    string query1 = "SELECT COUNT(id) FROM dbo.EatTable";
                    SqlCommand cmd = new SqlCommand(query, connect);
                    SqlCommand cmd1 = new SqlCommand(query1, connect);
                    object a = cmd1.ExecuteScalar();
                    int ID = Convert.ToInt32(a) + 1;
                    cmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID;
                    cmd.Parameters.Add("@N", SqlDbType.VarChar).Value = "Table " + ID.ToString();
                    cmd.Parameters.Add("@S", SqlDbType.VarChar).Value = "Available";
                    cmd.Parameters.Add("@NP", SqlDbType.VarChar).Value = 0;
                    Table k = new Table(ID, "Table " + ID.ToString(), "Available",0);

                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Add successfully ", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
  
                        return k; 
                    }
                    else
                    {
                        MessageBox.Show("wrong id ", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                connect.Close();
            }
            catch
            {
                MessageBox.Show("error", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return l;
        }
          
        public int deleteTable()
        {           
            try
            {
                SqlConnection connect = new SqlConnection(con);
                connect.Open();

                if (connect.State == System.Data.ConnectionState.Open)
                {
                    string query = "DELETE dbo.EatTable WHERE id=@ID";
                    string query1 = "SELECT COUNT(id) FROM dbo.EatTable";
                    SqlCommand cmd1 = new SqlCommand(query1, connect);
                    SqlCommand cmd = new SqlCommand(query, connect);
                    object a = cmd1.ExecuteScalar();
                    int ID = Convert.ToInt32(a);
                    cmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID;
                    if (ID!=0 && cmd.ExecuteNonQuery()==1)
                    {
                        MessageBox.Show("Remove successfully ", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return ID;
                    }
                    else
                    {
                        MessageBox.Show("wrong id ", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                connect.Close();
            }
            catch
            {
                MessageBox.Show("error", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return 0;
        }

    }
}
