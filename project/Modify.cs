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
    public partial class Modify : Form
    {
        public Modify()
        {
            InitializeComponent();
        }

        private void adderbtn_Click(object sender, EventArgs e)
        {
            if(drinktb.Text!="")
            {
                drinklist.Items.Add(drinktb.Text);
                drinktb.Text = "";
            }
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            if(drinklist.SelectedIndex>-1)
            {
                drinklist.Items.RemoveAt(drinklist.SelectedIndex);
            }
        }

        private void Modify_Load(object sender, EventArgs e)
        {

        }
    }
}