using PostOfficeManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using static System.Runtime.CompilerServices.RuntimeHelpers;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PostOfficeManagement
{
    public partial class employee : Form
    {
        public employee()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-NLDBQLGG\SQLEXPRESS;Initial Catalog=PostOffice;Integrated Security=True");


        private void employee_Load(object sender, EventArgs e)
        {
            txtEmployeeId.Focus();

            getEmployeeDetails();
        }

        private void getEmployeeDetails()
        {

            SqlCommand cmd = new SqlCommand("SELECT * FROM employee", conn);
            DataTable dt = new DataTable();

            conn.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            dt.Load(reader);
            conn.Close();

            dataGridViewEmployeeDetails.DataSource = dt;

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void clear()
        {
            txtEmployeeId.Clear();
            txtName.Clear();
            txtContact.Clear();
            cmbGender.Text = "";
            cmbEmployeeType.Text = "";
            cmbStatus.Text = "";
            txtAddress.Clear();
            txtPassword.Clear();
            txtSalary.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text.Length > 10 || txtPassword.Text.Length <= 0)
            {
                MessageBox.Show("Max password size is 10 characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Focus();
                return;
            }

            SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[employee] ([employeeId], [name], [gender], [contact], [address], [employeeType], [BasicSalary], [status], [hiredDate]) VALUES ('" + txtEmployeeId.Text + "', '" + txtName.Text + "', '" + cmbGender.SelectedItem.ToString() + "', '" + txtContact.Text + "', '" + txtAddress.Text + "', '" + cmbEmployeeType.SelectedItem.ToString() + "', '" + txtSalary.Text + "', '" + cmbStatus.SelectedItem.ToString() + "', '"+ DateTime.Now.ToShortDateString() + "')", conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            SqlCommand cmd1 = new SqlCommand(@"INSERT INTO [dbo].[logIn] ([employeeId], [password]) VALUES ('"+txtEmployeeId.Text+"', '"+txtPassword.Text+"')", conn);
            conn.Open();
            cmd1.ExecuteNonQuery();
            conn.Close();

            getEmployeeDetails();
        }

        private void dataGridViewEmployeeDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewEmployeeDetails.Rows[e.RowIndex];

                txtEmployeeId.Text = row.Cells["employeeId"].Value.ToString();
                txtName.Text = row.Cells["name"].Value.ToString();
                txtContact.Text = row.Cells["contact"].Value.ToString();
                txtSalary.Text = row.Cells["BasicSalary"].Value.ToString();
                txtAddress.Text = row.Cells["address"].Value.ToString();

                cmbEmployeeType.SelectedItem = row.Cells["employeeType"].Value.ToString();
                cmbGender.SelectedItem = row.Cells["gender"].Value.ToString();
                cmbStatus.SelectedItem = row.Cells["status"].Value.ToString();
            }

            SqlCommand cmd = new SqlCommand("SELECT [password] FROM [dbo].[login] where [employeeId] = '"+txtEmployeeId.Text+"'", conn);
            conn.Open();

            SqlDataReader myR = cmd.ExecuteReader();
            if (myR.HasRows)
            {
                while (myR.Read())
                {                                       
                    txtPassword.Text = myR[0].ToString();
                }
            }
            conn.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand(@"UPDATE [dbo].[employee] SET [employeeId] = '"+txtEmployeeId.Text+"', [name] = '"+txtName.Text+"', [gender] = '"+cmbGender.SelectedItem.ToString()+"', [contact] = '"+txtContact.Text+"', [address] = '"+txtAddress.Text+"', [employeeType] = '"+cmbEmployeeType.SelectedItem.ToString()+"', [BasicSalary] = '"+txtSalary.Text+"', [status] = '"+cmbStatus.SelectedItem.ToString()+ "' WHERE [employeeId] = '"+txtEmployeeId.Text+"'", conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            SqlCommand cmd1 = new SqlCommand(@"UPDATE [dbo].[logIn] SET [password] = '"+txtPassword.Text+"' WHERE [employeeId] = '"+txtEmployeeId.Text+"'", conn);
            conn.Open();
            cmd1.ExecuteNonQuery();
            conn.Close();
            getEmployeeDetails();
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
        }

        private void employee_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "Search by ID";
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT [employeeId], [name], [gender], [contact], [address], [employeeType], [BasicSalary], [status], [hiredDate] FROM [dbo].[employee] WHERE [employeeId] LIKE '%" + txtSearch.Text + "%';", conn);
            DataTable dt = new DataTable();
            DataView dv = dt.DefaultView;

            conn.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            dt.Load(reader);
            conn.Close();

            dataGridViewEmployeeDetails.DataSource = dt;
        }
    }
}
