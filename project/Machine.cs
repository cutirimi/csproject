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
        public string item;       //음료 품목
        public string price;       //가격
        public int cnt;        //음료 수량(재고)
        //int index;
        abstract public bool Stock();       //재고
    }

    public class HotDrink : Machine        //파생 클래스로 뜨거운 음료 클래스
    {
        public int water;       //물(L)
        public HotDrink() { }       //기본 생성자
        public HotDrink(string name = "뜨거운 음료 자판기")     //자판기 이름을 넘겨받아 이름 설정하는 매개변수가 하나인 생성자
        {
            this.name = name;
            cnt = 15;       //음료 재고는 기본 15개로 처리
            water = 20;     //뜨거운 물 기본 20L
        }
        override public bool Stock()        //재고
        {
            if(water < 1 || cnt < 3)     //물이 1L 미만이거나 재고가 3개 미만이면 false 리턴 -> 자판기 사용 불가능
            {
                return false;
            }
            else        //true반환 -> 자판기 사용 가능
            {
                return true;
            }
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
        public override bool Stock()
        {
            if(cnt >= 3)      //음료 재고가 3개 이상 남으면 true반환 -> 자판기 사용 가능
            {
                return true;
            }
            else        //음료 재고가 3개 미만으로 남으면 false반환 -> 자판기 사용 불가능
            {
                return false;
            }
        }
    }
}
