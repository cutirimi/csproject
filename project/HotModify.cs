using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class HotModify : Form
    {
        UserPageForm up = new UserPageForm();
        HotItem hi= new HotItem();
        ListViewItem lvi = new ListViewItem();
        private Admin admin=Admin.GetInstance();

        const string fname = "Machine_State.txt";

        public void formClear()
        {
            itemtb.Clear();
            pricetb.Clear();
            stocktb.Clear();
            itemtb.Focus();
        }

        public void AddDrink()
        {
            for(int i = 0;i<hi.DrinkName.Count;i++)
            {
                string[] sitems = new string[] { hi.DrinkName[i], hi.Price[i], hi.Stock[i].ToString() };
                ListViewItem lvi = new ListViewItem(sitems);
                drinklist.Items.Add(lvi);
                drinklist.EndUpdate();
            }
            //string[] sitems = new string[] { hi.DrinkName, hi.Price, hi.Stock };
            //ListViewItem lvi = new ListViewItem(sitems);
            //drinklist.Items.Add(lvi);
            //drinklist.EndUpdate();
        }

        public HotModify()
        {
            InitializeComponent();
        }

        private void HotModify_Load(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(fname) == false)
                {
                    FileStream fs = new FileStream(fname, FileMode.OpenOrCreate);
                    fs.Close();
                }
                else
                {
                    FileStream fs = File.OpenRead(fname);
                    StreamReader sr = new StreamReader(fs);
                    while (sr.EndOfStream == false)
                    {
                        string line = sr.ReadLine();
                        if (line == null) { break; }
                        string[] sitems = line.Split(',');
                        admin.MachineType = sitems[0];
                        for (int i = 0; i <hi.DrinkName.Count;i++)
                        {
                            hi.DrinkName[i] = sitems[1];
                            hi.Price[i] = sitems[2];
                            hi.Stock[i] = sitems[3];
                        }
                        //    hi.DrinkName = sitems[1];
                        //hi.Price = sitems[2];
                        //hi.Stock = sitems[3];
                        AddDrink();
                    }
                    sr.Close();
                    fs.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("파일을 읽는 중 오류가 발생했습니다: " + ex.Message);
            }
        }

        private void movebtn_Click(object sender, EventArgs e)
        {
            up.Show();
            this.Close();
        }

        private void adderbtn_Click(object sender, EventArgs e)
        {
            drinklist.BeginUpdate();

            hi.DrinkName = itemtb.Text;
            hi.Price = pricetb.Text;
            hi.Stock = stocktb.Text;

            FileStream fs = File.Create(fname);
            StreamWriter sw = new StreamWriter(fs);

            foreach (ListViewItem lvi in drinklist.Items)
            {
                admin.MachineType = lvi.SubItems[0].Text;
                hi.DrinkName = lvi.SubItems[1].Text;
                hi.Price = lvi.SubItems[2].Text;
                hi.Stock = lvi.SubItems[3].Text;
                sw.WriteLine("{0} - {음료: {1}, 가격: {2}, 재고: {3}}", hi.DrinkName, hi.Price, hi.Stock);
            }
            sw.Close();
            fs.Close();

            AddDrink();
            formClear();
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            if(drinklist.SelectedItems.Count > 0)
            {
                drinklist.Items.Remove(drinklist.SelectedItems[0]);
            }
        }
    }
}
