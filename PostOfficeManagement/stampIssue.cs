using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PostOfficeManagement
{
    public partial class stampIssue : Form
    {
        public stampIssue()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-NLDBQLGG\SQLEXPRESS;Initial Catalog=PostOffice;Integrated Security=True");


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void btnIssue_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please double check the availability of stamps before issue", "Stamp Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult result =  MessageBox.Show("Confermation availability", "Stamp Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                double price = 0;

                if (cb0.Checked == true)
                {
                    stamp(0.50, txt0.Text);
                    price = price + (0.50 * int.Parse(txt0.Text));
                }
                if (cb1.Checked == true)
                {
                    stamp(1, txt1.Text);
                    price = price + (1 * int.Parse(txt1.Text));

                }
                if (cb2.Checked == true)
                {
                    stamp(2, txt2.Text);
                    price = price + (2 * int.Parse(txt2.Text));

                }
                if (cb3.Checked == true)
                {
                    stamp(3, txt3.Text);
                    price = price + (3 * int.Parse(txt3.Text));

                }
                if (cb5.Checked == true)
                {
                    stamp(5, txt5.Text);
                    price = price + (5 * int.Parse(txt5.Text));

                }
                if (cb10.Checked == true)
                {
                    stamp(10, txt10.Text);
                    price = price + (10 * int.Parse(txt10.Text));

                }
                if (cb15.Checked == true)
                {
                    stamp(15, txt15.Text);
                    price = price + (15 * int.Parse(txt15.Text));

                }
                if (cb20.Checked == true)
                {
                    stamp(20, txt20.Text);
                    price = price + (20 * int.Parse(txt20.Text));

                }
                if (cb25.Checked == true)
                {
                    stamp(25, txt25.Text);
                    price = price + (25 * int.Parse(txt25.Text));

                }
                if (cb30.Checked == true)
                {
                    stamp(30, txt30.Text);
                    price = price + (30 * int.Parse(txt30.Text));

                }
                if (cb35.Checked == true)
                {
                    stamp(35, txt35.Text);
                    price = price + (35 * int.Parse(txt35.Text));

                }
                if (cb40.Checked == true)
                {
                    stamp(40, txt40.Text);
                    price = price + (40 * int.Parse(txt40.Text));

                }
                if (cb50.Checked == true)
                {
                    stamp(50, txt50.Text);
                    price = price + (50 * int.Parse(txt50.Text));

                }
                if (cb60.Checked == true)
                {
                    stamp(60, txt60.Text);
                    price = price + (60 * int.Parse(txt60.Text));

                }
                if (cb75.Checked == true)
                {
                    stamp(75, txt75.Text);
                    price = price + (75 * int.Parse(txt75.Text));

                }
                if (cb100.Checked == true)
                {
                    stamp(100, txt100.Text);
                    price = price + (100 * int.Parse(txt100.Text));

                }
                if (cb110.Checked == true)
                {
                    stamp(110, txt110.Text);
                    price = price + (110 * int.Parse(txt110.Text));

                }
                if (cb500.Checked == true)
                {
                    stamp(500, txt500.Text);
                    price = price + (500 * int.Parse(txt500.Text));

                }
                if (cb1000.Checked == true)
                {
                    stamp(1000, txt1000.Text);
                    price = price + (1000 * int.Parse(txt1000.Text));

                }

                lblStampPrice.Text = price.ToString();

                float stampAmount = float.Parse(lblStampPrice.Text);
                SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[payments] ([employeeId], [paymentType], [description], [date], [time], [amount]) VALUES ('" + login.user + "', '" + "Stamp Issue" + "', '"+"Stamp Issue"+"', '" + DateTime.Now.ToShortDateString() + "', '" + DateTime.Now.ToShortTimeString() + "', '" + stampAmount + "')", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                clear();
            }
            else if (result == DialogResult.No)
            {
                clear();
            }
        }

        private void clear()
        {
            initialize();
            cb0.Checked = false;
            cb1.Checked = false;
            cb2.Checked = false;
            cb3.Checked = false;
            cb5.Checked = false;
            cb10.Checked = false;
            cb15.Checked = false;
            cb20.Checked = false;
            cb25.Checked = false;
            cb30.Checked = false;
            cb35.Checked = false;
            cb40.Checked = false;
            cb50.Checked = false;
            cb60.Checked = false;
            cb75.Checked = false;
            cb100.Checked = false;
            cb110.Checked = false;
            cb500.Checked = false;
            cb1000.Checked = false;
            //lblStampPrice.Text = "";
        }

        private void stamp(double price, string amount)
        {
            int num = 0;
            int stampCount;
            int updateVal;

            stampCount = int.Parse(amount);
            SqlCommand cmd = new SqlCommand("SELECT quantity FROM [dbo].[stamp] WHERE stapmPrice = '"+price+"'", conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                num = int.Parse(reader["quantity"].ToString());


            }
            conn.Close();
            if (stampCount > num)
            {
                MessageBox.Show("");

            }
            else
            {
                updateVal = num - stampCount;
                SqlCommand cmd1 = new SqlCommand(@"UPDATE [dbo].[stamp] SET [quantity] = '" + updateVal + "' WHERE stapmPrice = '"+price+"'", conn);
                conn.Open();
                cmd1.ExecuteNonQuery();
                conn.Close();
                getStampDetails();
            }
        }

        private void lblPrice_Click(object sender, EventArgs e)
        {

        }

        private bool IsNumeric(string input)
        {
            Regex regex = new Regex("^[0-9]+$"); 
            return regex.IsMatch(input);
        }

        private void btnCal_Click(object sender, EventArgs e)
        {

            if (cmbLetterType.Text == "")
            {
                MessageBox.Show("Please enter letter type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbLetterType.Focus();
                return;
            }

            if (txtWeight.Text == "")
            {
                MessageBox.Show("Please enter weight", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtWeight.Focus();
                return;
            }
            else if (!IsNumeric(txtWeight.Text))
            {
                MessageBox.Show("Invalid weight", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtWeight.Focus();
                return;
            }
           

            if (cmbLetterType.SelectedIndex == 0)
            {
                weightAmount(50, 20, 10);
            }
            if (cmbLetterType.SelectedIndex == 1)
            {
                weightAmount(110, 20, 10);
            }
            if (cmbLetterType.SelectedIndex == 2)
            {
                weightAmount(150, 250, 50);
            }
            if (cmbLetterType.SelectedIndex == 3)
            {
                weightAmount(200, 250, 50);
            }
            if (cmbLetterType.SelectedIndex == 4)
            {
                lblPrice.Text = "30";
         
            }
        }

        private void weightAmount(double minPrice, double minWeight, double addedAmount)
        {
            

            double price = minPrice;
            for (double i = minWeight; i <= double.Parse(txtWeight.Text); i = i + minWeight)
            {
                price = price + addedAmount;
            }
            lblPrice.Text = price.ToString();
        }

        private void stampIssue_Load(object sender, EventArgs e)
        {
            if (login.user.Contains("stf"))
            {
                btnAddStamps.Hide();
            }

            initialize();
            getStampDetails();
        }

        private void getStampDetails()
        {

            SqlCommand cmd = new SqlCommand("SELECT * FROM [dbo].[stamp]", conn);
            DataTable dt = new DataTable();

            conn.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            dt.Load(reader);
            conn.Close();

            dataGridViewStampDetails.DataSource = dt;

        }

        private void cmbLetterType_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void addStamp(double price, string amount)
        {
            int num = 0;
            int stampCount;
            int updateVal;

            stampCount = int.Parse(amount);
            SqlCommand cmd = new SqlCommand("SELECT quantity FROM [dbo].[stamp] WHERE stapmPrice = '" + price + "'", conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                num = int.Parse(reader["quantity"].ToString());
                conn.Close();
                updateVal = num + stampCount;
                SqlCommand cmd1 = new SqlCommand(@"UPDATE [dbo].[stamp] SET [quantity] = '" + updateVal + "' WHERE stapmPrice = '" + price + "'", conn);
                conn.Open();
                cmd1.ExecuteNonQuery();
                conn.Close();
                getStampDetails();


            }
            
           
        }

        private void btnAddStamps_Click(object sender, EventArgs e)
        {
            if (cb0.Checked == true)
            {
                addStamp(0.50, txt0.Text);
               
            }
            if (cb1.Checked == true)
            {
                addStamp(1, txt1.Text);
                

            }
            if (cb2.Checked == true)
            {
                addStamp(2, txt2.Text);
                

            }
            if (cb3.Checked == true)
            {
                addStamp(3, txt3.Text);
                

            }
            if (cb5.Checked == true)
            {
                addStamp(5, txt5.Text);
                

            }
            if (cb10.Checked == true)
            {
                addStamp(10, txt10.Text);
               

            }
            if (cb15.Checked == true)
            {
                addStamp(15, txt15.Text);
                

            }
            if (cb20.Checked == true)
            {
                addStamp(20, txt20.Text);
                

            }
            if (cb25.Checked == true)
            {
                addStamp(25, txt25.Text);
                

            }
            if (cb30.Checked == true)
            {
                addStamp(30, txt30.Text);
               

            }
            if (cb35.Checked == true)
            {
                addStamp(35, txt35.Text);
               

            }
            if (cb40.Checked == true)
            {
                addStamp(40, txt40.Text);
               

            }
            if (cb50.Checked == true)
            {
                addStamp(50, txt50.Text);
               

            }
            if (cb60.Checked == true)
            {
                addStamp(60, txt60.Text);
               

            }
            if (cb75.Checked == true)
            {
                addStamp(75, txt75.Text);
                

            }
            if (cb100.Checked == true)
            {
                addStamp(100, txt100.Text);
               

            }
            if (cb110.Checked == true)
            {
                addStamp(110, txt110.Text);
               

            }
            if (cb500.Checked == true)
            {
                addStamp(500, txt500.Text);
                

            }
            if (cb1000.Checked == true)
            {
                addStamp(1000, txt1000.Text);
                

            }

            clear();
        }


        private void initialize()
        {
            txt0.Text = "0";
            txt1.Text = "0"; 
            txt2.Text = "0"; 
            txt3.Text = "0"; 
            txt5.Text = "0"; 
            txt10.Text = "0";
            txt15.Text = "0";
            txt20.Text = "0"; 
            txt25.Text = "0"; 
            txt30.Text = "0"; 
            txt35.Text = "0"; 
            txt40.Text = "0"; 
            txt50.Text = "0"; 
            txt60.Text = "0"; 
            txt75.Text = "0"; 
            txt1000.Text = "0"; 
            txt110.Text = "0"; 
            txt500.Text = "0";
            txt1000.Text = "0";

        }

        private void txt0_Click(object sender, EventArgs e)
        {
            txt0.Clear();
        }

        private void txt1_Click(object sender, EventArgs e)
        {
            txt1.Clear();
        }

        private void txt2_Click(object sender, EventArgs e)
        {
            txt2.Clear();
        }

        private void txt3_Click(object sender, EventArgs e)
        {
            txt3.Clear();
        }

        private void txt5_Click(object sender, EventArgs e)
        {
            txt5.Clear();
        }

        private void txt10_Click(object sender, EventArgs e)
        {
            txt10.Clear();
        }

        private void txt15_Click(object sender, EventArgs e)
        {
            txt15.Clear();
        }

        private void txt20_Click(object sender, EventArgs e)
        {
            txt20.Clear();
        }

        private void txt25_Click(object sender, EventArgs e)
        {
            txt25.Clear();
        }

        private void txt30_Click(object sender, EventArgs e)
        {
            txt30.Clear();
        }

        private void txt35_Click(object sender, EventArgs e)
        {
            txt35.Clear();
        }

        private void txt40_Click(object sender, EventArgs e)
        {
            txt40.Clear();
        }

        private void txt50_Click(object sender, EventArgs e)
        {
            txt50.Clear();
        }

        private void txt60_Click(object sender, EventArgs e)
        {
            txt60.Clear();
        }

        private void txt75_Click(object sender, EventArgs e)
        {
            txt75.Clear();
        }

        private void txt100_Click(object sender, EventArgs e)
        {
            txt100.Clear();
        }

        private void txt110_Click(object sender, EventArgs e)
        {
            txt110.Clear();
        }

        private void txt500_Click(object sender, EventArgs e)
        {
            txt500.Clear();
        }

        private void txt1000_Click(object sender, EventArgs e)
        {
            txt1000.Clear();
        }

        private void cb0_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtWeight.Clear();
            cmbLetterType.Text = "";
        }
    }
}
