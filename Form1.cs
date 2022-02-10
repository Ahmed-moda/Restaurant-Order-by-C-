using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string receipt,date;
        public double test;
        public string[] products = new string[18];
        public double[] price = new double[18];
        public double[] temp=new double[18];
        public double res;


        private void Reset_text()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Text="0";
                    else
                        func(control.Controls);
            };

            func(Controls);
        }

        private string check(string text)
        {
            if (String.IsNullOrEmpty(text))
                return "0";

            return text;
        }

        private void tmp()
        {
            t1.Text = "0";
            t2.Text = "0";
            t3.Text = "0";
            t4.Text = "0";
            t5.Text = "0";
            t6.Text = "0";
            t7.Text = "0";
            t8.Text = "0";
            t9.Text = "0";
            t10.Text = "0";
            t11.Text = "0";
            t12.Text = "0";
            t13.Text = "0";
            t14.Text = "0";
            t15.Text = "0";
            t16.Text = "0";
            t17.Text = "0";
            t18.Text = "0";
            price[0] = 10.5;
            price[1] = 23;
            price[2] = 8;
            price[3] = 25;
            price[4] = 29;
            price[5] = 18;
            price[6] = 19.5;
            price[7] = 17.5;
            price[8] = 30;
            price[9] = 3;
            price[10] =5;
            price[11] = 15;
            price[12] = 8;
            price[13] = 13;
            price[14] = 8;
            price[15] = 10;
            price[16] = 8;
            price[17] = 22;
            products[0] = "Pizza";
            products[1] = "Burger";
            products[2] = "Salad";
            products[3] = "Checken Sandwich";
            products[4] = "Fish Sandwich";
            products[5] = "Checken Salad";
            products[6] = "Pasta";
            products[7] = "Mashrom";
            products[8] = "Steak";
            products[9] = "Tea";
            products[10] = "Coffe";
            products[11] = "Lemon";
            products[12] = "Mint";
            products[13] = "Moka";
            products[14] = "Ice Coffe";
            products[15] = "Cola";
            products[16] = "Orange";
            products[17] = "Mango";


        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Label24_Click(object sender, EventArgs e)
        {

        }

        private void Label23_Click(object sender, EventArgs e)
        {

        }

        private void Label21_Click(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            DialogResult ex;
            ex = MessageBox.Show("Are You Want To Exit The System", "Order", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ex == DialogResult.Yes)
                Application.Exit();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Reset_text();
            t_name.Text = "";
            t_address.Text = "";
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            

        }

        private void TextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

        }

        private void TextBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void TextBox26_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
            
            res = 0;
            temp[0]=  Convert.ToDouble(check(t1.Text)) * price[0];
            temp[1] = Convert.ToDouble(check(t2.Text)) * price[1];
            temp[2] = Convert.ToDouble(check(t3.Text)) * price[2];
            temp[3] = Convert.ToDouble(check(t4.Text)) * price[3];
            temp[4] = Convert.ToDouble(check(t5.Text)) * price[4];
            temp[5] = Convert.ToDouble(check(t6.Text)) * price[5];
            temp[6] = Convert.ToDouble(check(t7.Text)) * price[6];
            temp[7] = Convert.ToDouble(check(t8.Text)) * price[7];
            temp[8] = Convert.ToDouble(check(t9.Text)) * price[8];
            temp[9] = Convert.ToDouble(check(t10.Text)) * price[9];
            temp[10] = Convert.ToDouble(check(t11.Text)) * price[10];
            temp[11] = Convert.ToDouble(check(t12.Text)) * price[11];
            temp[12] = Convert.ToDouble(check(t13.Text)) * price[12];
            temp[13] = Convert.ToDouble(check(t14.Text)) * price[13];
            temp[14] = Convert.ToDouble(check(t15.Text)) * price[14];
            temp[15] = Convert.ToDouble(check(t16.Text)) * price[15];
            temp[16] = Convert.ToDouble(check(t17.Text)) * price[16];
            temp[17] = Convert.ToDouble(check(t18.Text)) * price[17];


            for(int i = 0; i < 18; i++)
            {
                res += temp[i];
            }
            t_cost.Text = Convert.ToString(res);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tmp();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(t_address.Text)|| String.IsNullOrEmpty(t_name.Text))
                MessageBox.Show("Please Enter the Name and Adress", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            else if(t_cost.Text=="0"||t_cost.Text=="")
                MessageBox.Show("Please Choose the Order", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            else
            {
                date = DateTime.Now.ToString("M/d/yyyy");
                receipt ="Date: "+date+"\n"+ "Name: " + t_name.Text + "\n" + "the Adress: " + t_address.Text+"\n"+"Cost: "+t_cost.Text+"\n";
                for (int i = 0; i < 18; i++)
                {

                    if (temp[i] > 0)
                    {
                        test = temp[i] / price[i];
                        receipt += Convert.ToString(test) + " " + products[i] +"   "+temp[i]+ "\n";
                    }

                }
                MessageBox.Show(receipt, "Order", MessageBoxButtons.OKCancel, MessageBoxIcon.None);
            }
                
        }
    }
}
