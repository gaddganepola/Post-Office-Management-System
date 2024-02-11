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

namespace PostOfficeManagement
{
    public partial class acceptedLetters : Form
    {
        public acceptedLetters()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-NLDBQLGG\SQLEXPRESS;Initial Catalog=PostOffice;Integrated Security=True");


        private void acceptedLetters_Load(object sender, EventArgs e)
        {
            if (login.user.Contains("stf"))
            {
                txtLetterId.Hide();
                btnEdit.Hide();
                btnDelete.Hide();
            }

            cmbLetterType.SelectedIndex = 0;
            cmbStatus.SelectedIndex = 0;

            getAcceptedLettersDetails();
        }

        private void getAcceptedLettersDetails()
        {

            SqlCommand cmd = new SqlCommand("SELECT * FROM acceptedLetters", conn);
            DataTable dt = new DataTable();

            conn.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            dt.Load(reader);
            conn.Close();

            dataGridViewAcceptedLetters.DataSource = dt;

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (txtSender.Text == "")
            {
                MessageBox.Show("Please enter sender's address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSender.Focus();
                return;
            }
            if (txtReceiver.Text == "")
            {
                MessageBox.Show("Please enter receiver's address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtReceiver.Focus();
                return;
            }

            SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[acceptedLetters] ([senderAddress], [recipientAddress], [date], [locatForeign], [letterType]) VALUES ('"+txtSender.Text+"', '"+txtReceiver.Text+"', '"+ DateTime.Now.ToShortDateString() + "', '"+cmbStatus.SelectedItem.ToString()+"', '"+cmbLetterType.SelectedItem.ToString()+"')", conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            getAcceptedLettersDetails();

            txtReceiver.Clear();
            txtSender.Clear();
            cmbLetterType.SelectedIndex = 0;
            cmbStatus.SelectedIndex = 0;
            txtSender.Focus();
        }

        private void dataGridViewAcceptedLetters_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGridViewAcceptedLetters_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewAcceptedLetters.Rows[e.RowIndex];


                txtSender.Text = row.Cells["senderAddress"].Value.ToString();
                cmbLetterType.SelectedItem = row.Cells["letterType"].Value.ToString();
                cmbStatus.SelectedItem = row.Cells["locatForeign"].Value.ToString();
                txtReceiver.Text = row.Cells["recipientAddress"].Value.ToString();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand(@"UPDATE [dbo].[acceptedLetters] SET [senderAddress] = '"+txtSender.Text+"', [recipientAddress] = '"+txtReceiver.Text+"', [locatForeign] = '"+cmbStatus.SelectedItem.ToString()+"', [letterType] = '"+cmbLetterType.SelectedItem.ToString()+"' WHERE letterId = '"+txtLetterId.Text+"'", conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            getAcceptedLettersDetails();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtReceiver.Clear();
            txtSender.Clear();
            cmbLetterType.SelectedIndex = 0;
            cmbStatus.SelectedIndex = 0;
            txtSender.Focus();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand(@"DELETE FROM [dbo].[acceptedLetters] WHERE letterId = '" + txtLetterId.Text + "'", conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            getAcceptedLettersDetails();
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
        }

        private void txtLetterId_Click(object sender, EventArgs e)
        {
            txtLetterId.Clear();
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT [letterId], [senderAddress], [recipientAddress], [date], [locatForeign], [letterType] FROM [dbo].[acceptedLetters] WHERE recipientAddress LIKE '%" + txtSearch.Text + "%';", conn);
            DataTable dt = new DataTable();
            DataView dv = dt.DefaultView;

            conn.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            dt.Load(reader);
            conn.Close();

            dataGridViewAcceptedLetters.DataSource = dt;
        }

        private void acceptedLetters_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "Search by Receiver's Address...";
            txtLetterId.Text = "Enter Letter ID to Edit or Delete";
        }
    }
}
