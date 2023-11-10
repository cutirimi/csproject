using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static project.Form1;
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
            label3.Text = machine2.drink[machine2.index];
            label12.Text = machine2.Pricest(machine2.index);
        }

        private void button1_Click(object sender, EventArgs e)      //사이다
        {
            label1.Text = label3.Text;
            label21.Text = label12.Text;
            button10.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)      //펩시
        {

        }
    }
}
