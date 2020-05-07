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
using GlobalVariables;
namespace ĐồÁnGiaiĐoạn1
{
    public partial class Booking : Form
    {
        public string con = @"Data Source=LAPTOP-CBHLNUT7\SQLEXPRESS;Initial Catalog=blueprints;Integrated Security=True";
        public Booking()
        {
            InitializeComponent();
        }

        private void Booking_Load(object sender, EventArgs e)
        {
            List<Table> tableList = new List<Table>();
            Table a = new Table();
            tableList = a.LoadTable();
            foreach(Table item in tableList)
            {
                Button bt = new Button() {
                    Width = Convert.ToInt32(Table.tbwidth),
                    Height = Convert.ToInt32(Table.tbHeight)
                };
                switch(item.TableStatus1)
                {
                    case "Available":
                        bt.BackColor = Color.BlueViolet;
                        bt.Text = item.Name + Environment.NewLine + item.TableStatus1;
                        break;
                    default:
                        bt.BackColor = Color.Red;
                        bt.Text = item.Name + Environment.NewLine + item.TableStatus1+ Environment.NewLine+ item.NumberOfPeople +" People";
                        break;
                        
                }
                bt.Tag = item.Id;
                bt.Click += Bt_Click;
               
                flp.Controls.Add(bt);
            }
        }
        public void createButton()
        {
            List<Table> tableList = new List<Table>();
            Table a = new Table();
            tableList = a.LoadTable();
            foreach (Table item in tableList)
            {
                Button bt = new Button()
                {
                    Width = Convert.ToInt32(Table.tbwidth),
                    Height = Convert.ToInt32(Table.tbHeight)
                };
                switch (item.TableStatus1)
                {
                    case "Available":
                        bt.BackColor = Color.BlueViolet;
                        bt.Text = item.Name + Environment.NewLine + item.TableStatus1;
                        break;
                    default:
                        bt.BackColor = Color.Red;
                        bt.Text = item.Name + Environment.NewLine + item.TableStatus1 + Environment.NewLine + item.NumberOfPeople + " People";
                        break;

                }
                bt.Tag = item.Id;
                bt.Click += Bt_Click;

                flp.Controls.Add(bt);
            }
        }
        private void Bt_Click(object sender, EventArgs e)
        {
            //Globals.SetGlobalInt((sender as Table).Id);

            Button bt = sender as Button;
            object a = bt.Tag;
            //foreach (int item in bt.Text)
            //{
            //    Type tp = item.GetType();
            //    if (tp.Equals(typeof(int)))
            //    {
            //        if (item >= 48 && item <= 57)
            //        {
            //            Globals.SetGlobalInt(item - 48);
            //        }
            //    }
            //}
            Globals.SetGlobalInt(Convert.ToInt32(a));
            Order frm = new Order();
            frm.label5.Text = "Table " + Globals.GlobalInt.ToString();
            frm.Show();
            frm.FormClosed += Frm_FormClosed;
        }

        private void Frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            int id = Globals.GlobalInt;
            int numbelofpeople = Globals.NumberofPeople;
            string Tablestatus = numbelofpeople > 0 ? "UnAvailable" : "Available";
            foreach (Button item in flp.Controls)
            {
                if (Convert.ToInt32(item.Tag) == id)
                {
                    Table a = new Table(id,Tablestatus, "Table " + id.ToString(), numbelofpeople);
                    // update table in database
                    try
                    {
                        SqlConnection connect = new SqlConnection(con);
                        connect.Open();

                        if (connect.State == System.Data.ConnectionState.Open)
                        {
                            string query = "UPDATE dbo.EatTable SET Tablestatus=@TS, NumberOfPeople=@N WHERE id=@ID";
                            SqlCommand cmd = new SqlCommand(query, connect);
                            cmd.Parameters.Add("@TS", SqlDbType.NVarChar).Value = Tablestatus; 
                            cmd.Parameters.Add("@N", SqlDbType.Int).Value = Convert.ToInt32(numbelofpeople);
                            cmd.Parameters.Add("@ID", SqlDbType.Int).Value = Convert.ToInt32(id);
                            if (cmd.ExecuteNonQuery() == 1)
                            {
                                //MessageBox.Show("Add successfully ", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                flp.Controls.Clear();
                                createButton();
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
                        MessageBox.Show(e1.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btAddTabel_Click(object sender, EventArgs e)
        {
            Table a = new Table();
            a=a.addTable();
            Button bt = new Button()
            {
                Width = Convert.ToInt32(Table.tbwidth),
                Height = Convert.ToInt32(Table.tbHeight)
            };
            bt.BackColor = Color.BlueViolet;
            bt.Text = a.Name + Environment.NewLine + a.TableStatus1;
            bt.Tag = a.Id;
            bt.Click += Bt_Click;

            flp.Controls.Add(bt);
        }
        private void btDelete_Click(object sender, EventArgs e)
        {
            Table a = new Table();
            int ID = a.deleteTable();
            foreach(Button item in flp.Controls)
            {
                if(Convert.ToInt32(item.Tag)==ID)
                {
                    flp.Controls.Remove(item);
                }
            }
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            flp.Controls.Clear();
            createButton();
        }

        private void btCheck_Click(object sender, EventArgs e)
        {
            CheckingDish frm = new CheckingDish();
            frm.Show();
        }
    }
}
