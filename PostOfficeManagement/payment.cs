using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PostOfficeManagement
{
    public partial class payment : Form
    {
        public payment()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-NLDBQLGG\SQLEXPRESS;Initial Catalog=PostOffice;Integrated Security=True");

        private void cmbPaymentType_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnlAccount.Visible = false;
            pnlLife.Visible = false;
            pnlMobile.Visible = false;
            pnlVehicle.Visible = false;
            pnlOther.Visible = false;
            pnlExam.Visible = false;

            switch (cmbPaymentType.SelectedIndex)
            {
                case 0:
                case 1:
                    lblServiceCharge.Text = "20";
                    pnlAccount.Show();
                    break;
                case 2:
                case 3:
                    lblServiceCharge.Text = "20";
                    pnlMobile.Show();
                    break;
                case 4:
                    lblServiceCharge.Text = "50";
                    pnlLife.Show();
                    break;
                case 5:
                    lblServiceCharge.Text = "50";
                    pnlAccount.Visible = false;
                    pnlVehicle.Show();
                    break;
                case 6:
                    lblServiceCharge.Text = "10";
                    pnlExam.Show();
                    break;
                case 7:
                case 8:
                case 9:
                    lblServiceCharge.Text = "50";
                    pnlOther.Show();
                    break;

            }

        }

        private void payment_Load(object sender, EventArgs e)
        {
            pnlAccount.Visible = false;
            pnlLife.Visible = false;
            pnlMobile.Visible = false;
            pnlVehicle.Visible = false;
            pnlOther.Visible = false;
            pnlExam.Visible = false;

            getPaymentDetails();
        }

        private void getPaymentDetails()
        {

            SqlCommand cmd = new SqlCommand("SELECT [paymentId], [employeeId], [paymentType], [description], [date], [time], [amount] FROM [dbo].[payments]", conn);
            DataTable dt = new DataTable();

            conn.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            dt.Load(reader);
            conn.Close();

            dataGridViewPayment.DataSource = dt;

        }

        private bool IsNumeric(string input)
        {
            Regex regex = new Regex("^[0-9]+$");
            return regex.IsMatch(input);
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (cmbPaymentType.Text == "")
            {
                MessageBox.Show("Please enter payment type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbPaymentType.Focus();
                return;
            }
            if (txtAmount.Text == "")
            {
                MessageBox.Show("Please enter amount", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAmount.Focus();
                return;
            }
            else if (!IsNumeric(txtAmount.Text))
            {
                MessageBox.Show("Invalid amount", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAmount.Focus();
                return;
            }

            var result = MessageBox.Show("Confirm payment", "Payment Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                float totalAmount = float.Parse(txtAmount.Text) + float.Parse(lblServiceCharge.Text);

                SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[payments] ([employeeId], [paymentType], [description], [date], [time], [amount]) VALUES ('" + login.user + "', '" + cmbPaymentType.SelectedItem.ToString() + "', '" + txtAccount.Text + "' + '" + " " + "' + '" + txtTelephoneNumber.Text + "' + '" + "\n" + "' + '" + txtVehicalNumber.Text + "' + '" + " " + "' +'" + txtChassisNumber.Text + "' + '" + "\n" + "' + '" + txtPolicyNumber.Text + "' + '" + "\n" + "' + '" + txtExamCode.Text + "' + '" + "\n" + "' + '" + txtName.Text + "' + '" + " " + "' + '" + txtID.Text + "', '" + DateTime.Now.ToShortDateString() + "', '" + DateTime.Now.ToShortTimeString() + "', '" + totalAmount + "')", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                getPaymentDetails();
            }
            else if (result == DialogResult.No)
            {
                return;
            }

            

            txtAccount.Clear();
            txtTelephoneNumber.Clear();
            txtVehicalNumber.Clear();
            txtChassisNumber.Clear();
            txtPolicyNumber.Clear();
            txtExamCode.Clear();
            txtName.Clear();
            txtID.Clear();
            txtAmount.Clear();
            cmbPaymentType.Text = "";
            cmbPaymentType.Focus();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAccount.Clear();
            txtTelephoneNumber.Clear();
            txtVehicalNumber.Clear();
            txtChassisNumber.Clear();
            txtPolicyNumber.Clear();
            txtExamCode.Clear();
            txtName.Clear();
            txtID.Clear();
            txtAmount.Clear();
            cmbPaymentType.Text = "";
            cmbPaymentType.Focus();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM payments WHERE  date LIKE '%" + textBox2.Text + "%';", conn);
            DataTable dt = new DataTable();
            DataView dv = dt.DefaultView;

            conn.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            dt.Load(reader);
            conn.Close();

            dataGridViewPayment.DataSource = dt;
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }

        private void payment_Click(object sender, EventArgs e)
        {
            textBox2.Text = "mm/dd/yy";
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bitmap = new Bitmap(dataGridViewPayment.Width, dataGridViewPayment.Height);
            dataGridViewPayment.DrawToBitmap(bitmap, new Rectangle(0, 0, dataGridViewPayment.Width, dataGridViewPayment.Height));
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
