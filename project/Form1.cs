using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    
    public partial class Form1 : Form
    {
        UserLogin login = new UserLogin();

        public class Machine
        {
            public string name;     //자판기명
            public string[] drink;      //음료 품목
            public int[] price;     //음료 가격
            public Machine() { }
        }
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void 자판기1ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Machine machine1 = new Machine();
            DrinkMachine fm2 = new DrinkMachine();
            machine1.name = "자판기1";
            fm2.Text = machine1.name;
            fm2.Show();
        }

        private void 자판기2ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Machine machine2 = new Machine();
            Form3 fm3 = new Form3();
            machine2.name = "자판기2"; ;
            fm3.Text = machine2.name;
            fm3.Show();
        }

        private void 로그인ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login.Show();
        }
    }
}
