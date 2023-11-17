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
        
        public UserAdd()
        {
            InitializeComponent();
        }

        private void UserAdd_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin.Name = nametb.Text;
            Admin.Password = passwordtb.Text;
            Admin.Pwcon = pwcontb.Text;

            if (Admin.Password == Admin.Pwcon)
            {
                MessageBox.Show("등록이 완료되었습니다.");
                this.Hide();
            }
            else
            {
                MessageBox.Show("비밀번호와 비밀번호 확인이 일치하지않습니다.");
            }
        }

        private void hotdrinkbtn_Click(object sender, EventArgs e)
        {
            HotDrink hd = new HotDrink();
            MessageBox.Show("뜨거운 음료 자판기로 설정되었습니다.");
        }

        private void colddrinkbtn_Click(object sender, EventArgs e)
        {
            ColdDrink cd = new ColdDrink();
            MessageBox.Show("차가운 음료 자판기로 설정되었습니다.");
        }
    }
}