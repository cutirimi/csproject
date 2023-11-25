using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    public class Admin
    {
        private static Admin staticAdmin;
        public static Admin GetInstance()
        {
            if(staticAdmin==null)
            {
                staticAdmin = new Admin();
            }
            return staticAdmin;
        }

        public string AdminName { get; set; }     //관리자이름
        public string MachineType { get; set; }     //자판기 타입
        public void FileInput(string name , string password , string type)      //파일쓰기
        {
            StreamWriter st = null;
            try
            {
                FileStream file = new FileStream("Admin.txt", FileMode.Append);       //../../Admin.txt
                st = new StreamWriter(file, System.Text.Encoding.Default);
                st.WriteLine(name + "$" + password + "$" + type);
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

        public bool FindUser(string name, string password)       //사용자 찾는 메소드
        {

            StreamReader sr = null;

            try
            {
                sr = new StreamReader("Admin.txt", System.Text.Encoding.Default);     //../../Admin.txt

                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    string[] userInfo = line.Split('$');        //구분자 -> 비밀번호에 $ 사용하면 구분자로 인식

                    if (userInfo.Length == 3 && userInfo[0] == name && userInfo[1] == password)
                    {
                        AdminName = name;
                        MachineType = userInfo[2];
                        return true;
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
            return false;
        }
    }
}
