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
        public static string Pwcon { get; set; }
        public static void FileInput()      //파일쓰기
        {
            StreamWriter st = null;
            try
            {
                FileStream file = new FileStream("Admin.txt", FileMode.Append);
                st = new StreamWriter(file, System.Text.Encoding.Default);

                st.WriteLine("이름: " + Admin.Name.Last() + " / 비밀번호: " + Admin.Password.Last());
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
    }
}
