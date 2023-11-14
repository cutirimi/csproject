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
    public partial class Confirm : Form
    {
        public Confirm()
        {
            InitializeComponent();
        }

        private void Confirm_Load(object sender, EventArgs e)
        {

        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            if (adddrink.Text != "")
            {
                drinklist.Items.Add(adddrink.Text);
                adddrink.Text = "";
            }
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            if (drinklist.SelectedIndex > -1)
            {
                drinklist.Items.RemoveAt(drinklist.SelectedIndex);
            }
        }

        private void adddrink_TextChanged(object sender, EventArgs e)
        {

        }

        private void adddrink_TextChanged_1(object sender, EventArgs e)
        {
            drinklist.Items.Add(adddrink);
        }
    }
}
