using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace project
{
    abstract public class Item
    {
        //public string DrinkName { get; set; }
        //public string Price { get; set; }
        //public string Stock { get; set; }
        public List<string> DrinkName { get; set; } = new List<string>();       //음료명 ex) 코카콜라, 펩시, 핫초코, 율무차
        public List<string> Price { get; set; } = new List<string>();       //가격
        public int Water { get; set; }      //물 - g단위
        public List<int> Stock { get; set; } = new List<int>();       //재고(뜨거운 자판기 - g단위, 차가운 자판기 - 개수)

        //public void DrinkFileInput(string item, string price, string stock)        //파일쓰기
        //{
        //    StreamWriter st = null;
        //    try
        //    {
        //        FileStream file = new FileStream("Machine_State.txt", FileMode.Append);       //../../Admin.txt
        //        st = new StreamWriter(file, System.Text.Encoding.Default);
        //        st.WriteLine("자판기종류: " + Admin.MachineType + " / " + "{음료품목: " + item + ", 가격: " + item + ", 재고: " + stock + "}");
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine("파일을 쓰는 중 오류가 발생했습니다: " + ex.Message);
        //    }
        //    finally
        //    {
        //        if (st != null)
        //        {
        //            st.Close();
        //        }
        //    }


            //StreamWriter st = null;
            //try
            //{
            //    FileStream file = new FileStream("Machine_state.txt", FileMode.Append);
            //    st = new StreamWriter(file, System.Text.Encoding.Default);

            //    int finalindex = DrinkName.Count - 1;



            //    if (finalindex >= 0)
            //    {
            //        st.Write("자판기종류: " + Admin.MachineType + " / ");
            //        st.Write("{음료품목: " + DrinkName[finalindex] + ", 가격: " + Price[finalindex] + ", 재고: " + Stock[finalindex] + "}");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("파일을 쓰는 중 오류가 발생했습니다: " + ex.Message);
            //}
            //finally
            //{
            //    if (st != null)
            //    {
            //        st.Close();
            //    }
            //}


        // public void DrinkFileOutput(string item, string price, string stock)       //파일읽기
        //{
        //    StreamReader sr = null;

        //    try
        //    {
        //        sr = new StreamReader("Machine_state.txt", System.Text.Encoding.Default);

        //        while (!sr.EndOfStream)
        //        {
        //            string line = sr.ReadLine();
        //            string[] machineInfo = line.Split(new string[] { "자판기종류: ", "{음료품목: ", ", 가격: ", ", 재고: }" }, StringSplitOptions.RemoveEmptyEntries);

        //            if (machineInfo.Length == 5)
        //            {
        //                Admin.MachineType = machineInfo[0];
        //                item = machineInfo[1];        //음료품목
        //                price = machineInfo[2];       //가격
        //                stock = machineInfo[3];
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine("파일을 읽는 중 오류가 발생했습니다: " + ex.Message);
        //    }
        //    finally
        //    {
        //        if (sr != null)
        //        {
        //            sr.Close();
        //        }
        //    }
        //}

        abstract public void DecreaseStock();        //재고 감소
        abstract public void StateMessage();        //재고 관련 메세지 박스
    }

    class HotItem:Item
    {
        public override void DecreaseStock()        //재고 감소
        {
            Water -= 50;
            //Stock -= 1;
        }
        
        public override void StateMessage()     //상황별 메세지
        {
            //if(Water<10)
            //{
            //    MessageBox.Show("물이 부족합니다.");
            //}

            //for(int i=0;i<DrinkName.Count;i++)
            //{
            //    if (Stock[i]<3)
            //    {
            //        MessageBox.Show("재고가 부족합니다.");
            //    }
            //}
        }
    }
    class ColdItem : Item
    {
        public override void DecreaseStock()
        {

        }
        public override void StateMessage()
        {

        }
    }
}
