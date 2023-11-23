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
    public partial class HotModify : Form
    {
        HotDrink hd = new HotDrink();
        UserPage up = new UserPage();
        HotItem hi= new HotItem();

        public void AddDrinkToListView()     //리스트에 Machine정보 추가
        {
            for (int i = 0; i < hi.DrinkName.Count; i++)
            {
                ListViewItem lvi = new ListViewItem(new[] { hi.DrinkName[i], hi.Price[i], hi.Stock[i].ToString() });

                drinklist.Items.Add(lvi);
            }
        }

        public HotModify()
        {
            InitializeComponent();
        }

        private void HotModify_Load(object sender, EventArgs e)
        {
            //st.Hide();
        }

        private void movebtn_Click(object sender, EventArgs e)
        {
            up.Show();
            this.Close();
        }
    }
}
