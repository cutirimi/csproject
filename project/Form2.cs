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
    public partial class Form2 : Form
    {
        Machine1 machine1 = new Machine1();

        public Form2()
        {
            InitializeComponent();
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            button10.Visible = false;

            label3.Text = machine1.drink[machine1.index];
            label12.Text = machine1.Pricest(machine1.index);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = label3.Text;
            label21.Text = label12.Text;
            button10.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = label4.Text;
            label21.Text = label13.Text;
            button10.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = label5.Text;
            label21.Text = label14.Text;
            button10.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = label6.Text;
            label21.Text = label15.Text;
            button10.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text = label7.Text;
            label21.Text = label16.Text;
            button10.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label1.Text = label8.Text;
            label21.Text = label17.Text;
            button10.Visible = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label1.Text = label9.Text;
            label21.Text = label18.Text;
            button10.Visible = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label1.Text = label10.Text;
            label21.Text = label19.Text;
            button10.Visible = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label1.Text = label11.Text;
            label21.Text = label20.Text;
            button10.Visible = true;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            MessageBox.Show("정상 구매");
        }
    }
}