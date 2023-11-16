using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class DrinkMachineSelect : Form
    {
        Modify mf = new Modify();

        public DrinkMachineSelect()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HotDrink hotdrink = new HotDrink();
            this.Close();
            mf.Show();
        }

        private void coldbtn_Click(object sender, EventArgs e)
        {
            ColdDrink colddrink = new ColdDrink();
            this.Close();
            mf.Show();
        }

        private void DrinkMachineSelect_Load(object sender, EventArgs e)
        {

        }
    }
}
