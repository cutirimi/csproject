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
        public HotItem() { }
        public HotItem(string drinkName, string price, string stock) : base(drinkName, price, stock) { }
        public HotItem(string unsplitedItem) : base(unsplitedItem) { }
        public static HotItem operator -(HotItem item, int amount)
        {
            int stock = int.Parse(item.Stock);

            if (stock > 0)
            {
                stock -= amount;
                item.Stock = stock.ToString();
            }
            else
            {
                throw new CustomException("재고없음");
            }

            return item;
        }
    }
    class ColdItem : Item
    {
        public ColdItem() { }
        public ColdItem(string drinkName, string price, string stock) : base(drinkName, price, stock) { }

        public ColdItem(string unsplitedItem) : base(unsplitedItem) { }
        public static ColdItem operator -(ColdItem item, int amount)
        {
            int stock = int.Parse(item.Stock);

            if (stock > 0)
            {
                stock -= amount;
                item.Stock = stock.ToString();
            }
            else
            {
                throw new CustomException("재고없음");
            }

            return item;
        }
    }
}
