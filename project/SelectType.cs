using System;
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
    public partial class SelectType : Form
    {
        ColdDrink cd = new ColdDrink();
        HotDrink hd = new HotDrink();

        public bool typebool()
        {
            bool judge = true;

            if(cd.SaveType == "cold")
            {
                judge = true;
            }
            else if(hd.SaveType=="hot")
            {
                judge = false;
            }

            return judge;
        }
        public SelectType()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ColdModify cm = new ColdModify();
            cm.Show();
            this.Hide();
            cd.SaveType = "cold";
            typebool();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HotModify hm = new HotModify();
            hm.Show();
            this.Hide();
            hd.SaveType = "hot";
            typebool();
        }

        private void SelectType_Load(object sender, EventArgs e)
        {

        }
    }
}
