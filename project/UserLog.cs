using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace project
{
    public partial class UserLog : Form
    {
        public UserLog()
        {
            InitializeComponent();
        }

        private void UserLog_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserAdd add= new UserAdd();
            add.Show();
        }
    }
}
