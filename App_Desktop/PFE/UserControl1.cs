using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PFE
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void EXIT_Click(object sender, EventArgs e)
        {
            // Get the parent form of the UserControl (Findform get the reference of an existing object)
            Home home = (Home)this.FindForm();

            // Close the form
            home.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
