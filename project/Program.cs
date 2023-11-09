using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

public class Machine
{
    public string name;     //자판기명
    public string[] drink;      //음료 품목
    public int[] price;     //음료 가격
    public Machine() { }
}
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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            Machine machine1 = new Machine();
            Machine machine2 = new Machine();

            machine1.name = "자판기1";
            machine2.name = "자판기2";
        }
    }
}
