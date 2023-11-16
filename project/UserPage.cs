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
    public partial class UserPage : Form
    {
        UserAdd ua = new UserAdd();

        public UserPage()
        {
            InitializeComponent();  
        }

        private void modifybtn_Click(object sender, EventArgs e)
        {
            Modify modify = new Modify();
            modify.Show();
        }

        private void UserPage_Load(object sender, EventArgs e)
        {
            label1.Text = Admin.Name;
        }
    }
}
