using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace project
{
    public abstract class Machine       //베이스클래스
    {
        protected List<Item> items;
        public abstract void AddItem(Item item);
        public abstract void RemoveItem();
        public abstract void Modify();

    }

    public class HotMachine : Machine     //뜨거운 음료 클래스
    {
        public HotMachine()
        {
            this.items = new List<Item>();
        }

        public override void AddItem(Item item)
        {
        }

        public override void Modify()
        {
        }

        public override void RemoveItem()
        {
        }
    }

    public class ColdMachine : Machine        //차가운 음료 클래스
    {
        public override void AddItem(Item item)
        {
        }

        public override void Modify()
        {
        }

        public override void RemoveItem()
        {
        }
    }
}
