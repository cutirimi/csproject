﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace project
{
    public partial class LoginForm : Form
    {
        UserAddForm userAddForm = new UserAddForm();
        UserPageForm userPageFrom = new UserPageForm();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            userAddForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            login();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            lognametb.Focus();
        }

        private void logpwtb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                login();
            }
        }

        private void login()
        {
            string logname = lognametb.Text;
            string logpw = logpwtb.Text;

            bool login = Admin.FindUser(logname, logpw);

            if (login == true)
            {
                MessageBox.Show(logname + "님 환영합니다.");
                this.Hide();
                userPageFrom.Show();
            }
            else
            {
                MessageBox.Show("아이디 혹은 비밀번호가 일치하지않습니다.\n 다시 입력해주세요.");
            }
        }
    }
}