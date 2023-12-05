namespace project
{
    abstract public class Item      //추상클래스
    {
        public string DrinkName { get; set; }       //음료명 프로퍼티
        public string Price { get; set; }       //가격 프로퍼티
        public string Stock { get; set; }       //재고 프로퍼티
        public Item() { }

        // 음료명, 가격, 재고를 초기화하는 생성자
        public Item(string drinkName, string price, string stock)
        {
            DrinkName = drinkName;
            Price = price;
            Stock = stock;
        }

        public Item(string unsplitedItem)
        {
            // 구분자 #를 사용하여 음료명, 가격, 재고를 순서대로 문자열 형태로 할당
            string[] split = unsplitedItem.Split('#');
            DrinkName = split[0];
            Price = split[1];
            Stock = split[2];
        }
    }

    class HotItem : Item        //Item 클래스를 상속받는 파생클래스
    {
        public HotItem() { }

        // 베이스클래스의 생성자 호출
        public HotItem(string drinkName, string price, string stock) : base(drinkName, price, stock) { }

        // 베이스클래스의 생성자 호출
        public HotItem(string unsplitedItem) : base(unsplitedItem) { }

        // 재고 감소 연산자 중복
        public static HotItem operator -(HotItem item, int amount)
        {
            int stock = int.Parse(item.Stock);      //재고가 string 형태이므로 int형태로 변환

            if (stock > 0)      //재고가 0 초과이면 아래 수행
            {
                // 뜨거운 음료는 재고가 50씩 감소 -> amount는 50을 받음
                stock -= amount;
                item.Stock = stock.ToString();      //재고를 string형태로 변환
            }
            else        //재고가 없으면 예외처리
            {
                throw new CustomException("재고없음");
            }

            return item;
        }
    }
    class ColdItem : Item        //Item 클래스를 상속받는 파생클래스
    {
        public ColdItem() { }

        // 베이스클래스의 생성자 호출
        public ColdItem(string drinkName, string price, string stock) : base(drinkName, price, stock) { }

        // 베이스클래스의 생성자 호출
        public ColdItem(string unsplitedItem) : base(unsplitedItem) { }

        // 재고 감소 연산자 중복
        public static ColdItem operator -(ColdItem item, int amount)
        {
            int stock = int.Parse(item.Stock);      //재고가 string 형태이므로 int형태로 변환

            if (stock > 0)      //재고가 0 초과이면 아래 수행
            {
                // 차가운 음료는 재고가 1씩 감소 -> amount는 1을 받음
                stock -= amount;
                item.Stock = stock.ToString();      //재고를 string형태로 변환
            }
            else        //재고가 없으면 예외처리
            {
                throw new CustomException("재고없음");
            }

            return item;
        }
    }
}
