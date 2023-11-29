using System;
using System.Windows.Forms;

namespace project
{

    public partial class MainForm : Form
    {
        LoginForm loginForm = new LoginForm();
        MachineSelect machineSelect = new MachineSelect();

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
            machineSelect.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
