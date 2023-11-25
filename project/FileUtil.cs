﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

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
                sr = new StreamReader(adminTxtPath, System.Text.Encoding.Default);     //../../Admin.txt

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

            // machineState 파일에 
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
                sr = new StreamReader(adminTxtPath, System.Text.Encoding.Default);     //../../Admin.txt

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


        public static void StoreMachineStateByIndex(int index, List<Item> itemList)
        {
            try
            {
                
                string tempFilePath = Path.GetTempFileName();

                using (StreamReader reader = new StreamReader(machineStateTxtPath))
                using (StreamWriter writer = new StreamWriter(tempFilePath))
                {
                    int currentLine = 1;
                    string line;

                    // 파일을 읽으면서 수정할 라인을 찾고 변경된 내용을 쓴다
                    while ((line = reader.ReadLine()) != null)
                    {
                        if (currentLine == index)
                        {
                            // 수정 해야하는 라인
                        }
                        else
                        {
                            writer.WriteLine(line); // 원래 내용 그대로 복사
                        }
                        currentLine++;
                    }
                }

                // 임시 파일을 원래 파일로 복사하고 삭제
                File.Copy(tempFilePath, machineStateTxtPath, true);
                File.Delete(tempFilePath);

                Console.WriteLine("라인 수정 완료.");
            }
            catch (Exception e)
            {
                Console.WriteLine("오류 발생: " + e.Message);
            }
        }
        public static string GetMachineStateByIndex(int index)
        {

            StreamReader sr = null;
            try
            {
                sr = new StreamReader(machineStateTxtPath, System.Text.Encoding.Default);     //../../Admin.txt
                int currentLine = 1;
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    if(currentLine++ == index)
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
    }
}
