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
            this.Hide();
            // loginForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //machineSelect.ShowDialog();
            machineSelect.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
