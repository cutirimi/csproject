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
        ColdDrink cd=new ColdDrink();
        HotDrink hd = new HotDrink();

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
            string machineType = radioButton1.Checked ? "cold" : "hot";
            if (password == pwcon)
            {

                MessageBox.Show("등록이 완료되었습니다.");
                Admin.FileInput(name , password, machineType);
                this.Hide();
            }
            else
            {
                MessageBox.Show("비밀번호와 비밀번호 확인이 일치하지않습니다.");
            }
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
    }
}