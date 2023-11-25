using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static project.MainForm;

namespace project
{
    public partial class UserPageForm : Form
    {
        UserAddForm ua = new UserAddForm();
        ColdMachine cd= new ColdMachine();
        HotMachine hd = new HotMachine();
        private Admin admin=Admin.GetInstance();

        public UserPageForm()
        {
            InitializeComponent();
        }

        private void modifybtn_Click(object sender, EventArgs e)
        {
            if (admin.MachineType=="cold")
            {
                ColdModify cm = new ColdModify();
                cm.Show();
            }
            else if(admin.MachineType =="hot")
            {
                HotModify hm = new HotModify();
                hm.Show();
            }
            //ColdModify md = new ColdModify();     //수정전
            //md.Show();
            //this.Hide();
            this.Hide();
        }

        private void UserPage_Load(object sender, EventArgs e)
        {
            label1.Text = admin.AdminName+ "님 페이지";

            label1.Font = new Font(label1.Font, FontStyle.Bold | FontStyle.Underline);      //폰트 굵기와 밑줄 설정
            label1.Font = new Font(label1.Font.FontFamily, 14);     //폰트 크기 설정
        }
    }
}