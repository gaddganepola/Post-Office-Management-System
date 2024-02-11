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
    public partial class profile : Form
    {
        public profile()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-NLDBQLGG\SQLEXPRESS;Initial Catalog=PostOffice;Integrated Security=True");


        private void profile_Load(object sender, EventArgs e)
        {
            txtAddress.Hide();
            txtContact.Hide();
            txtName.Hide();
            txtPassword.Hide(); 
            btnEdit.Hide();
            lblA.Hide();
            lblC.Hide();
            lblN.Hide();
            lblp.Hide();

            SqlCommand cmd = new SqlCommand("SELECT [employeeId], [name], [gender], [contact], [address], [employeeType], [BasicSalary], [status], [hiredDate] FROM [dbo].[employee] WHERE [employeeId] = '"+ login.user + "'", conn);
            conn.Open();

            SqlDataReader myR = cmd.ExecuteReader();
            if (myR.HasRows)
            {
                while (myR.Read())
                {
                    lblEmpId.Text = myR[0].ToString();
                    lblname.Text = myR[1].ToString();
                    lblGender.Text = myR[2].ToString();
                    lblContact.Text = myR[3].ToString();
                    lblAddress.Text = myR[4].ToString();
                    lblEmpType.Text = myR[5].ToString();
                    lblSalary.Text = myR[6].ToString();
                    lblStatus.Text = myR[7].ToString();
                    lblHireDate.Text = myR[8].ToString();
                }
            }
            conn.Close();

            SqlCommand cmd1 = new SqlCommand("SELECT [password] FROM [dbo].[logIn] WHERE [employeeId] = '" + login.user + "'", conn);
            conn.Open();

            SqlDataReader myR1 = cmd1.ExecuteReader();
            if (myR1.HasRows)
            {
                while (myR1.Read())
                {
                    lblPassword.Text = myR1[0].ToString();
                    
                }
            }
            conn.Close();
        }

        private void txtName_Click(object sender, EventArgs e)
        {
            txtName.Text = lblname.Text;
        }

        private void txtContact_Click(object sender, EventArgs e)
        {
            txtContact.Text = lblContact.Text;
        }

        private void txtAddress_Click(object sender, EventArgs e)
        {
            txtAddress.Text = lblAddress.Text;
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            txtPassword.Text = lblPassword.Text;
        }

        private void profile_Click(object sender, EventArgs e)
        {
            txtAddress.Text = lblAddress.Text;
            txtContact.Text = lblContact.Text;
            txtName.Text = lblname.Text;
            txtPassword.Text = lblPassword.Text;
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            txtAddress.Show();
            txtContact.Show();
            txtName.Show();
            txtPassword.Show();
            btnEdit.Show();
            lblA.Show();
            lblC.Show();
            lblN.Show();
            lblp.Show();

            txtAddress.Text = lblAddress.Text;
            txtContact.Text = lblContact.Text;
            txtName.Text = lblname.Text;
            txtPassword.Text = lblPassword.Text;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("Enter Name", "Profile Edit Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Focus();
                return;
            }
            if (txtContact.Text == "")
            {
                MessageBox.Show("Enter contact number", "Profile Edit Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtContact.Focus(); 
                return;
            }
            if (txtAddress.Text == "")
            {
                MessageBox.Show("Enter address", "Profile Edit Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAddress.Focus();
                return;
            }
            if (txtPassword.Text == "")
            {
                MessageBox.Show("Enter password", "Profile Edit Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Focus();
                return;
            }
            else
            {
                if(txtPassword.Text.Length > 10)
                {
                    MessageBox.Show("Maximum 10 characters only", "Profile Edit Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassword.Focus();
                    return;
                }
            }

            var result = MessageBox.Show("Are you sure you want to edit details", "Edit Profile Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                SqlCommand cmd1 = new SqlCommand(@"UPDATE [dbo].[employee] SET [name] = '" + txtName.Text + "', [contact] = '" + txtContact.Text + "', [address] = '" + txtAddress.Text + "' WHERE [employeeId] = '" + lblEmpId.Text + "'", conn);
                conn.Open();
                cmd1.ExecuteNonQuery();
                conn.Close();

                SqlCommand cmd2 = new SqlCommand(@"UPDATE [dbo].[logIn] SET [password] = '" + txtPassword.Text + "' WHERE [employeeId] = '" + lblEmpId.Text + "'", conn);
                conn.Open();
                cmd2.ExecuteNonQuery();
                conn.Close();


                SqlCommand cmd = new SqlCommand("SELECT [employeeId], [name], [gender], [contact], [address], [employeeType], [BasicSalary], [status], [hiredDate] FROM [dbo].[employee] WHERE [employeeId] = '" + login.user + "'", conn);
                conn.Open();

                SqlDataReader myR = cmd.ExecuteReader();
                if (myR.HasRows)
                {
                    while (myR.Read())
                    {
                        lblEmpId.Text = myR[0].ToString();
                        lblname.Text = myR[1].ToString();
                        lblGender.Text = myR[2].ToString();
                        lblContact.Text = myR[3].ToString();
                        lblAddress.Text = myR[4].ToString();
                        lblEmpType.Text = myR[5].ToString();
                        lblSalary.Text = myR[6].ToString();
                        lblStatus.Text = myR[7].ToString();
                        lblHireDate.Text = myR[8].ToString();
                    }
                }
                conn.Close();

                SqlCommand cmd3 = new SqlCommand("SELECT [password] FROM [dbo].[logIn] WHERE [employeeId] = '" + login.user + "'", conn);
                conn.Open();

                SqlDataReader myR1 = cmd3.ExecuteReader();
                if (myR1.HasRows)
                {
                    while (myR1.Read())
                    {
                        lblPassword.Text = myR1[0].ToString();

                    }
                }
                conn.Close();

                txtAddress.Hide();
                txtContact.Hide();
                txtName.Hide();
                txtPassword.Hide();
                btnEdit.Hide();
                lblA.Hide();
                lblC.Hide();
                lblN.Hide();
                lblp.Hide();
            }
            if (result == DialogResult.No)
            {
                txtAddress.Hide();
                txtContact.Hide();
                txtName.Hide();
                txtPassword.Hide();
                btnEdit.Hide();
                lblA.Hide();
                lblC.Hide();
                lblN.Hide();
                lblp.Hide();
            }

            
        }
    }
}
