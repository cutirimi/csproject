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
            Form2 fm2 = new Form2();
            fm2.Text = machine1.name;
            fm2.Show();
        }

        private void 자판기2ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Machine machine2 = new Machine();
            Form2 fm2 = new Form2();
            fm2.Text = machine2.name;
            fm2.Show();
        }

        private void 로그인ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            LoginMainForm logfm = new LoginMainForm();
            logfm.Show();
        }

        private void 관리ToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void 확인ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Confirm cfm = new Confirm();
            cfm.Show();
        }

        private void 로그인ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //관리자명단ToolStripMenuItem.Visible = false;
        }
    }
}
