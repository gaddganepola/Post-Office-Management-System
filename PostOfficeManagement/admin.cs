using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PostOfficeManagement
{
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }

        private void btnPostman_Click(object sender, EventArgs e)
        {
            postmanDashboard postmanDashboard = new postmanDashboard();
            postmanDashboard.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            staffDashboard staffDashboard = new staffDashboard();
            staffDashboard.Show();
            this.Hide();
        }

        private void admin_Load(object sender, EventArgs e)
        {

        }
    }
}
