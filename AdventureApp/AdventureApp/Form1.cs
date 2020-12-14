using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdventureApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-LFLIEA4; Initial Catalog=Adventure;" +
                        "User ID = sa; password=123");
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM admin WHERE username='" + txtuser.Text + "' AND password='" + txtpass.Text + "'", con);
            /* in above line the program is selecting the whole data from table and the matching it with the user name and password provided by user. */
            DataTable dt = new DataTable(); //this is creating a virtual table  
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                Menu hm = new Menu();
                this.Hide();
                hm.Show();
            }
            else
                MessageBox.Show("Invalid username or password");
        }

        
    }
}
