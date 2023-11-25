using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace project
{
    public partial class Modify : Form
    {
        private Admin admin = Admin.GetInstance();

        private void ClearForm()
        {
            itemtb.Clear();
            pricetb.Clear();
            stocktb.Clear();
            itemtb.Focus();
        }
        public void AddItem(Item item)
        {
            string[] items = new string[] { item.DrinkName, item.Price, item.Stock };
            ListViewItem lvi = new ListViewItem(items);
            drinklist.Items.Add(lvi);
            drinklist.EndUpdate();
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
            if (drinklist.SelectedItems.Count > 0)
            {
                drinklist.Items.Remove(drinklist.SelectedItems[0]);
            }
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

        private void drinklist_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (drinklist.SelectedItems.Count > 0)
            {
                itemtb.Text = drinklist.SelectedItems[0].SubItems[0].Text;
                pricetb.Text = drinklist.SelectedItems[0].SubItems[1].Text;
                stocktb.Text = drinklist.SelectedItems[0].SubItems[2].Text;
            }
            ClearForm();
        }

        private void RenderDrinkList()
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
