using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;
using project;

namespace project
{
    public partial class Form3 : Form
    {
        Machine2 machine2 = new Machine2();

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            button10.Visible = false;

            txtdrink1.Text = machine2.drink[0];
            txtprice1.Text = machine2.price[0];
            txtdrink2.Text = machine2.drink[1];
            txtprice2.Text = machine2.price[1];
            txtdrink3.Text = machine2.drink[2];
            txtprice3.Text = machine2.price[2];
            txtdrink4.Text = machine2.drink[3];
            txtprice4.Text = machine2.price[3];
            txtdrink5.Text = machine2.drink[4];
            txtprice5.Text = machine2.price[4];
            txtdrink6.Text = machine2.drink[5];
            txtprice6.Text = machine2.price[5];
            txtdrink7.Text = machine2.drink[6];
            txtprice7.Text = machine2.price[6];
            txtdrink8.Text = machine2.drink[7];
            txtprice8.Text = machine2.price[7];
            txtdrink9.Text = machine2.drink[8];
            txtprice9.Text = machine2.price[8];
        }
        protected void selectedindex(int index)
        {
            if (index >= 0 && index < machine2.drink.Count)
            {
                txtdrinkselect.Text = machine2.drink[index];
                txtpriceselect.Text = machine2.price[index];
            }
            button10.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            selectedindex(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            selectedindex(1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            selectedindex(2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            selectedindex(3);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            selectedindex(4);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            selectedindex(5);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            selectedindex(6);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            selectedindex(7);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            selectedindex(8);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            MessageBox.Show("정상 구매");
            this.Close();
        }
    }
}