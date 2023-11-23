using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace project
{
    public abstract class Machine       //베이스클래스
    {
        public abstract string SaveType();     //자판기 타입
    }

    public class HotDrink : Machine     //뜨거운 음료 클래스
    {
        public override string SaveType()
        {
            return "hot";
        }
    }

    public class ColdDrink : Machine        //차가운 음료 클래스
    {
        public override string SaveType()
        {
            return "cold";
        }
    }
}
