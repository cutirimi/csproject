using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public abstract class Machine
    {
        public string Name { get; set; }     //자판기 이름 프로퍼티
        public List<string> drink;      //음료 품목 -> 동적
        public List<string> price;      //음료 가격
        int index = 0;      //품목 개수
        public abstract void AddDrink(string drinkName, string price, int index);       //음료 추가
        public abstract void RemoveDrink(int index);        //음료 삭제
    }

    class Machine1 : Machine
    {
        public Machine1()
        {
            Name = "자판기1";
            drink = new List<string>() { "코카콜라", "펩시", "갈아만든배", "오렌지주스", "포도주스", "생수", "토레타", "포카리", "옥수수수염차"};
            price = new List<string>() { "1800원", "1800원", "1000원", "800원", "800원", "1000원", "2000원", "1200원", "2000원"};
        }

        override public void AddDrink(string drinkName, string drinkPrice, int index)       //음료 추가 AddDrink메소드
        {
            if(index<9)
            {
                drink.Add(drinkName);
                price.Add(drinkPrice);
            }
            else
            {
                MessageBox.Show("음료 추가 불가능");
            }
        }

        override public void RemoveDrink(int index)     //음료 삭제 RemoveDrink메소드
        {
            if (index >= 0 && index < 9)
            {
                drink.RemoveAt(index);
                price.RemoveAt(index);
            }
            else
            {
                MessageBox.Show("음료 품목 삭제 불가능");
            }
        }
    }


    class Machine2 : Machine
    {
        public Machine2()
        {
            Name = "자판기2";
            drink = new List<string>();
            price = new List<string>();
            drink = new List<string>() { "사이다", "펩시", "봉봉", "사과주스", "포도주스", "생수", "토레타", "초코에몽", "옥수수수염차" };
            price = new List<string>() { "1200원", "1800원", "800원", "800원", "800원", "1000원", "2000원", "1200원", "2000원" };
        }

        override public void AddDrink(string drinkName, string drinkPrice, int index)       //음료 추가 AddDrink메소드
        {
            if (index < 9)
            {
                drink.Add(drinkName);
                price.Add(drinkPrice);
            }
            else
            {
                MessageBox.Show("음료 추가 불가능");
            }
        }

        override public void RemoveDrink(int index)     //음료 삭제 RemoveDrink메소드
        {
            if (index >= 0 && index < 9)
            {
                drink.RemoveAt(index);
                price.RemoveAt(index);
            }
            else
            {
                MessageBox.Show("음료 품목 삭제 불가능");
            }
        }
    }
}
