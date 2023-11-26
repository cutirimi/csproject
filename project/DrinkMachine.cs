using System;
using System.Windows.Forms;

namespace project
{
    public partial class DrinkMachine : Form
    {
        Machine1 machine1 = new Machine1();

        public DrinkMachine()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            button10.Visible = false;

            txtdrink1.Text = machine1.drink[0];
            txtprice1.Text = machine1.price[0];
            txtdrink2.Text = machine1.drink[1];
            txtprice2.Text = machine1.price[1];
            txtdrink3.Text = machine1.drink[2];
            txtprice3.Text = machine1.price[2];
            txtdrink4.Text = machine1.drink[3];
            txtprice4.Text = machine1.price[3];
            txtdrink5.Text = machine1.drink[4];
            txtprice5.Text = machine1.price[4];
            txtdrink6.Text = machine1.drink[5];
            txtprice6.Text = machine1.price[5];
        }
        protected void selectedindex(int index)
        {
            if (index >= 0 && index < machine1.drink.Count)
            {
                txtdrinkselect.Text = machine1.drink[index];
                txtpriceselect.Text = machine1.price[index];
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