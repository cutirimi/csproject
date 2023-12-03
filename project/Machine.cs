using System.Collections.Generic;

namespace project
{
    public abstract class Machine       //추상클래스. 베이스클래스
    {
        public List<Item> items;

        public Machine()
        {
            items = new List<Item>();
        }
        public Machine(string machineInfo) { }
        public void AddItem(Item item) { items.Add(item); }
        public void RemoveItem(int index) { items.RemoveAt(index); }
        public abstract string GetMachineType();
        public abstract void PurchaseItem(int index);
    }

    public class HotMachine : Machine     //뜨거운 음료 클래스
    {
        public HotMachine(string machineInfo)
        {
            if (machineInfo.Length != 0)
            {
                string[] items = machineInfo.Split('$');
                for (int i = 0; i < items.Length; i++)
                {
                    Item item = new HotItem(items[i]);
                    this.AddItem(item);
                }
            }
        }
        public override string GetMachineType()
        {
            return "hot";
        }
        public override void PurchaseItem(int index)
        {
            if (index > items.Count)
            {
                throw new CustomException("물품이 없습니다.");
            }

            HotItem selectedItem = (HotItem)items[index - 1];
            selectedItem -= 50;
        }
    }

    public class ColdMachine : Machine        //차가운 음료 클래스
    {
        public ColdMachine(string machineInfo)
        {
            if (machineInfo.Length != 0)
            {
                string[] items = machineInfo.Split('$');
                for (int i = 0; i < items.Length; i++)
                {
                    Item item = new ColdItem(items[i]);
                    this.AddItem(item);
                }
            }
        }
        public override string GetMachineType()
        {
            return "cold";
        }
        public override void PurchaseItem(int index)
        {
            if (index > items.Count)
            {
                throw new CustomException("물품이 없습니다.");
            }

            ColdItem selectedItem = (ColdItem)items[index - 1];
            selectedItem -= 1;
        }
    }
}
