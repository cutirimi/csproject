using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

//abstract class Machine        //자판기 클래스
//{
//    static string name;        //자판기 이름
//    public string[] drink;     //음료
//    int[] price;     //음료 가격
//    abstract public string Drinkinfo();     //자판기 음료와 가격 리턴
//}
//class Machine1 : Machine
//{
//    string name;
//    public Machine1() { name = "자판기1"; }
//    public override string Drinkinfo()
//    {
//        string[] drink = { "코카콜라", "펩시", "갈아만든배", "오렌지주스", "포도주스", "생수", "토레타", "포카리", "옥수수수염차" };
//        int[] price = { 1800, 1500, 1000, 800, 800, 1000, 2000, 1200, 2000 };
//        return Drinkinfo();
//    }
//}
//class Machine2 : Machine
//{
//    string name;
//    public Machine2() { name = "자판기2"; }
//    public override string Drinkinfo()
//    {
//        //사이다, 봉봉, 사과주스, 초코에몽으로 수정
//        string[] drink = { "사이다", "펩시", "봉봉", "사과주스", "포도주스", "생수", "토레타", "초코에몽", "옥수수수염차" };
//        int[] price = { 1200, 1500, 800, 800, 800, 1000, 2000, 1000, 2000 };
//        return Drinkinfo();
//    }
//}
namespace project
{    
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            //Machine1 machine1 = new Machine1();
            //Machine2 machine2 = new Machine2();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            button10.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = label3.Text;
            label21.Text = label12.Text;
            button10.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = label4.Text;
            label21.Text = label13.Text;
            button10.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = label5.Text;
            label21.Text = label14.Text;
            button10.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = label6.Text;
            label21.Text = label15.Text;
            button10.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text = label7.Text;
            label21.Text = label16.Text;
            button10.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label1.Text = label8.Text;
            label21.Text = label17.Text;
            button10.Visible = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label1.Text = label9.Text;
            label21.Text = label18.Text;
            button10.Visible = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label1.Text = label10.Text;
            label21.Text = label19.Text;
            button10.Visible = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label1.Text = label11.Text;
            label21.Text = label20.Text;
            button10.Visible = true;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            MessageBox.Show("정상 구매");
        }
    }
}
