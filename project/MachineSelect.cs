using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace project
{
    public partial class MachineSelect : Form
    {
        List<Machine> machines = new List<Machine>();
        Machine selectedMachine = null;
        Admin admin = new Admin();

        public MachineSelect()
        {
            InitializeComponent();
        }

        private void MachineSelect_Load(object sender, EventArgs e)
        {
            List<string> machineStateList = FileUtil.FindMachineTypesByMachineFile();
            Machine tempMachine = null;
            int index = 1;
            foreach (string machineState in machineStateList)
            {
                if (machineState != null)
                {
                    string[] machineInfo = machineState.Split(':');
                    if (machineInfo[0] == "cold")
                    {
                        tempMachine = new ColdMachine(machineInfo[1]);
                    }
                    else if (machineInfo[0] == "hot")
                    {
                        tempMachine = new HotMachine(machineInfo[1]);
                    }
                    machines.Add(tempMachine);
                    machineListBox.Items.Add("자판기 " + index++);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            PurchaseItem(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PurchaseItem(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PurchaseItem(3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PurchaseItem(4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PurchaseItem(5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            PurchaseItem(6);
        }

        private void machineListBox_MouseClick(object sender, MouseEventArgs e)
        {
            int selectedIndex = machineListBox.SelectedIndex;

            this.selectedMachine = machines[selectedIndex];

            Render();
        }

        private void Render()       //자판기 text설정
        {
            int selectedIndex = machineListBox.SelectedIndex;

            List<Label> textDrinkList = new List<Label>() { txtdrink1, txtdrink2, txtdrink3, txtdrink4, txtdrink5, txtdrink6 };
            List<Label> textPriceList = new List<Label>() { txtprice1, txtprice2, txtprice3, txtprice4, txtprice5, txtprice6 };

            for (int i = 0; i < textDrinkList.Count; i++)
            {
                if (i < selectedMachine.items.Count)
                {
                    if (selectedMachine.items[i].DrinkName != null && selectedMachine.items[i].Price != null)
                    {
                        textDrinkList[i].Text = selectedMachine.items[i].DrinkName;
                        textPriceList[i].Text = selectedMachine.items[i].Price;
                    }
                }
                else
                {
                    textDrinkList[i].Text = "비어있음";
                    textPriceList[i].Text = "";
                }
            }

            FileUtil.StoreMachineStateByIndex(selectedIndex + 1, selectedMachine);
        }

        private void PurchaseItem(int itemIndex)       //재고 감소
        {
            try
            {
                selectedMachine.PurchaseItem(itemIndex);
                MessageBox.Show("구매완료");
                Render();
            }
            catch (CustomException ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

        private void MachineSelect_FormClosing(object sender, FormClosingEventArgs e)
        {
            //MainForm mainForm = new MainForm();
            //mainForm.Show();
            Application.Exit();
        }
    }
}
