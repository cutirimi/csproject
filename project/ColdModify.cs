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

namespace project
{
    public partial class ColdModify : Form
    {
        ColdDrink cd = new ColdDrink();
        UserPage up = new UserPage();
        ColdItem ci = new ColdItem();

        public ColdModify()
        {
            InitializeComponent();
        }


        public void FormClear()
        {
            itemtb.Clear();
        }

        public void AddDrinkToListView()     //리스트에 Machine정보 추가
        {
            //for (int i = 0; i < ci.DrinkName.Count; i++)
            //{
            //    ListViewItem lvi = new ListViewItem(new[] { ci.DrinkName[i], ci.Price[i], ci.Stock[i].ToString() });

            //    drinklist.Items.Add(lvi);
            //}
        }

        private void adderbtn_Click(object sender, EventArgs e)
        {
            // ListView에 음료 추가 로직 추가
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            // ListView에서 음료 삭제 로직 추가
        }

        private void Modify_Load(object sender, EventArgs e)
        {
            // Modify 폼이 로드될 때의 추가 로직
            //st.Hide();
        }

        private void movebtn_Click(object sender, EventArgs e)
        {
            up.Show();
            this.Close();
        }
    }

}
