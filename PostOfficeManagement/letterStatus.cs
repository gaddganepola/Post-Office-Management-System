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
using static System.Runtime.CompilerServices.RuntimeHelpers;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PostOfficeManagement
{
    public partial class letterStatus : Form
    {
        public letterStatus()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-NLDBQLGG\SQLEXPRESS;Initial Catalog=PostOffice;Integrated Security=True");

        private void letterStatus_Load(object sender, EventArgs e)
        {

            cmbStatus.SelectedIndex = 0;
            lblDate.Text = DateTime.Now.ToShortDateString();

            getLetterDetails();
        }

        private void getLetterDetails()
        {

            SqlCommand cmd = new SqlCommand("SELECT letterId, employeeId, address, receivedDate, letterType, code, letterStatus, deliveredDate, person FROM receivedLetters", conn);
            DataTable dt = new DataTable();

            conn.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            dt.Load(reader);
            conn.Close();

            dataGridViewLetterStatus.DataSource = dt;

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLetterId.Text))
            {
                MessageBox.Show("Please enter a value in the Letter ID field.", "Required Field", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtLetterId.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPerson.Text))
            {
                MessageBox.Show("Please enter a value in the Name of the Person field.", "Required Field", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPerson.Focus();
                return;
            }


            SqlCommand cmd = new SqlCommand(@"UPDATE [dbo].[receivedLetters] SET [letterStatus] = '"+cmbStatus.SelectedItem.ToString()+"', [deliveredDate] = '"+ DateTime.Now.ToShortDateString() + "', [person] = '"+txtPerson.Text+"' WHERE letterId = '"+txtLetterId.Text+"'", conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            getLetterDetails();

            txtLetterId.Clear();
            txtPerson.Clear();
            cmbStatus.SelectedIndex = 0;
            txtLetterId.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT letterId, employeeId, address, receivedDate, letterType, code, letterStatus, deliveredDate, person FROM receivedLetters WHERE letterId = '" + txtLetterId.Text + "'", conn);
            DataTable dt = new DataTable();

            conn.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            dt.Load(reader);
            conn.Close();

            dataGridViewLetterStatus.DataSource = dt;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtLetterId.Clear();
            txtPerson.Clear();
            cmbStatus.SelectedIndex = 0;
            txtLetterId.Focus();
        }
    }
}
