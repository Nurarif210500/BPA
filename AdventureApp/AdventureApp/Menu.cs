using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdventureApp
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void viewDataCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            adduser hm = new adduser();
            this.Hide();
            hm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
