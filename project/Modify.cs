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
    public partial class Modify : Form
    {
        HotDrink hotdrink=new HotDrink();
        ColdDrink colddrink = new ColdDrink();

        public void FormClear()     //버튼 클릭시 drinktb 클리어시키는 용도로 사용
        {
            drinktb.Clear();
        }

        public void AddHotdrink(HotDrink hotdrink)
        {
            string[] items = new string[] { hotdrink.name, hotdrink.drink, hotdrink.price };
            int save = hotdrink.cnt;
            ListViewItem lvi = new ListViewItem(items);
            drinklist.Items.Add(lvi);
        }

        public void AddColddrink(ColdDrink colddrink)
        {
            string[] items = new string[] { colddrink.name, colddrink.drink, colddrink.price };
            int save = colddrink.cnt;
        }

        public Modify()
        {
            InitializeComponent();
        }

        private void adderbtn_Click(object sender, EventArgs e)
        {
            if(drinktb.Text!="")
            {
                drinklist.Items.Add(drinktb.Text);
                drinktb.Text = "";
            }
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            if(drinklist.SelectedIndex>-1)
            {
                drinklist.Items.RemoveAt(drinklist.SelectedIndex);
            }
        }

        private void Modify_Load(object sender, EventArgs e)
        {

        }
    }
}
