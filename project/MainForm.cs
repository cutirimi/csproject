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
    
    public partial class MainForm : Form
    {
        LoginForm loginForm = new LoginForm();

        public MainForm()
        {
            InitializeComponent();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            loginForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //사용자 폼 만들고 기능 추가
        }
    }
}
