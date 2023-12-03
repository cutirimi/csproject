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

            if (drinklist.Items.Count >= 6)
            {
                addbtn.Enabled = false;
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

            if (drinklist.Items.Count < 6)
            {
                addbtn.Enabled = true;
            }
            else
            {
                addbtn.Enabled = false;

            }
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            string drinkName = itemtb.Text;
            string price = pricetb.Text;
            string stock = stocktb.Text;

            try
            {
                if (admin.GetMachineType() == "hot")
                {
                    if (int.Parse(stock) < 50)
                    {
                        throw new CustomException("최소 50g 이상 넣어주세요.");
                    }
                }
                else if (admin.GetMachineType() == "cold")
                {
                    if (int.Parse(stock) > 15)
                    {
                        throw new CustomException("재고는 최대 15개까지입니다.");
                    }
                }

                admin.AddItem(drinkName, price, stock);     //예외가 발생하지 않았을 때만 항목 추가
                ClearForm();
                RenderDrinkList();

                if (drinklist.Items.Count < 6)
                {
                    addbtn.Enabled = true;
                }
                else
                {
                    addbtn.Enabled = false;
                }
            }
            catch (CustomException ex)
            {
                MessageBox.Show(ex.Message);
            }
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
