using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    public class Admin
    {
        private Machine machine;
        private static Admin staticAdmin;
        public static Admin GetInstance()
        {
            if (staticAdmin == null)
            {
                staticAdmin = new Admin();
            }
            return staticAdmin;
        }

        public string AdminName { get; set; }     //관리자이름
        public string MachineType { get; set; }     //자판기 타입

        public void SetMachine(int index)
        {
            string machineState = FileUtil.GetMachineStateByIndex(index);
            if (machineState != null)
            {
                string[] machineInfo = machineState.Split(':');
                if (machineInfo[0] == "cold" && machineInfo[1].Length != 0)
                {
                    this.machine = new ColdMachine();

                    string[] items = machineInfo[1].Split('$');
                    for (int i = 0; i < items.Length; i++)
                    {
                        Item item = new ColdItem(items[i]);
                        this.machine.AddItem(item);
                    }

                }
                else if (machineInfo[0] == "hot" && machineInfo[1].Length != 0)
                {

                }
            }
            else
            {

            }


        }
    }
}
