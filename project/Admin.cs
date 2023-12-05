using System.Collections.Generic;

namespace project
{
    public class Admin
    {
        private int index;      //자판기에게 번호 부여
        public string AdminName { get; set; }     //프로퍼티
        private Machine machine;        //Machine 타입의 인스턴스
        private static Admin staticAdmin;       //Admin 타입의 인스턴스
        public static Admin GetInstance()       //싱글톤
        {
            if (staticAdmin == null)        //Admin 인스터턴스가 생성되지 않았으면
            {
                staticAdmin = new Admin();      //Admin 인스턴스 생성
            }
            return staticAdmin;     //Admin 인스턴스 리턴
        }

        public string GetMachineType()      //자판기 타입 반환
        {
            // Machine 타입의 인스턴스를 통해 GetMachineType메소드 호출
            return machine.GetMachineType();
        }

        public void SetMachine(int index)       //자판기 상태 설정
        {
            // 지정된 인덱스에 해당하는 자판기 상태 정보를 파일에서 읽어와 문자열 형태로 저장
            string machineState = FileUtil.GetMachineStateByIndex(index);

            if (machineState != null)       //읽어온 해당 자판기가 null이 아닌 경우
            {
                // index를 매개변수로 주어진 값으로 설정되며 현재 작업중인 자판기의 인덱스를 나타냄
                this.index = index;
                //구분자 :로 분리. machineInfo[0]은 자판기 타입을 나타냄
                string[] machineInfo = machineState.Split(':');

                if (machineInfo[0] == "cold")       //파일에 쓰인 자판기 타입이 cold일 경우
                {
                    this.machine = new ColdMachine(machineInfo[1]);     //ColdMachine 인스턴스 생성
                }
                else if (machineInfo[0] == "hot")       //파일에 쓰인 자판기 타입이 hot일 경우
                {
                    this.machine = new HotMachine(machineInfo[1]);      //HotMachine 인스턴스 생성
                }
            }
        }
        public void AddItem(string item, string price, string stock)        //음료, 가격, 재고 추가
        {
            // 자판기의 타입이 hot일 경우(뜨거운 음료 자판기일 경우)
            if (machine.GetMachineType() == "hot")
            {
                // 매개변수 세개로 HotItem의 인스턴스 초기화
                HotItem hotItem = new HotItem(item, price, stock);
                // Machine타입의 인스턴스를 통해 자판기에 뜨거운 음료 아이템 추가
                machine.AddItem(hotItem);
            }

            // 자판기의 타입이 cold일 경우(차가운 음료 자판기일 경우)
            else if (machine.GetMachineType() == "cold")
            {
                // 매개변수 세개로 ColdItem의 인스턴스 초기화
                ColdItem coldItem = new ColdItem(item, price, stock);
                // Machine타입의 인스턴스를 통해 자판기에 차가운 음료 아이템 추가
                machine.AddItem(coldItem);
            }
        }
        public void RemoveItem(int index)     //삭제
        {
            // Machine타입의 인스턴스를 통해 해당하는 인덱스의 음료 품목 삭제
            machine.RemoveItem(index);
        }

        public List<Item> GetItemList()     //컬렉션
        {
            // Machine타입의 인스턴스를 통해 해당하는 자판기의 음료 품목 리스트를 반환
            return machine.items;
        }

        public void SaveMachine()       //자판기 상태 불러오기 위한 메소드
        {
            // 현재 선택된 자판기의 상태를 MachineState.txt 파일에 저장
            FileUtil.StoreMachineStateByIndex(index, machine);
        }
    }
}
