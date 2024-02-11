using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace PostOfficeManagement
{
    public partial class login : Form
    {

        public static string user;


        public login()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-NLDBQLGG\SQLEXPRESS;Initial Catalog=PostOffice;Integrated Security=True");

        private void login_Load(object sender, EventArgs e)
        {
            txtUsername.Focus();

            timer1.Start();
            lblDate.Text = DateTime.Now.ToShortDateString();
            lblTime.Text = DateTime.Now.ToShortTimeString();
           

                
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                MessageBox.Show("Please enter username", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Focus();
                return;
            }


            if (txtPassword.Text == "")
            {
                MessageBox.Show("Please enter password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Focus();
                return;
            }

            string username, password;

          

            try
            {
                

                string querry = "SELECT * FROM login WHERE employeeId = '" + txtUsername.Text + "' AND password = '" + txtPassword.Text + "'";
                SqlDataAdapter adapter = new SqlDataAdapter(querry, conn);

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    username = txtUsername.Text;
                    password = txtPassword.Text;
                    user = username;

                    if (username.Contains("emp"))
                    {
                        postmanDashboard postmanDashboard = new postmanDashboard();
                        postmanDashboard.Show();
                        this.Hide();

                    }
                    else if (username.Contains("stf")) 
                    {
                        staffDashboard staffDashboard = new staffDashboard();
                        staffDashboard.Show();
                        this.Hide();
                    }
                    else if (username == "admin")
                    {
                        admin admin = new admin();
                        admin.Show();
                        this.Hide();
                    }


                }
                else
                {
                    MessageBox.Show("Invalid Username or Password", "Login Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                }

            }       
            catch
            {
                MessageBox.Show("DB Error");

            }
            finally
            {
                conn.Close();
            }



        }

        private void label5_MouseHover(object sender, EventArgs e)
        {
            label5.ForeColor = Color.Blue;
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            label5.ForeColor = Color.Black;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtUsername.Focus();
            txtPassword.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToShortTimeString();
            timer1.Start();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Contact the head of the institution", "Login Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void checkBoxShow_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShow.Checked == true)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else 
            {
                txtPassword.UseSystemPasswordChar = true;

            }
        }
    }
}
