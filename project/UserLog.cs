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
        LoginClass log=new LoginClass();
        UserAdd add = new UserAdd();
        UserPage page = new UserPage();

        public UserLog()
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
            bool match = true;

            for (int i = 0; i < 2; i++)
            {
                if (lognametb.Text== log.Name/*add.getName()*/ && logpwtb.Text== log.Password/*add.getPassword()*/)
                {
                    match = true;
                }
                else
                {
                    match = false;
                }
            }
            if(match==true)
            {
                MessageBox.Show(log.Name/*add.getName()*/ + "님 환영합니다.");
                this.Hide();
                page.Show();
            }
            else if(match==false)
            {
                MessageBox.Show("아이디 혹은 비밀번호가 일치하지않습니다.\n 다시 입력해주세요.");
            }
        }
    }
}