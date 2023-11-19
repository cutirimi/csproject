using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class Modify : Form
    {
        private HotDrink hotdrink;
        private ColdDrink colddrink;

        string fname = "machine_state.txt";

        public Modify(HotDrink hotdrinkObj)
        {
            InitializeComponent();
            hotdrink = hotdrinkObj;
        }

        public Modify(ColdDrink colddrinkObj)
        {
            InitializeComponent();
            colddrink = colddrinkObj;
        }

        public void FormClear()     //버튼 클릭시 drinktb 클리어시키는 용도로 사용
        {
            itemtb.Clear();
        }

        public void AddHotdrink(HotDrink hotdrink)
        {
            string[] items = new string[] { hotdrink.name, hotdrink.item, hotdrink.price };
            int save = hotdrink.cnt;
            ListViewItem lvi = new ListViewItem(items);
            drinklist.Items.Add(lvi);
        }

        public void AddColddrink(ColdDrink colddrink)
        {
            string[] items = new string[] { colddrink.name, colddrink.item, colddrink.price };
            int save = colddrink.cnt;
            ListViewItem lvi = new ListViewItem(items);
            drinklist.Items.Add(lvi);
        }

        public Modify()
        {
            InitializeComponent();
        }

        private void adderbtn_Click(object sender, EventArgs e)
        {
            

            //if (drinktb.Text != "")
            //{
            //    string[] items = itemtb.Text.Split(','); // 예시: "음료명,품목,가격" 형태로 입력 받음
            //    if (items.Length >= 3)
            //    {
            //        string itemType = items[0].Trim();
            //        string itemName = items[1].Trim();
            //        string itemPrice = items[2].Trim();

            //        if (itemType == "HotDrink")
            //        {
            //            hotdrink.name = itemName;
            //            hotdrink.item = itemPrice;
            //            hotdrink.price = itemPrice;

            //            AddHotdrink(hotdrink); // drinklist에 추가
            //        }
            //        else if (itemType == "ColdDrink")
            //        {
            //            colddrink.name = itemName;
            //            colddrink.item = itemPrice;
            //            colddrink.price = itemPrice;

            //            AddColddrink(colddrink); // drinklist에 추가
            //        }
            //        else
            //        {
            //            // 예외 처리: 잘못된 음료 유형
            //            MessageBox.Show("올바른 음료 유형을 입력하세요. (HotDrink 또는 ColdDrink)");
            //        }
            //    }
            //    else
            //    {
            //        // 예외 처리: 잘못된 형식의 입력
            //        MessageBox.Show("올바른 형식으로 입력하세요. (음료명,품목,가격)");
            //    }

            //    itemtb.Text = "";
            //}

        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            //if(drinklist.SelectedIndex>-1)
            //{
            //    drinklist.Items.RemoveAt(drinklist.SelectedIndex);
            //}
        }

        private void Modify_Load(object sender, EventArgs e)
        {
            //    try
            //    {
            //        if(File.Exists(fname)==false)
            //        {
            //            FileStream fs = new FileStream(fname, FileMode.OpenOrCreate);
            //            fs.Close();
            //        }
            //        else
            //        {
            //            FileStream fs = File.OpenRead(fname);
            //            StreamReader sr = new StreamReader(fs);

            //            while(sr.EndOfStream==false)
            //            {
            //                string data = sr.ReadLine();
            //                if (data == null) { break; }
            //                string[] sitems = data.Split('/');

            //                if (sitems.Length >= 3)
            //                {
            //                    if (sitems[0] == "HotDrink")
            //                    {
            //                        hotdrink.name = sitems[1];
            //                        hotdrink.item = sitems[2];
            //                        hotdrink.price = sitems[3];

            //                        AddHotdrink(hotdrink);      //drinklist에 추가
            //                    }
            //                    else if (sitems[0] == "ColdDrink")
            //                    {
            //                        colddrink.name = sitems[1];
            //                        colddrink.item = sitems[2];
            //                        colddrink.price = sitems[3];

            //                        AddColddrink(colddrink);        //drinklist에 추가
            //                    }
            //                }
            //            }
            //            sr.Close();
            //            fs.Close();
            //        }
            //    }
            //    catch (Exception e1)
            //    {
            //        MessageBox.Show("에러 : " + e1.ToString());
            //    }
        }
    }
}
