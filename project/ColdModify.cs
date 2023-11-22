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
        SelectType st = new SelectType();
        ColdDrink cd = new ColdDrink();
        UserPage up = new UserPage();
        string type = "cold";

        public ColdModify()
        {
            InitializeComponent();
        }


        public void FormClear()
        {
            itemtb.Clear();
        }

        public void AddDrinkToListView(Machine machine)     //리스트에 Machine정보 추가
        {
            for (int i = 0; i < machine.item.Count; i++)
            {
                ListViewItem lvi = new ListViewItem(new[] { machine.item[i], machine.price[i], machine.cnt[i].ToString() });

                drinklist.Items.Add(lvi);
            }
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
            st.Hide();
        }

        private void movebtn_Click(object sender, EventArgs e)
        {
            up.Show();
            this.Close();
        }
    }

}
