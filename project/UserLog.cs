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
        UserAdd add = new UserAdd();

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
            Confirm cf = new Confirm();
            bool match = true;
            for (int i = 0; i < 2; i++)
            {
                if (lognametb.Text== add.getName() && logpwtb.Text== add.getPassword())
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
                MessageBox.Show(add.getName() + "님 환영합니다.");
                this.Hide();
                cf.Show();
            }
            else if(match==false)
            {
                MessageBox.Show("아이디 혹은 비밀번호가 일치하지않습니다.\n 다시 입력해주세요.");
            }
        }
    }
}