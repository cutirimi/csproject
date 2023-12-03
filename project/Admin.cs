using System.Collections.Generic;

namespace project
{
    public class Admin
    {
        private int index;
        private Machine machine;
        private static Admin staticAdmin;
        public static Admin GetInstance()       //싱글톤
        {
            if (staticAdmin == null)
            {
                staticAdmin = new Admin();
            }
            return staticAdmin;
        }

        public string AdminName { get; set; }     //관리자이름

        public string GetMachineType()      //자판기 타입 반환
        {
            return machine.GetMachineType();
        }

        public void SetMachine(int index)
        {
            string machineState = FileUtil.GetMachineStateByIndex(index);
            if (machineState != null)
            {
                this.index = index;
                string[] machineInfo = machineState.Split(':');
                if (machineInfo[0] == "cold")
                {
                    this.machine = new ColdMachine(machineInfo[1]);
                }
                else if (machineInfo[0] == "hot")
                {
                    this.machine = new HotMachine(machineInfo[1]);
                }
            }
        }
        public void AddItem(string item, string price, string stock)        //음료, 가격, 재고 추가
        {
            if (machine.GetMachineType() == "hot")      //뜨거운 자판기
            {
                HotItem hotItem = new HotItem(item, price, stock);
                machine.AddItem(hotItem);
            }

            else if (machine.GetMachineType() == "cold")        //차가운 자판기
            {
                ColdItem coldItem = new ColdItem(item, price, stock);
                machine.AddItem(coldItem);
            }
        }
        public void RemoveItem(int index)     //삭제
        {
            machine.RemoveItem(index);
        }

        public List<Item> GetItemList()
        {
            return machine.items;
        }

        public void SaveMachine()
        {
            FileUtil.StoreMachineStateByIndex(index, machine);
        }
    }
}
