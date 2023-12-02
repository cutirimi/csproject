using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace project
{
    public partial class MachineSelect : Form
    {
        List<Machine> machines = new List<Machine>();
        Machine selectedMachine = null;

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
            txtdrinkselect.Text = txtdrink1.Text;
            txtpriceselect.Text = txtprice1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtdrinkselect.Text = txtdrink2.Text;
            txtpriceselect.Text = txtprice2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtdrinkselect.Text = txtdrink3.Text;
            txtpriceselect.Text = txtprice3.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtdrinkselect.Text = txtdrink4.Text;
            txtpriceselect.Text = txtprice4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtdrinkselect.Text = txtdrink5.Text;
            txtpriceselect.Text = txtprice5.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtdrinkselect.Text = txtdrink6.Text;
            txtpriceselect.Text = txtprice6.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (txtpriceselect.Text == "")
            {
                MessageBox.Show("선택하실 수 없습니다.");
            }
            else
            {
                MessageBox.Show("구매완료");
            }

            stockCheck();

            txtpriceselect.Text = "";
            txtdrinkselect.Text = "";
        }

        private void machineListBox_MouseClick(object sender, MouseEventArgs e)
        {
            int selectedIndex = machineListBox.SelectedIndex;

            this.selectedMachine = machines[selectedIndex];

            Render();
        }

        private void Render()       //자판기 text설정
        {
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
        }

        private void stockCheck()       //재고 감소
        {
            int selectedIndex = machineListBox.SelectedIndex;

            if (selectedIndex >= 0 && selectedIndex < selectedMachine.items.Count)
            {
                Item selectedItem = selectedMachine.items[selectedIndex];
                int currentStock = Convert.ToInt32(selectedItem.Stock);

                if (currentStock > 0)
                {
                    if (currentStock > 50)
                    {
                        currentStock -= 50;
                    }
                    else
                    {
                        currentStock--;
                    }
                    selectedItem.Stock = currentStock.ToString();       //변경된 재고 업데이트
                    FileUtil.StoreMachineStateByIndex(selectedIndex + 1, selectedMachine);      //변경된 상태 저장
                }
                else
                {
                    MessageBox.Show("재고가 부족합니다.");
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }
    }
}
