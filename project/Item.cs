namespace project
{
    abstract public class Item
    {
        public Item() { }
        public Item(string drinkName, string price, string stock)
        {
            DrinkName = drinkName;
            Price = price;
            Stock = stock;
        }
        public Item(string unsplitedItem)
        {
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
        public HotItem(string drinkName, string price, string stock) : base(drinkName, price, stock) { }
        public HotItem(string unsplitedItem) : base(unsplitedItem)
        {
        }
    }
    class ColdItem : Item
    {
        public ColdItem(string drinkName, string price, string stock) : base(drinkName, price, stock) { }

        public ColdItem(string unsplitedItem) : base(unsplitedItem)
        {
        }
    }
}
