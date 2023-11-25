using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace project
{
    abstract public class Item
    {

        public Item(string unsplitedItem) {
            string[] split = unsplitedItem.Split('#');
            DrinkName = split[0];
            Price = split[1];
            Stock = split[2];
        }

        public string DrinkName { get; set; }
        public string Price { get; set; }
        public string Stock { get; set; }
 
    }

    class HotItem : Item
    {
        public HotItem(string unsplitedItem) : base(unsplitedItem)
        {
        }
    }
    class ColdItem : Item
    {
        public ColdItem(string unsplitedItem) : base(unsplitedItem)
        {
        }
    }
}
