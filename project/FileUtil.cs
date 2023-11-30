using System;
using System.Collections.Generic;
using System.IO;

namespace project
{
    public static class FileUtil
    {
        const string adminTxtPath = "Admin.txt";
        const string machineStateTxtPath = "MachineState.txt";

        public static void signup(string username, string password, string machineType)
        {

            // 마지막 index 찾는 코드
            StreamReader sr = null;
            int machineIndex = 1;
            try
            {
                sr = new StreamReader(adminTxtPath, System.Text.Encoding.Default);

                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    machineIndex++;
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

            // admin 파일에 저장
            StreamWriter sw = null;
            try
            {
                FileStream adminTxt = new FileStream(adminTxtPath, FileMode.Append);

                sw = new StreamWriter(adminTxt, System.Text.Encoding.Default);
                sw.WriteLine(username + "$" + password + "$" + machineIndex);
            }
            catch (Exception ex)
            {
                Console.WriteLine("파일을 쓰는 중 오류가 발생했습니다: " + ex.Message);
            }
            finally
            {
                if (sw != null)
                {
                    sw.Close();
                }
            }

            // machineState 파일에 machineType을 동시에 저장
            try
            {
                FileStream machineStateTxt = new FileStream(machineStateTxtPath, FileMode.Append);
                sw = new StreamWriter(machineStateTxt, System.Text.Encoding.Default);
                sw.WriteLine(machineType + ":");
            }
            catch (Exception ex)
            {
                Console.WriteLine("파일을 쓰는 중 오류가 발생했습니다: " + ex.Message);
            }
            finally
            {
                if (sw != null)
                {
                    sw.Close();
                }
            }

        }

        public static int FindMachineIndexByUser(string name, string password)       //사용자 찾는 메소드
        {

            StreamReader sr = null;
            int index = 0;
            try
            {
                sr = new StreamReader(adminTxtPath, System.Text.Encoding.Default);

                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    string[] userInfo = line.Split('$');        //구분자 -> 비밀번호에 $ 사용하면 구분자로 인식

                    if (userInfo.Length == 3 && userInfo[0] == name && userInfo[1] == password)
                    {
                        index = Int32.Parse(userInfo[2]);
                        return index;
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
            return index;
        }


        public static void StoreMachineStateByIndex(int index, Machine machine)     //인덱스로 MachineState텍스트 파일에 쓰기
        {
            try
            {
                string tempFilePath = Path.GetTempFileName();
                FileStream tempFile = new FileStream(tempFilePath, FileMode.Append);

                StreamReader sr = new StreamReader(machineStateTxtPath, System.Text.Encoding.Default);
                StreamWriter sw = new StreamWriter(tempFile, System.Text.Encoding.Default);

                int currentLine = 1;
                string line;

                // 파일을 읽으면서 수정할 라인을 찾고 변경된 내용을 쓴다
                while ((line = sr.ReadLine()) != null)
                {
                    if (currentLine == index)
                    {
                        line = machine.GetMachineType() + ":";
                        List<Item> items = machine.items;
                        for (int i = 0; i < items.Count;)
                        {
                            Item item = items[i++];
                            line += item.DrinkName + "#" + item.Price + "#" + item.Stock;
                            if (i != items.Count) line += '$';
                        }
                        sw.WriteLine(line);
                    }
                    else
                    {
                        sw.WriteLine(line); // 원래 내용 그대로 복사
                    }
                    currentLine++;
                }
                sr.Close();
                sw.Close();
                // 임시 파일을 원래 파일로 복사하고 삭제
                File.Copy(tempFilePath, machineStateTxtPath, true);
                File.Delete(tempFilePath);
            }
            catch (Exception e)
            {
                Console.WriteLine("오류 발생: " + e.Message);
            }
        }
        public static string GetMachineStateByIndex(int index)      //인덱스로 파일 내용 읽기
        {

            StreamReader sr = null;
            try
            {
                sr = new StreamReader(machineStateTxtPath, System.Text.Encoding.Default);
                int currentLine = 1;
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    if (currentLine++ == index)
                    {
                        return line;
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
            return null;
        }

        public static List<string> FindMachineTypesByMachineFile()        //MachineState텍스트 파일에서 자판기 타입 읽고, 콤보박스에 들어갈 내용 리스트 형태로 저장
        {
            List<string> machinesTypes = new List<string>();

            FileStream fs = File.OpenRead("MachineState.txt");
            StreamReader sr = new StreamReader(fs);

            int Count = 1;

            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                string[] machineType = line.Split(':');

                if (machineType.Length >= 1 && !string.IsNullOrWhiteSpace(machineType[0]))
                {
                    machinesTypes.Add("자판기" + Count);
                    Count++;
                }
            }
            sr.Close();
            fs.Close();

            return machinesTypes;
        }

        public static List<string> FindDrinksByMachineFile()        //MachineState텍스트 파일에서 음료품목을 읽기
        {
            List<string> drinks = new List<string>();

            FileStream fs = File.OpenRead("MachineState.txt");
            StreamReader sr = new StreamReader(fs);

            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                string[] machineType = line.Split(':');

                if (machineType.Length >= 2 && !string.IsNullOrWhiteSpace(machineType[0]))
                {
                    string[] drinksInfo = machineType[1].Split('$');

                    foreach (string drinkInfo in drinksInfo)
                    {
                        string[] drinkDetails = drinkInfo.Split('#');       //각 음료 정보에서 음료 품목만 추출
                        if (drinkDetails.Length >= 1)
                        {
                            drinks.Add(drinkDetails[0]);
                        }
                    }
                }
                //sr.Close();
                //fs.Close();

            }
            return drinks;
        }
    }
}
