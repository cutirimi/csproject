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
        SelectType st = new SelectType();

        public UserLogin()
        {
            InitializeComponent();
            Admin.FileOutput();
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
            string logname = lognametb.Text;
            string logpw = logpwtb.Text;

            bool login = Admin.FindUser(logname, logpw);

            if (login)
            {
                MessageBox.Show(logname + "님 환영합니다.");
                Admin.savename = logname;
                this.Hide();
                st.Show();
            }
            else
            {
                MessageBox.Show("아이디 혹은 비밀번호가 일치하지않습니다.\n 다시 입력해주세요.");
            }
        }
    }
}