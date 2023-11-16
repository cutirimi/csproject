using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    abstract class Machine
    {
        string name;
        List<string> drinks;
        List<string> price;
        int index;
        public void AddItem(string drinkname)
        { 
            drinks.Add(drinkname);
        }
        public void RemoveItem(int index)
        {
            drinks.RemoveAt(index);
        }
        abstract public string temperature();       //온도
    }

    class HotDrink : Machine        //뜨거운 음료
    {
        public string name;
        public List<string> drinks;
        public List<string> price;
        public int index = 0;
        override public string temperature()
        {
            return "hot";
        }

    }

    class ColdDrink : Machine       //차가운 음료
    {
        public string name;
        public List<string> drinks;
        public List<string> price;
        public int index = 0;
        public override string temperature()
        {
            return "cold";
        }
    }
}
