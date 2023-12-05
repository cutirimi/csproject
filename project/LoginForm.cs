using System;
using System.Windows.Forms;

namespace project
{
    public partial class LoginForm : Form
    {
        UserAddForm userAddForm = new UserAddForm();
        UserPageForm userPageFrom = new UserPageForm();
        private Admin admin = Admin.GetInstance();

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
            // <Enter>키를 누르면 login() 메소드 호출
            if (e.KeyChar == (char)Keys.Enter)
            {
                login();
            }
        }

        // 로그인시, 관리자명과 비밀번호를 Admin.txt 텍스트파일에 쓰는 메소드
        private void login()
        {
            string logname = lognametb.Text;
            string logpw = logpwtb.Text;

            // 관리자명과 비밀번호를 FileUtil클래스의 FindMachineIndexByUser메소드의 매개변수로 전달
            // 해당 관리자의 순서를 반환한 것을 index에 저장
            int index = FileUtil.FindMachineIndexByUser(logname, logpw);

            // Admin.txt 텍스트파일에 관리자가 저장되어있을 경우(로그인 성공한 경우)
            if (index != 0)
            {
                // Admin 클래스의 인스턴스의 AdminName에 폼에서 작성한 관리자명을 저장
                admin.AdminName = logname;
                // 해당 관리자의 순서를 매개변수로 자판기 상태 설정 메소드 호출
                admin.SetMachine(index);
                MessageBox.Show(logname + "님 환영합니다.");
                this.Hide();
                userPageFrom.Show();
            }
            else        //로그인 실패한 경우
            {
                MessageBox.Show("아이디 혹은 비밀번호가 일치하지않습니다.\n 다시 입력해주세요.");
            }
        }
    }
}