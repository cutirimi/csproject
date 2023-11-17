using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    public abstract class Machine       //베이스 클래스
    {
        public string name;        //자판기 이름
        public string drink;       //음료 품목
        public string price;       //가격
        public int cnt;        //음료 수량(재고)
        int index;
        abstract public string temperature();       //온도
    }

    public class HotDrink : Machine        //파생 클래스로 뜨거운 음료 클래스
    {
        public HotDrink() { }       //기본 생성자
        public HotDrink(string name = "뜨거운 음료 자판기")     //자판기 이름을 넘겨받아 이름 설정하는 매개변수가 하나인 생성자
        {
            this.name = name;
            cnt = 15;       //음료 재고는 기본 15개로 처리
        }
        override public string temperature()        //온도
        {
            return "hot";
        }

    }

    public class ColdDrink : Machine       //차가운 음료
    {
        public ColdDrink() { }
        public ColdDrink(string name = "차가운 음료 자판기")
        {
            this.name = name;
            cnt = 15;
        }
        public override string temperature()
        {
            return "cold";
        }
    }
}
