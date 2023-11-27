using System;
using System.Collections.Generic;
using System.IO;
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            hotMachinecb.Enabled = false;
        }

        private void hotMachinecb_SelectedIndexChanged(object sender, EventArgs e)
        {
            coldMachinecb.Enabled = false;
        }

        private void MachineSelect_Load(object sender, EventArgs e)
        {
            coldMachinecb.Items.Clear();
            hotMachinecb.Items.Clear();

            List<string> machineTypes = FindMachineTypesByMachineFile();

            foreach (string machineType in machineTypes)
            {
                if (machineType.Contains("차가운"))
                {
                    coldMachinecb.Items.Add(machineType);
                }
                else if (machineType.Contains("뜨거운"))
                {
                    hotMachinecb.Items.Add(machineType);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DrinkMachine drinkMachine = new DrinkMachine();
            drinkMachine.Show();
            this.Close();
        }

        private List<string> FindMachineTypesByMachineFile()        //MachineState텍스트 파일에서 자판기 타입 읽고, 콤보박스에 들어갈 내용 리스트 형태로 저장
        {
            List<string> machinesTypes = new List<string>();

            FileStream fs = File.OpenRead("MachineState.txt");
            StreamReader sr = new StreamReader(fs);

            int coldCount = 1;
            int hotCount = 1;

            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                string[] machineType = line.Split(':');

                if (machineType.Length >= 1 && !string.IsNullOrWhiteSpace(machineType[0]))
                {
                    if (machineType[0] == "cold")
                    {
                        machinesTypes.Add("차가운 음료 자판기" + coldCount);
                        coldCount++;
                    }
                    else if (machineType[0] == "hot")
                    {
                        machinesTypes.Add("뜨거운 음료 자판기" + hotCount);
                        hotCount++;
                    }
                }
            }
            sr.Close();
            fs.Close();

            return machinesTypes;
        }
    }
}
