using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ĐồÁnGiaiĐoạn1
{
    public partial class CheckingDish : Form
    {
        public CheckingDish()
        {
            InitializeComponent();
        }

        private void CheckingDish_Load(object sender, EventArgs e)
        {
            Bill a = new Bill();
            List<Bill> trendinglist = new List<Bill>();
            trendinglist = a.gettrendingfood();
            dataGridView1.DataSource = trendinglist;
            comboBox1.DataSource = trendinglist;
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Name";
            Ingredient lol = new Ingredient();
            List<Ingredient> list = new List<Ingredient>();
            list=lol.GetIngredientsbyName(comboBox1.Text);
            foreach(Ingredient item in list)
            {
                label2.Text = item.I1;
                label3.Text = item.I2;
                label4.Text = item.I3;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Ingredient lol = new Ingredient();
                List<Ingredient> list = new List<Ingredient>();
                list = lol.GetIngredientsbyName(comboBox1.Text);
                foreach (Ingredient item in list)
                {
                    label2.Text = item.I1;
                    label3.Text = item.I2;
                    label4.Text = item.I3;
                }
            }
            catch
            {
                MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btCaculate_Click(object sender, EventArgs e)
        {
            if (tbQ1.Text == "" || tbQ2.Text == "" || tbQ3.Text == "")
            {
                MessageBox.Show("Blank is not allowed", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                
                try
                {
                    double q1 = Convert.ToDouble(tbQ1.Text);
                    double q2 = Convert.ToDouble(tbQ2.Text);
                    double q3 = Convert.ToDouble(tbQ3.Text);
                    double max1;
                    double max2;
                    double max3;
                    double max4;
                    double max5;
                    double max6;
                    double e1;
                    Ingredient lol = new Ingredient();
                    List<Ingredient> list = new List<Ingredient>();
                    list = lol.GetIngredientsbyName(comboBox1.Text);
                    foreach (Ingredient item in list)
                    {
                        if (comboBox2.Text == "gam")
                        {
                            max1 = (double)q1 / item.Q1;
                            max4 = (int)q1 % item.Q1;
                        }
                        else
                        {
                            max1 = (double)(q1*1000) / item.Q1;
                            max4 = (int)(q1) % item.Q1;
                        }
                        if (comboBox2.Text == "gam")
                        {
                            max2 = (double)q2 / item.Q2;
                            max5 = (int)q2 % item.Q2;
                        }
                        else
                        {
                            max2 = (double)(q2 * 1000) / item.Q1;
                            max5 = (int)(q2) % item.Q2;
                        }
                        if (comboBox2.Text == "gam")
                        {
                            max3 = (double)q3 / item.Q3;
                            max6 = (int)q3 % item.Q3;
                        }
                        else
                        {
                            max3 = (double)(q3 * 1000) / item.Q1;
                            max6 = (int)(q3) % item.Q3;
                        }
                        e1 = timmin(max1, max2, max3);
                        tbQ.Text = (Math.Truncate(e1)).ToString();
                        double error = ((double)(max4 + max5 + max6) / (q1 + q2 + q3))*100;
                        tbError.Text = error.ToString();
                    }
                   
                }
                catch
                {
                    MessageBox.Show("Invalid input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public double timmin(double a, double b ,double c)
        {
            double min;
            min = a;
            if (min > b)
                min = b;
            if (min > c)
                min = c;
            return min;
        }
    }
}
