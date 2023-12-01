using System;
using System.Windows.Forms;

namespace project
{
    internal static class Program
    {
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //try
            //{
            //    throw new CustomException1 ("");
            //}
            //catch (Exception e)
            //{
            //    e.HandleError();
            //}

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());     //Form1이 항상 기본 실행
        }
    }
}
