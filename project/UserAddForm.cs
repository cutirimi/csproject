using System;
using System.Windows.Forms;

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

            if (password == pwcon)      //비밀번호와 비밀번호가 일치한 경우
            {
                MessageBox.Show("등록이 완료되었습니다.");
                // Admin.txt파일에 관리자명, 비밀번호를 쓰고, MachineState.txt파일에 자판기타입을 쓴다.
                FileUtil.signup(name, password, machineType);
                this.Hide();
            }
            else
            {
                MessageBox.Show("비밀번호와 비밀번호 확인이 일치하지않습니다.");
            }
        }
    }
}