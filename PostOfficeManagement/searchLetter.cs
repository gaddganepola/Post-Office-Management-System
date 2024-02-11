using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PostOfficeManagement
{
    public partial class searchLetter : Form
    {
        public searchLetter()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-NLDBQLGG\SQLEXPRESS;Initial Catalog=PostOffice;Integrated Security=True");

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
           
          
        }

        private void searchLetter_Load(object sender, EventArgs e)
        {
            if (login.user.Contains("stf"))
            {
                textBox1.Hide();
                btnPrint.Hide();
            }

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

            dataGridViewSearchLetter.DataSource = dt;

        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT letterId, employeeId, address, receivedDate, letterType, code, letterStatus, deliveredDate, person FROM receivedLetters WHERE address LIKE '%" + txtSearch.Text + "%';", conn);
            DataTable dt = new DataTable();
            DataView dv = dt.DefaultView;

            conn.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            dt.Load(reader);
            conn.Close();

            dataGridViewSearchLetter.DataSource = dt;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
        }

        private void searchLetter_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "Search By Address";
            textBox1.Text = "Enter Employee ID";
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT letterId, employeeId, address, receivedDate, letterType, code, letterStatus, deliveredDate, person FROM receivedLetters WHERE employeeId LIKE '%"+textBox1.Text+"%' AND letterStatus = '" + "On Premise" + "';", conn);
            DataTable dt = new DataTable();
            DataView dv = dt.DefaultView;

            conn.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            dt.Load(reader);
            conn.Close();

            dataGridViewSearchLetter.DataSource = dt;
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bitmap = new Bitmap(dataGridViewSearchLetter.Width, dataGridViewSearchLetter.Height);
            dataGridViewSearchLetter.DrawToBitmap(bitmap, new Rectangle(0, 0, dataGridViewSearchLetter.Width, dataGridViewSearchLetter.Height));
            e.Graphics.DrawImage(bitmap, 1, 1);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();
        }
    }
}
