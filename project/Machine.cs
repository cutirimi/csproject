using System.Collections.Generic;

namespace project
{
    public abstract class Machine       //베이스클래스
    {
        public List<Item> items;

        public Machine()
        {
            items = new List<Item>();
        }
        public void AddItem(Item item) { items.Add(item); }
        public void RemoveItem() { }
        public abstract string GetMachineType();

    }

    public class HotMachine : Machine     //뜨거운 음료 클래스
    {
        public override string GetMachineType()
        {
            return "hot";
        }
    }

    public class ColdMachine : Machine        //차가운 음료 클래스
    {
        public override string GetMachineType()
        {
            return "cold";
        }
    }
}
