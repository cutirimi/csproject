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

        public Modify(ColdMachine cd)
        {
            InitializeComponent();
            ColdModify cm = new ColdModify();
            cm.Show();
        }
        public Modify(HotMachine hd)
        {
            InitializeComponent();
            HotModify hm = new HotModify();
            hm.Show();
        }
        private void Modify_Load(object sender, EventArgs e)
        {

        }
    }
}
