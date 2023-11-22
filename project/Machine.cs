using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace project
{
    public abstract class Machine // 베이스 클래스
    {
        public List<string> machinename { get; set; } = new List<string>();
        public List<string> item { get; set; } = new List<string>();
        public List<string> price { get; set; } = new List<string>();
        public List<int> cnt { get; set; } = new List<int>();
        public static string SaveType { get; set; }        //자판기 타입

        public void SetMachineName()        //자판기 이름 설정 메소드
        {
            for (int i = 0; i < machinename.Count; i++)
            {
                machinename[i] = machinename[i] + i;
            }
        }
        public Machine() { }
        abstract public bool Stock();       //재고

        public void DrinkFileInput()        //파일쓰기
        {
            StreamWriter st = null;
            try
            {
                FileStream file = new FileStream("Machine_state.txt", FileMode.Append);
                st = new StreamWriter(file, System.Text.Encoding.Default);

                int finalindex = item.Count - 1;

                if (finalindex >= 0)
                {
                    st.WriteLine("관리자명: " + Admin.savename + " / 자판기종류: " + " / 음료품목: " + item[finalindex] + " / 가격: " + price[finalindex] + " / 재고: " + cnt[finalindex]);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("파일을 쓰는 중 오류가 발생했습니다: " + ex.Message);
            }
            finally
            {
                if (st != null)
                {
                    st.Close();
                }
            }
        }

        public void DrinkFileOutput()       //파일읽기
        {
            StreamReader sr = null;

            try
            {
                sr = new StreamReader("Machine_state.txt", System.Text.Encoding.Default);

                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    string[] machineInfo = line.Split(new string[] { "관리자명: ", " / 자판기종류: ", " / 음료품목: ", " / 가격: ", " / 재고: " }, StringSplitOptions.RemoveEmptyEntries);

                    if (machineInfo.Length == 5)
                    {
                        machinename.Add(machineInfo[1]);        //자판기 종류
                        item.Add(machineInfo[2]);       //음료 품목
                        price.Add(machineInfo[3]);      //가격
                        cnt.Add(int.Parse(machineInfo[4]));     //재고
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("파일을 읽는 중 오류가 발생했습니다: " + ex.Message);
            }
            finally
            {
                if (sr != null)
                {
                    sr.Close();
                }
            }
        }

    }

    public class HotDrink : Machine     //뜨거운 음료 클래스
    {
        public int water;       //물(L)
        public string SaveType = "hot";
        public HotDrink()       //생성자
        {
            this.water = 20; // 뜨거운 물 기본 20L
        }

        public override bool Stock()        //재고 메소드 구현
        {
            for(int i=0;i<item.Count;i++)       ////재고가 3개 미만, 물 1L미만이면 false 반환 -> 자판기 사용 불가능
            {
                if (water < 1 || cnt[i] < 3)
                {
                    return false;
                }
            }
            return true;        //재고가 3개 이상, 물 1L이상이면 true 반환 -> 자판기 사용 가능
        }
    }

    public class ColdDrink : Machine        //차가운 음료 클래스
    {
        public string SaveType = "Cold";
        public ColdDrink() { }      //생성자

        public override bool Stock()        //재고 메소드 구현
        {
            for(int i=0;i<machinename.Count;i++)
            {
                if (cnt[i] >= 3)        //재고가 3개 이상이면 true 반환 -> 자판기 사용 가능
                {
                    return true;
                }
            }
            return false;       //재고가 3개 미만이면 false반환 -> 자판기 사용 불가능
        }
    }
}
