using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    public abstract class Machine
    {
        public abstract void Drinkinfo(int index);
        public abstract string Pricest(int index);
    }

    class Machine1 : Machine
    {
        public string name;        //자판기 이름
        public string[] drink;     //음료
        public string[] price;     //음료 가격
        public int index = 0;
        public Machine1() { name = "자판기1"; Drinkinfo(index); }
        public override void Drinkinfo(int index)
        {
            this.drink = new string[] { "코카콜라", "펩시", "갈아만든배", "오렌지주스", "포도주스", "생수", "토레타", "포카리", "옥수수수염차" };
            this.price = new string[] { "1800", "1800", "1000", "800", "800", "1000", "2000", "1200", "2000" };
        }
        public override string Pricest(int index)
        {
            return price[index] + "원";
        }
    }

    class Machine2 : Machine
    {
        public string name;        //자판기 이름
        public string[] drink;     //음료
        public string[] price;     //음료 가격
        public int index = 0;
        public Machine2() { name = "자판기2"; Drinkinfo(index); }
        public override void Drinkinfo(int index)
        {
            //사이다, 봉봉, 사과주스, 초코에몽으로 수정
            this.drink = new string[] { "사이다", "펩시", "봉봉", "사과주스", "포도주스", "생수", "토레타", "초코에몽", "옥수수수염차" };
            this.price = new string[] { "1200", "1800", "1000", "800", "800", "1000", "2000", "1200", "2000" };
        }
        public override string Pricest(int index)
        {
            return price[index] + "원";
        }
    }
}
