using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace project
{
    public partial class UserPageForm : Form
    {
        private Admin admin = Admin.GetInstance();
        Modify modify = new Modify();

        public UserPageForm()
        {
            InitializeComponent();
        }

        private void modifybtn_Click(object sender, EventArgs e)
        {
            modify.Show();
            this.Close();
        }

        private void UserPage_Load(object sender, EventArgs e)
        {
            RenderInfoList();

            ListViewItem lvi = new ListViewItem();

            label1.Text = admin.AdminName + "님 페이지";

            string stockText = admin.GetMachineType() == "hot" ? "재고(g)" : "재고(개)";

            drinkInfoList.Columns[2].Text = stockText;

            label1.Font = new Font(label1.Font, FontStyle.Bold | FontStyle.Underline);      //폰트 굵기와 밑줄 설정
            label1.Font = new Font(label1.Font.FontFamily, 14);     //폰트 크기 설정
        }

        private void RenderInfoList()
        {
            List<Item> itemList = admin.GetItemList();

            foreach (Item item in itemList)
            {
                ListViewItem lvi = new ListViewItem(item.DrinkName);
                lvi.SubItems.Add(item.Price);
                lvi.SubItems.Add(item.Stock);
                drinkInfoList.Items.Add(lvi);
            }
        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }
    }
}