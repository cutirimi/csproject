using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace project
{
    public partial class UserLogin : Form
    {
        UserAdd add = new UserAdd();
        UserPage page = new UserPage();

        public UserLogin()
        {
            InitializeComponent();
            
        }

        private void UserLog_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            add.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lognametb.Text == Admin.Name && logpwtb.Text == Admin.Password)
            {
                MessageBox.Show(Admin.Name + "님 환영합니다.");
                this.Hide();
                page.Show();
            }
            else
            {
                MessageBox.Show("아이디 혹은 비밀번호가 일치하지않습니다.\n 다시 입력해주세요.");
            }
        }
    }
}