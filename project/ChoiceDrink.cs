﻿using System;
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
    public partial class ChoiceDrink : Form
    {
        public ChoiceDrink()
        {
            InitializeComponent();
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            if(adddrink.Text!="")
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

        private void ChoiceDrink_Load(object sender, EventArgs e)
        {

        }
    }
}