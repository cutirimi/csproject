using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace project
{
    public partial class MachineSelect : Form
    {
        List<Machine> machines = new List<Machine>();       //컬렉션
        Machine selectedMachine = null;
        Admin admin = new Admin();

        public MachineSelect()
        {
            InitializeComponent();
        }

        private void MachineSelect_Load(object sender, EventArgs e)
        {
            // MachineState.txt 텍스트파일을 읽고 자판기 타입들을 리스트 형태로 저장
            List<string> machineStateList = FileUtil.FindMachineTypesByMachineFile();       //컬렉션
            Machine tempMachine = null;     //Machine 클래스의 인스턴스를 저장하기 위한 임시 인스턴스
            int index = 1;

            // machineState가 machineStateList에 들어있는만큼 foreach문 반복
            foreach (string machineState in machineStateList)
            {
                if (machineState != null)       //자판기가 존재하면
                {
                    // 구분자 :로 나누어 문자열 배열로 할당
                    // machineInfo[0]은 자판기 타입
                    // machineInfo[1]은 해당 자판기의 음료 품목
                    string[] machineInfo = machineState.Split(':');

                    if (machineInfo[0] == "cold")       //차가운 음료 자판기일 경우
                    {
                        // ColdMachine의 인스턴스를 생성하고 자판기의 음료품목을 매개변수로 전달
                        tempMachine = new ColdMachine(machineInfo[1]);
                    }
                    else if (machineInfo[0] == "hot")       //뜨거운 음료 자판기일 경우
                    {
                        // HotMachine의 인스턴스를 생성하고 자판기의 음료품목을 매개변수로 전달
                        tempMachine = new HotMachine(machineInfo[1]);
                    }

                    // 위에서 생성된 자판기 인스턴스를 리스트에 추가
                    machines.Add(tempMachine);
                    machineListBox.Items.Add("자판기 " + index++);     //자판기 이름 지정
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PurchaseItem(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PurchaseItem(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PurchaseItem(3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PurchaseItem(4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PurchaseItem(5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            PurchaseItem(6);
        }

        private void machineListBox_MouseClick(object sender, MouseEventArgs e)
        {
            int selectedIndex = machineListBox.SelectedIndex;

            this.selectedMachine = machines[selectedIndex];

            Render();
        }

        private void Render()       //자판기 text설정
        {
            int selectedIndex = machineListBox.SelectedIndex;

            List<Label> textDrinkList = new List<Label>() { txtdrink1, txtdrink2, txtdrink3, txtdrink4, txtdrink5, txtdrink6 };     //컬렉션
            List<Label> textPriceList = new List<Label>() { txtprice1, txtprice2, txtprice3, txtprice4, txtprice5, txtprice6 };     //컬렉션

            for (int i = 0; i < textDrinkList.Count; i++)
            {
                if (i < selectedMachine.items.Count)
                {
                    if (selectedMachine.items[i].DrinkName != null && selectedMachine.items[i].Price != null)
                    {
                        textDrinkList[i].Text = selectedMachine.items[i].DrinkName;
                        textPriceList[i].Text = selectedMachine.items[i].Price;
                    }
                }
                else
                {
                    textDrinkList[i].Text = "비어있음";
                    textPriceList[i].Text = "";
                }
            }

            FileUtil.StoreMachineStateByIndex(selectedIndex + 1, selectedMachine);
        }

        private void PurchaseItem(int itemIndex)       //재고 감소
        {
            try
            {
                selectedMachine.PurchaseItem(itemIndex);
                MessageBox.Show("구매완료");
                Render();
            }
            catch (CustomException ex)            //예외처리
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }
    }
}
