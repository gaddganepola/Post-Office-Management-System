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

namespace PostOfficeManagement
{
    public partial class staffDashboard : Form
    {
        public staffDashboard()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-NLDBQLGG\SQLEXPRESS;Initial Catalog=PostOffice;Integrated Security=True");


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void staffDashboard_Load(object sender, EventArgs e)
        {
            if (login.user.Contains("stf"))
            {
                button6.Hide();
            }
            if (login.user == "admin")
            {
                button4.Hide();
                lblEmpName.Hide();
            }

            lblEmpId.Text = login.user;

            SqlCommand cmd = new SqlCommand("SELECT [name] FROM [dbo].[employee] WHERE [employeeId] = '" + login.user + "'", conn);
            conn.Open();

            SqlDataReader myR = cmd.ExecuteReader();
            if (myR.HasRows)
            {
                while (myR.Read())
                {

                    lblEmpName.Text = myR[0].ToString();

                }
            }
            conn.Close();

            timer1.Start();
            lblDate.Text = DateTime.Now.ToShortDateString();
            lblTime.Text = DateTime.Now.ToShortTimeString();    
        }

        private void button4_Click(object sender, EventArgs e)
        {
            searchLetter letterStatus = new searchLetter();


            letterStatus.TopLevel = false;
            pnlContent.Controls.Add(letterStatus);
            letterStatus.BringToFront();
            letterStatus.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            stampIssue stampIssue = new stampIssue();
            stampIssue.TopLevel = false;
            pnlContent.Controls.Add(stampIssue);
            stampIssue.BringToFront();
            stampIssue.Show();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlContent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            acceptedLetters acceptedLetters = new acceptedLetters();
            acceptedLetters.TopLevel = false;
            pnlContent.Controls.Add(acceptedLetters);
            acceptedLetters.BringToFront();
            acceptedLetters.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            payment payment = new payment();
            payment.TopLevel = false;
            pnlContent.Controls.Add(payment);
            payment.BringToFront();
            payment.Show();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToShortTimeString();
            timer1.Start();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            profile profile = new profile();

            profile.TopLevel = false;
            pnlContent.Controls.Add(profile);
            profile.BringToFront();
            profile.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            login login = new login();

            this.Hide();
            login.Show();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            employee employee = new employee();

            employee.TopLevel = false;
            pnlContent.Controls.Add(employee);
            employee.BringToFront();
            employee.Show();
        }
    }
}
