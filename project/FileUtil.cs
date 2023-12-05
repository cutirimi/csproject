using System;
using System.Collections.Generic;
using System.IO;

namespace project
{
    public static class FileUtil        //파일처리 클래스
    {
        const string adminTxtPath = "Admin.txt";        //관리자 정보 Admin 텍스트파일
        const string machineStateTxtPath = "MachineState.txt";      //자판기 정보 MachineState 텍스트파일

        // Admin.txt 텍스트파일에 관리자정보를 작성하면서 동시에 MachineState.txt 텍스트파일에 자판기 타입 작성
        public static void signup(string username, string password, string machineType)
        {
            // 마지막 index 찾는 코드
            StreamReader sr = null;
            int machineIndex = 1;       //사용자 등록 순서를 나타냄

            // Admin.txt 텍스트파일 읽기
            try
            {
                sr = new StreamReader(adminTxtPath, System.Text.Encoding.Default);

                while (!sr.EndOfStream)     //파일의 끝까지 반복
                {
                    string line = sr.ReadLine();        //한 줄을 읽음. ex)관리자명$비밀번호$번호
                    machineIndex++;     //사용자 등록 순서 증감연산자. 다음 사용자 등록을 위함
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("파일을 읽는 중 오류가 발생했습니다: " + ex.Message);
            }
            finally
            {
                if (sr != null)     //Admin.txt 파일 리소스 해제
                {
                    sr.Close();
                }
            }

            // Admin.txt 텍스트파일에 쓰기
            StreamWriter sw = null;

            try
            {
                FileStream adminTxt = new FileStream(adminTxtPath, FileMode.Append);

                sw = new StreamWriter(adminTxt, System.Text.Encoding.Default);
                // ex)관리자명$비밀번호$순서 형태로 파일에 작성
                sw.WriteLine(username + "$" + password + "$" + machineIndex);
            }
            catch (Exception ex)
            {
                Console.WriteLine("파일을 쓰는 중 오류가 발생했습니다: " + ex.Message);
            }
            finally
            {
                if (sw != null)     //Admin.txt 텍스트파일을 닫고 파일리소스 해제
                {
                    sw.Close();
                }
            }

            // machineState.txt 텍스트파일에 machineType을 동시에 저장
            try
            {
                FileStream machineStateTxt = new FileStream(machineStateTxtPath, FileMode.Append);
                sw = new StreamWriter(machineStateTxt, System.Text.Encoding.Default);
                // MachineState.txt 텍스트파일에 관리자가 설정한 자판기타입을 작성
                sw.WriteLine(machineType + ":");        //ex)cold: 형태로 파일에 씀
            }
            catch (Exception ex)
            {
                Console.WriteLine("파일을 쓰는 중 오류가 발생했습니다: " + ex.Message);
            }
            finally
            {
                if (sw != null)     //MachineState.txt 텍스트파일을 닫고 파일리소스 해제
                {
                    sw.Close();
                }
            }
        }

        // 관리자명과 비밀번호로 Admin.txt 텍스트파일에서 사용자를 찾고 해당하는 사용자의 순서를 반환
        public static int FindMachineIndexByUser(string name, string password)
        {
            StreamReader sr = null;
            int index = 0;      //자판기의 인덱스를 저장

            try
            {
                // Admin.txt 텍스트파일 읽기
                sr = new StreamReader(adminTxtPath, System.Text.Encoding.Default);

                while (!sr.EndOfStream)     //파일의 끝까지 반복
                {
                    // 파일에 작성된 한 줄을 line에 저장 ex)line="관리자명$비밀번호$순서"
                    string line = sr.ReadLine();
                    string[] userInfo = line.Split('$');        //구분자 $

                    if (userInfo.Length == 3 && userInfo[0] == name && userInfo[1] == password)
                    {
                        // 관리자명, 비밀번호를 userInfo 문자열 배열에 순서대로 할당
                        index = Int32.Parse(userInfo[2]);       //정수형으로 순서를 userInfo[2]에 할당
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
                if (sr != null)     //Admin.txt 텍스트파일을 닫고 파일리소스 해제
                {
                    sr.Close();
                }
            }
            return index;
        }

        // 인덱스에 해당하는 자판기의 내용을  MachineState.txt 파일에 쓰기
        public static void StoreMachineStateByIndex(int index, Machine machine)
        {
            try
            {
                //임시파일 생성 -> 수정중인 파일을 안전하게 저장하기 위함
                string tempFilePath = Path.GetTempFileName();
                FileStream tempFile = new FileStream(tempFilePath, FileMode.Append);
                StreamReader sr = new StreamReader(machineStateTxtPath, System.Text.Encoding.Default);
                StreamWriter sw = new StreamWriter(tempFile, System.Text.Encoding.Default);

                int currentLine = 1;        //현재 라인을 1로 초기화
                string line;

                // 파일을 읽으면서 수정할 라인을 찾고 변경된 내용을 쓴다
                while ((line = sr.ReadLine()) != null)      //파일 끝까지 반복
                {
                    if (currentLine == index)
                    {
                        // 현재 읽고 있는 라인의 번호와 지정된 인덱스가 일치할 경우
                        // line에 자판기타입: 형태로 저장 ex)line="cold:"
                        line = machine.GetMachineType() + ":";
                        List<Item> items = machine.items;       //각각의 음료품목을 리스트형태로 한번에 저장

                        for (int i = 0; i < items.Count;)       //음료 품목 개수만큼 반복
                        {
                            Item item = items[i++];     //음료품목 목록을 아이템에 저장
                            //line에 "음료명#가격#재고" 문자열 형태로 저장
                            line += item.DrinkName + "#" + item.Price + "#" + item.Stock;
                            //마지막 음료품목이 아닌 경우 '$'추가
                            // ex)음료1#가격1#재고1$음료2#가격2#재고2$음료3#가격3#재고3
                            if (i != items.Count) line += '$';
                        }
                        sw.WriteLine(line);     // line에 저장된 문자열을 파일에 작성
                    }
                    else        //현재 읽고 있는 라인의 번호와 지정된 인덱스가 일치하지 않는 경우
                    {
                        sw.WriteLine(line);     //원래 내용 그대로 복사
                    }
                    currentLine++;      //다음 라인으로 이동
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

        // 인덱스로 MachineState.txt 텍스트파일 읽기
        public static string GetMachineStateByIndex(int index)
        {
            StreamReader sr = null;

            try
            {
                sr = new StreamReader(machineStateTxtPath, System.Text.Encoding.Default);
                int currentLine = 1;        //현재 읽고 있는 라인의 번호

                while (!sr.EndOfStream)     //파일의 끝까지 반복
                {
                    // 한 줄의 내용을 읽고 line으로 문자열 형태로 저장
                    // ex)음료1#가격1#재고$음료2#가격2#재고2$음료3#가격3#재고3 형태로 저장
                    string line = sr.ReadLine();

                    // 현재 읽고 있는 라인과 index와 지정된 인덱스와 일치할 경우 line 리턴
                    if (currentLine++ == index)
                    {
                        return line;        // 그 줄의 내용을 반환
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

        // MachineState.txt 파일에서 자판기 타입 읽고, 콤보박스에 들어갈 내용을 리스트 형태로 저장
        public static List<string> FindMachineTypesByMachineFile()
        {
            // 자판기상태를 문자열 형태로 저장하는 리스트
            List<string> machineStateList = new List<string>();        //컬렉션
            FileStream fs = File.OpenRead("MachineState.txt");
            StreamReader sr = new StreamReader(fs, System.Text.Encoding.Default);

            while (!sr.EndOfStream)     //파일의 끝까지 반복
            {
                string line = sr.ReadLine();        //한 줄을 읽고 문자열 line에 저장
                string[] machineType = line.Split(':');     //자판기 타입을 :로 구분하여 저장

                // 자판기가 생성되어있는 경우
                if (machineType.Length >= 1 && !string.IsNullOrWhiteSpace(machineType[0]))
                {
                    // 자판기의 한 줄 정보를 담은 line을 machineStateList 리스트에 저장
                    machineStateList.Add(line);
                }
            }
            sr.Close();
            fs.Close();

            return machineStateList;        //자판기들과 해당 자판기의 품목들을 리스트형태로 반환
        }
    }
}
