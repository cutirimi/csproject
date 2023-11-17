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
    public partial class UserPage : Form
    {
        UserAdd ua = new UserAdd();

        public UserPage()
        {
            InitializeComponent();  
        }

        private void modifybtn_Click(object sender, EventArgs e)
        {
            Modify md = new Modify();
            md.Show();
        }

        private void UserPage_Load(object sender, EventArgs e)
        {
            label1.Text = Admin.Name + "님 페이지";
            label1.Font = new Font(label1.Font, FontStyle.Bold | FontStyle.Underline);      //폰트 굵기와 밑줄 설정
            label1.Font = new Font(label1.Font.FontFamily, 14);     //폰트 크기 설정
        }
    }
}
