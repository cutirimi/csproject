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
        SelectType st = new SelectType();
        HotDrink hd = new HotDrink();
        UserPage up = new UserPage();


        public HotModify()
        {
            InitializeComponent();
        }

        private void HotModify_Load(object sender, EventArgs e)
        {
            st.Hide();
        }

        private void movebtn_Click(object sender, EventArgs e)
        {
            up.Show();
            this.Close();
        }
    }
}
