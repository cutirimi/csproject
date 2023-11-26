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

            List<string> adminNames = FindAdminNamesByAdminFile();

            foreach (string adminName in adminNames)
            {
                coldMachinecb.Items.Add(adminName);
                hotMachinecb.Items.Add(adminName);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DrinkMachine drinkMachine = new DrinkMachine();
            drinkMachine.Show();
            this.Close();
        }

        private List<string> FindAdminNamesByAdminFile()
        {
            List<string> adminNames = new List<string>();

            FileStream fs = File.OpenRead("Admin.txt");
            StreamReader sr = new StreamReader(fs);

            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                string[] userInfo = line.Split('$');

                if (userInfo.Length >= 1 && !string.IsNullOrWhiteSpace(userInfo[0]))
                {
                    adminNames.Add(userInfo[0]);
                }
            }
            sr.Close();
            fs.Close();

            return adminNames;
        }
    }
}
