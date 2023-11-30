using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace project
{
    public partial class MachineSelect : Form
    {
        public MachineSelect()
        {
            InitializeComponent();
        }

        private void MachineSelect_Load(object sender, EventArgs e)
        {
            List<string> machineTypes = FileUtil.FindMachineTypesByMachineFile();

            foreach (string machineType in machineTypes)
            {
                machineListBox.Items.Add(machineType);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtdrink1.Text = txtdrinkselect.Text;
            txtprice1.Text = txtpriceselect.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtdrink2.Text = txtdrinkselect.Text;
            txtprice2.Text = txtpriceselect.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtdrink3.Text = txtdrinkselect.Text;
            txtprice3.Text = txtpriceselect.Text;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtdrink4.Text = txtdrinkselect.Text;
            txtprice4.Text = txtpriceselect.Text;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtdrink5.Text = txtdrinkselect.Text;
            txtprice5.Text = txtpriceselect.Text;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtdrink6.Text = txtdrinkselect.Text;
            txtprice6.Text = txtpriceselect.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            MessageBox.Show("구매완료");
        }

        private void machineListBox_MouseClick(object sender, MouseEventArgs e)
        {
            List<string> machineDrinks = FileUtil.FindDrinksByMachineFile();
            List<string> text = new List<string>() { txtdrink1.Text, txtdrink2.Text, txtdrink3.Text, txtdrink4.Text, txtdrink5.Text, txtdrink6.Text };

            text = machineDrinks;
        }
    }
}
