using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    public static class Admin
    {
        public static List<string> Name { get; set; } = new List<string>();
        public static List<string> Password { get; set; } = new List<string>();
        public static string savename { get; set; }     //사용자 이름 저장할 필드 -> List<string>으로는 하나의 이름 접근 불가능하기 때문에 추가
        public static string Pwcon { get; set; }
        public static string savetype { get; set; }
        public static void FileInput()      //파일쓰기
        {
            StreamWriter st = null;
            try
            {
                FileStream file = new FileStream("../../Admin.txt", FileMode.Append);
                st = new StreamWriter(file, System.Text.Encoding.Default);

                int lastIndex = Name.Count - 1;     //새로 추가된 인덱스

                if (lastIndex >= 0)
                {
                    st.WriteLine("이름: " + Name[lastIndex] + " / 비밀번호: " + Password[lastIndex]);
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

        public static void FileOutput() // 파일읽기
        {
            StreamReader sr = null;

            try
            {
                sr = new StreamReader("../../Admin.txt", System.Text.Encoding.Default);

                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    string[] userInfo = line.Split(new string[] { "이름: ", " / 비밀번호: " }, StringSplitOptions.RemoveEmptyEntries);

                    if (userInfo.Length == 2)
                    {
                        Name.Add(userInfo[0]);
                        Password.Add(userInfo[1]);
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

        public static bool FindUser(string logname, string logpw)       //사용자 찾는 메소드
        {
            for (int i = 0; i < Admin.Name.Count; i++)
            {
                if (logname == Admin.Name[i] && logpw == Admin.Password[i])
                {
                    return true;        //사용자가 찾아졌을 때 true 반환
                }
            }
            return false;       //사용자가 찾아지지 않았을 때 false 반환
        }
    }
}
