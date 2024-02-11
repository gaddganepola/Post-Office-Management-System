using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace PostOfficeManagement
{
    public partial class letterData : Form
    {
        public letterData()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-NLDBQLGG\SQLEXPRESS;Initial Catalog=PostOffice;Integrated Security=True");

        private void letterData_Load(object sender, EventArgs e)
        {
            if (login.user.Contains("emp"))
            {
                lblLetterId.Hide();
                btnEdit.Hide();
            }

            cmbLetterType.SelectedIndex = 0;
            String date = DateTime.Now.ToShortDateString();

            

            getLetterDetails();


        }

        private void getLetterDetails()
        {

            SqlCommand cmd = new SqlCommand("SELECT letterId, employeeId, address, receivedDate, letterType, code FROM receivedLetters", conn);
            DataTable dt = new DataTable();

            conn.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            dt.Load(reader);
            conn.Close();

            dataGridViewLetterData.DataSource = dt;

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {

            if (txtAddress.Text == "")
            {
                MessageBox.Show("Enter letter address", "Letter Date Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAddress.Focus();
                return;
            }
            
            if (cmbLetterType.SelectedIndex != 0 || cmbLetterType.SelectedIndex != 4 || cmbLetterType.SelectedIndex != 5)
            {
                if (txtCode.Text == "")
                {
                    MessageBox.Show("Enter letter code", "Letter Date Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCode.Focus();
                    return;
                }
            }
            

                SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[receivedLetters]([employeeId], [address], [receivedDate], [letterType], [code], [letterStatus],[deliveredDate], [person]) VALUES ('" + login.user + "', '" + txtAddress.Text + "', '" + DateTime.Now.ToShortDateString() + "', '" + cmbLetterType.SelectedItem.ToString() + "', '" + txtCode.Text + "', '" + "On Premise" + "', '" + "Not Delivered Yet" + "', '" + "Not Delivered Yet" + "')", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                getLetterDetails();

            txtCode.Clear();
            txtAddress.Clear();
            cmbLetterType.SelectedIndex = 0;
            txtAddress.Focus();





        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbLetterType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbLetterType.SelectedItem.ToString())
            {
                case "Normal" :
                case "Open Post":
                case "Newspaper":
                    txtCode.Text = "None";
                    txtCode.Hide();
                    lblCode.Hide();
                    break;

                case "Register":
                case "Parcel":
                case "Speed Post":
                    txtCode.Text = "";
                    txtCode.Show();
                    lblCode.Show();
                    break;

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCode.Clear();
            txtAddress.Clear();
            cmbLetterType.SelectedIndex = 0;
            txtAddress.Focus();
        }

        private void dataGridViewLetterData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewLetterData.Rows[e.RowIndex];


                txtAddress.Text = row.Cells["address"].Value.ToString();
                cmbLetterType.SelectedItem = row.Cells["letterType"].Value.ToString();
                txtCode.Text = row.Cells["code"].Value.ToString();
                lblLetterId.Text = row.Cells["letterId"].Value.ToString();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand(@"UPDATE [dbo].[receivedLetters] SET [address] = '"+txtAddress.Text+"', [letterType] = '"+cmbLetterType.SelectedItem.ToString()+"', [code] = '"+txtCode.Text+"' WHERE [letterId] = '"+lblLetterId.Text+"'", conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            getLetterDetails();
        }
    }
}
