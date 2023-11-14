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
    public partial class UserAdd : Form
    {
        public string getName()
        {
            return nametb.Text;
        }
        public string getPassword()
        {
            return passwordtb.Text;
        }
        public UserAdd()
        {
            InitializeComponent();

        }

        public string UpdateUser()
        {
            UserAdd ua = new UserAdd();
            string updatename;
            updatename = ua.nametb.Text;
            return updatename;
        }

        private void UserAdd_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginClass[] person = new LoginClass[2];        //등록된 사용자2명

            bool pwmatch = true;

            for (int i = 0; i < 2; i++)
            {
                person[i] = new LoginClass(); // 각 요소에 새로운 LoginClass 인스턴스 생성

                person[i].Name = nametb.Text;
                person[i].Password = passwordtb.Text;
                person[i].Pwcon = pwcontb.Text;

                if (person[i].Password == person[i].Pwcon)
                {
                    pwmatch = true;

                }
                else
                {
                    pwmatch = false;
                }
            }
            if (pwmatch == true)
            {
                MessageBox.Show("등록이 완료되었습니다.");
                this.Hide();
            }
            else if (pwmatch == false)
            {
                MessageBox.Show("비밀번호와 비밀번호 확인이 일치하지않습니다.");
            }
        }
    }
}