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
            try
            {
                // 리스트박스의 항목이 6개를 초과할 경우 CustomException 발생시켜 사용자 정의 예외 발생
                if (drinkInfoList.Items.Count >= 6)
                {
                    throw new CustomException("더이상 추가하실 수 없습니다.");
                }
            }
            catch (CustomException ex)      //예외처리
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                modify.Show();
                this.Close();
            }
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
            // Admin클래스의 인스턴스를 통해 로그인된 관리자의 음료품목들을 들고옴
            List<Item> itemList = admin.GetItemList();

            // 음료품목을 음료품목리스트에 들어가있는 만큼 반복하는 foreach문
            foreach (Item item in itemList)
            {
                // ListView에 DrinkName, Price, Stock 추가
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