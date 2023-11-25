using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace project
{
    public partial class UserAddForm : Form
    {
        private Admin admin = Admin.GetInstance();

        public UserAddForm()
        {
            InitializeComponent();
        }

        private void UserAdd_Load(object sender, EventArgs e)
        {
            nametb.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            signup();
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            radioButton2.Checked = false;
            radioButton1.Checked = true;
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            radioButton2.Checked = true;
        }

        private void signup()
        {
            string name = nametb.Text;
            string password = passwordtb.Text;
            string pwcon = pwcontb.Text;
            string machineType = radioButton1.Checked ? "cold" : "hot";

            //password에서 특수문자 $ 사용 불가능 -> $를 구분자로 사용
            if (password == pwcon)
            {

                MessageBox.Show("등록이 완료되었습니다.");
                FileUtil.signup(name, password , machineType);
                //admin.FileInput(name, password, machineType);
                this.Hide();
            }
            else
            {
                MessageBox.Show("비밀번호와 비밀번호 확인이 일치하지않습니다.");
            }
        }
    }
}