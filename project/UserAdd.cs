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
    public partial class UserAdd : Form
    {
        public UserAdd()
        {
            InitializeComponent();
        }

        private void UserAdd_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = nametb.Text;
            string password = passwordtb.Text;
            string pwcon = pwcontb.Text;

            if (password == pwcon)
            {
                Admin.Name.Add(name);
                Admin.Password.Add(password);

                MessageBox.Show("등록이 완료되었습니다.");
                Admin.FileInput();
                this.Hide();
            }
            else
            {
                MessageBox.Show("비밀번호와 비밀번호 확인이 일치하지않습니다.");
            }
        }
    }
}