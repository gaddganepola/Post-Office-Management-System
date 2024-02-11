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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PostOfficeManagement
{
    public partial class postmanDashboard : Form
    {
        
        public postmanDashboard()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-NLDBQLGG\SQLEXPRESS;Initial Catalog=PostOffice;Integrated Security=True");


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void postmanDashboard_Load(object sender, EventArgs e)
        {
            if (login.user == "admin")
            {
                lblEmpName.Hide();
                btnViewProfile.Hide();
            }

            btnLetterData.Focus();
            lblEmpId.Text = login.user;

            SqlCommand cmd = new SqlCommand("SELECT [name] FROM [dbo].[employee] WHERE [employeeId] = '"+login.user+"'", conn);
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToShortTimeString();
            timer1.Start();
        }

        private void btnViewProfile_Click(object sender, EventArgs e)
        {
            profile profile = new profile();

            profile.TopLevel = false;
            pnlContent.Controls.Add(profile);
            profile.BringToFront();
            profile.Show();

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            searchLetter letterStatus = new searchLetter();


            letterStatus.TopLevel = false;
            pnlContent.Controls.Add(letterStatus);
            letterStatus.BringToFront();
            letterStatus.Show();
        }

        private void btnLetterStatus_Click(object sender, EventArgs e)
        {
            letterStatus letterStatus = new letterStatus();


            letterStatus.TopLevel = false;
            pnlContent.Controls.Add(letterStatus);
            letterStatus.BringToFront();
            letterStatus.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {

        }

        private void btnLetterData_Click(object sender, EventArgs e)
        {
            letterData letterData = new letterData();
         
            
                letterData.TopLevel = false;
                pnlContent.Controls.Add(letterData);
                letterData.BringToFront();
                letterData.Show();

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblTime_Click(object sender, EventArgs e)
        {

        }

        private void btnLetterData_MouseHover(object sender, EventArgs e)
        {
            btnLetterData.BackColor = Color.AliceBlue;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnLetterData_MouseHover_1(object sender, EventArgs e)
        {
            btnLetterData.BackColor = Color.AliceBlue;
        }

        private void btnLetterStatus_MouseHover(object sender, EventArgs e)
        {
            btnLetterStatus.BackColor = Color.AliceBlue;
        }

        private void btnSearch_MouseHover(object sender, EventArgs e)
        {
            btnSearch.BackColor = Color.AliceBlue;
        }

        private void btnViewProfile_MouseHover(object sender, EventArgs e)
        {
            btnViewProfile.BackColor = Color.AliceBlue;
        }

        private void btnLogout_MouseHover(object sender, EventArgs e)
        {
            btnLogout.BackColor = Color.AliceBlue;
        }

        private void btnLetterData_MouseLeave(object sender, EventArgs e)
        {
            btnLetterData.BackColor = Color.Beige;
        }

        private void btnLetterStatus_MouseLeave(object sender, EventArgs e)
        {
            btnLetterStatus.BackColor = Color.Beige;
        }

        private void btnSearch_MouseLeave(object sender, EventArgs e)
        {
            btnSearch.BackColor = Color.Beige;
        }

        private void btnViewProfile_MouseLeave(object sender, EventArgs e)
        {
            btnViewProfile.BackColor = Color.Beige;
        }

        private void btnLogout_MouseLeave(object sender, EventArgs e)
        {
            btnLogout.BackColor = Color.Beige;
        }

        private void btnLogout_Click_1(object sender, EventArgs e)
        {
           
            login login = new login();
            
            this.Hide();
            login.Show();
            

        }
    }
}
