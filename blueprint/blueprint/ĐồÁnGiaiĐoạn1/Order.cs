using GlobalVariables;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ĐồÁnGiaiĐoạn1
{
    public partial class Order : Form
    {
        public Order()
        {
            InitializeComponent();
        }

        private void Order_Load(object sender, EventArgs e)
        {
            Dish a = new Dish();
            List<Dish> k = a.LoadTable();
            dataGridView1.DataSource = k;
            cbName.DataSource = k;
            cbName.DisplayMember = "Name";
            cbName.ValueMember = "Price";
        }
        public int dishid = 1;
        public int total = 0;
        private void btAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string name = cbName.Text.ToString();
                int quantity = Convert.ToInt32(cbTotal.Text);
                int price = Convert.ToInt32(cbName.SelectedValue) * quantity;
                total += price;
                Bill a = new Bill(price, name, quantity);
                //Listview
                ListViewItem k = new ListViewItem();
                k.Text = dishid.ToString();
                k.SubItems.Add(name);
                k.SubItems.Add(quantity.ToString());
                k.SubItems.Add(price.ToString());
                listView1.Items.Add(k);
                dishid++;
                
            }
            catch
            {
                MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btRemove_Click(object sender, EventArgs e)
        {
            try
            {
                int l = listView1.Items.Count;
                //MessageBox.Show(l.ToString());
                foreach (ListViewItem item in listView1.Items)
                {
                    if (Convert.ToInt32(item.Text) == l)
                    {
                        listView1.Items.RemoveAt(l - 1);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cbName.SelectedValue = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            cbTotalPeopel.Text = "0";
            tbTotal.Text = "";
            Close();
        }

        private void btSettlement_Click(object sender, EventArgs e)
        {
            tbTotal.Text = total.ToString();
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btConfirm_Click(object sender, EventArgs e)
        {
            //total peopel
            if (cbTotalPeopel.Text == "")
            {
                MessageBox.Show("Blank is not allowed", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                //listview
                List<Bill> listfoods = new List<Bill>();
                Bill a = new Bill();
                //MessageBox.Show(a.getbillid().ToString());
                int BillId = a.getbillid();
                int tableId = Globals.GlobalInt;
                // MessageBox.Show(tableId.ToString());
                DateTime dateCheckout = dateTimePicker1.Value;
                foreach (ListViewItem item in listView1.Items)
                {
                    string name = item.SubItems[1].Text;
                    int quantity = Convert.ToInt32(item.SubItems[2].Text);
                    int price = Convert.ToInt32(item.SubItems[3].Text);
                    Dish temp = new Dish(quantity, name);
                    temp.updatedish(temp);
                    Bill food = new Bill(BillId, tableId, name, price, quantity, dateCheckout, total);
                    listfoods.Add(food);
                }
                a.addBill(listfoods);
                if (listfoods.Count!=0)
                {
                    Globals.SetNumbleOfpeople(Convert.ToInt32(cbTotalPeopel.Text));
                    Close();
                }
                //update food status 
                //List<Bill> update = new List<Bill>();
                //update = a.getlistbills();
                //foreach(Bill item in update)
                //{
                //    Dish temp = new Dish(item.Quantity, item.Name);
                //    temp.updatedish(temp);
                //}
            }
        }

        private void btCheckout_Click(object sender, EventArgs e)
        {

        }

        private void btFD_Click(object sender, EventArgs e)
        {
            Dish a = new Dish();
            List<Dish> k = a.LoadTable();
            dataGridView1.DataSource = k;
        }

        private void btTD_Click(object sender, EventArgs e)
        {
            Bill a = new Bill();
            List<Bill> trendinglist = new List<Bill>();
            trendinglist= a.gettrendingfood();
            dataGridView1.DataSource = trendinglist;
        }
    }
}
