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
            MessageBox.Show("구매완료");
            txtpriceselect.Text = "";
            txtdrinkselect.Text = "";
        }

        private void machineListBox_MouseClick(object sender, MouseEventArgs e)
        {
            int selectedIndex = machineListBox.SelectedIndex;

            this.selectedMachine = machines[selectedIndex];
            Render();
        }

        private void Render()
        {
            List<Label> textList = new List<Label>() { txtdrink1, txtdrink2, txtdrink3, txtdrink4, txtdrink5, txtdrink6 };
            List<Label> textPriceList = new List<Label>() { txtprice1, txtprice2, txtprice3, txtprice4, txtprice5, txtprice6 };

            for (int i = 0; i < selectedMachine.items.Count; i++)
            {
                if (selectedMachine.items[i].DrinkName != null && selectedMachine.items[i].Price != null)
                {
                    textList[i].Text = selectedMachine.items[i].DrinkName;
                    textPriceList[i].Text = selectedMachine.items[i].Price;
                }
                else
                {
                    textList[i].Text = "비어있음";
                    textPriceList[i].Text = "비어있음";
                    button10.Enabled = false;
                }
            }
        }
    }
}
