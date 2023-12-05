using System.Collections.Generic;

namespace project
{
    public abstract class Machine       //추상클래스
    {
        // 음료 품목들을 모아서 한번에 관리하기 위한 리스트
        public List<Item> items;        //컬렉션

        public Machine()
        {
            items = new List<Item>();
        }
        public Machine(string machineInfo)
        {
            items = new List<Item>();
        }
        // Items리스트를 통해 아이템을 아이템 목록을 추가
        public void AddItem(Item item) { items.Add(item); }
        // 해당 인덱스의 아이템 목록을 삭제
        public void RemoveItem(int index) { items.RemoveAt(index); }
        // 자판기 타입을 문자열로 리턴
        public abstract string GetMachineType();
        // 해당 인덱스의 음료를 구매하면 자판기 타입에 따라 재고 감소
        public abstract void PurchaseItem(int index);
    }

    public class HotMachine : Machine     //뜨거운 음료 자판기 클래스
    {
        public HotMachine(string machineInfo)
        {
            if (machineInfo.Length != 0)        //음료품목들이 null 아닐 경우
            {
                // $로 음료 품목 구분 ex)음료명1#가격1#재고1$음료명2#가격2#재고2
                string[] items = machineInfo.Split('$');
                for (int i = 0; i < items.Length; i++)      //자판기에 각 음료품목 추가
                {
                    // ex)음료명#가격#재고 형태로 자판기에 추가
                    Item item = new HotItem(items[i]);
                    this.AddItem(item);
                }
            }
        }
        public override string GetMachineType()     //자판기 타입 문자열형태인 "hot" 반환
        {
            return "hot";
        }
        public override void PurchaseItem(int index)        //특정 음료 구매할때 호출
        {
            if (index > items.Count)        //해당 인덱스의 음료가 없으면 예외처리
            {
                throw new CustomException("물품이 없습니다.");
            }

            // 연산자 중복
            HotItem selectedItem = (HotItem)items[index - 1];
            selectedItem -= 50;     //선택된 음료의 재고 50 감소
        }
    }

    public class ColdMachine : Machine        //차가운 음료 자판기 클래스
    {
        public ColdMachine(string machineInfo)
        {
            if (machineInfo.Length != 0)        //음료품목들이 null 아닐 경우
            {
                // $로 음료 품목 구분 ex)음료명1#가격1#재고1$음료명2#가격2#재고2
                string[] items = machineInfo.Split('$');
                for (int i = 0; i < items.Length; i++)      //자판기에 각 음료품목 추가
                {
                    // ex)음료명#가격#재고 형태로 자판기에 추가
                    Item item = new ColdItem(items[i]);
                    this.AddItem(item);
                }
            }
        }
        public override string GetMachineType()     //자판기 타입 문자열형태인 "cold" 반환
        {
            return "cold";
        }
        public override void PurchaseItem(int index)        //특정 음료 구매할때 호출
        {
            if (index > items.Count)        //해당 인덱스의 음료가 없으면 예외처리
            {
                throw new CustomException("물품이 없습니다.");
            }

            // 연산자 중복
            ColdItem selectedItem = (ColdItem)items[index - 1];
            selectedItem -= 1;     //선택된 음료의 재고 1 감소
        }
    }
}
