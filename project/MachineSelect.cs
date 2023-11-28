using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace project
{
    public partial class MachineSelect : Form
    {
        private Admin admin = Admin.GetInstance();
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

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            MessageBox.Show("구매완료");
        }
    }
}
