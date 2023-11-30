using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace project
{
    public partial class Modify : Form
    {
        private Admin admin = Admin.GetInstance();
        Machine machine;

        private void ClearForm()
        {
            itemtb.Clear();
            pricetb.Clear();
            stocktb.Clear();
            itemtb.Focus();
        }

        public Modify()
        {
            InitializeComponent();
        }

        private void Modify_Load(object sender, EventArgs e)
        {
            string machinetype = admin.GetMachineType();

            if (machinetype == "hot")
            {
                machinetypetb.Text = "뜨거운 음료 자판기";
            }
            else if (machinetype == "cold")
            {
                machinetypetb.Text = "차가운 음료 자판기";
            }
            ClearForm();
            RenderDrinkList();

            if (drinklist.Items.Count == 6)
            {
                MessageBox.Show("더이상 추가하실 수 없습니다.");
                addbtn.Enabled = false;
                return;
            }
        }

        private void movebtn_Click(object sender, EventArgs e)
        {
            UserPageForm userPageForm = new UserPageForm();
            userPageForm.Show();
            admin.SaveMachine();
            this.Close();

        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            admin.RemoveItem(drinklist.SelectedItems[0].Index);
            RenderDrinkList();
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            string drinkName = itemtb.Text;
            string price = pricetb.Text;
            string stock = stocktb.Text;

            admin.AddItem(drinkName, price, stock);

            ClearForm();
            RenderDrinkList();
        }

        public void RenderDrinkList()
        {
            drinklist.Items.Clear();
            List<Item> itemList = admin.GetItemList();

            foreach (Item item in itemList)
            {
                ListViewItem lvi = new ListViewItem(item.DrinkName);
                lvi.SubItems.Add(item.Price);
                lvi.SubItems.Add(item.Stock);
                drinklist.Items.Add(lvi);
            }
            drinklist.EndUpdate();
        }
    }
}
