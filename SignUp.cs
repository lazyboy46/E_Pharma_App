using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace E_Pharma_App
{
    public partial class SignUp : Form

    {
        function fn = new function();
        MyLogger log = new MyLogger();
        String query;
        public SignUp()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This will be the exit button,it will exit the application
        /// </summary>
       
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// This will add the new user to the database after checking all the required fields
        /// </summary>
        

        private void button2_Click(object sender, EventArgs e)
        {
            String firstname = txtfirstname.Text;
            String lastname = txtlastname.Text;
            String dob = dateTimePicker1.Text;
            String email = txtemail.Text;
            String address = txtaddress.Text;
            String password = txtpassword.Text;
            String username = txtusername.Text;

            /* 
             * Validating for empty fields
             */

            if (String.IsNullOrEmpty(txtfirstname.Text))
            {
                MessageBox.Show("Please Enter FirstName", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtfirstname.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtlastname.Text))
            {
                MessageBox.Show("Please Enter LastName", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtlastname.Focus();
                return;
            }
            
            if (String.IsNullOrEmpty(txtusername.Text))
            {
                MessageBox.Show("Please Enter UserName", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtusername.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtpassword.Text))
            {
                MessageBox.Show("Please Enter Password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtpassword.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtemail.Text))
            {
                MessageBox.Show("Please Enter Email", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtemail.Focus();
                return;
            }
            
            if (String.IsNullOrEmpty(txtaddress.Text))
            {
                MessageBox.Show("Please Enter Address", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtaddress.Focus();
                return;
            }
            
            

            try
            {
                query = "insert into Users(FirstName,LastName,UserName,Password,DateOfBirth,Email,Address)values('" + firstname + "','" + lastname + "','" + username + "','" + password + "','" + dob + "','" + email + "','" + address + "')";

                fn.setData(query, "Sign Up Successful");
                log.Log("Inserted into the Database");
            }
            catch (Exception ex)
            {
                log.Log("insert" + ex.Message);
                Console.WriteLine(ex.Message);



                MessageBox.Show("Username Exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            Login login = new Login();
            login.Show();
            this.Hide();
        }

        /// <summary>
        /// Checking for existing username,if yes then show wrong symbol,if no then show right mark
        /// </summary>
        
        private void txtusername_TextChanged(object sender, EventArgs e)
        {
            query = "select * from Users where UserName = '" + txtusername.Text + "'";
            DataSet ds = fn.getData(query);

            if(ds.Tables[0].Rows.Count == 0)
            {
                pictureBox2.ImageLocation = @"C:\Users\SS098714\OneDrive - Cerner Corporation\Desktop\Icons\yes.png";
                
            }
            else
            {
                pictureBox2.ImageLocation = @"C:\Users\SS098714\OneDrive - Cerner Corporation\Desktop\Icons\no.png";
            }

        }
        /// <summary>
        /// Handles the regex opeartions
        /// </summary>
        /// <param name="re"> The Input String</param>
        /// <param name="tb">The Textbox</param>
        /// <param name="pc">Checks for true or false</param>
        public void regexp(string re, TextBox tb, PictureBox pc)
        {   try
            {
                Regex regex = new Regex(re);
                if (regex.IsMatch(tb.Text))
                {
                    pc.ImageLocation = @"C:\Users\SS098714\OneDrive - Cerner Corporation\Desktop\Icons\yes.png";
                }
                else
                {
                    pc.ImageLocation = @"C:\Users\SS098714\OneDrive - Cerner Corporation\Desktop\Icons\no.png";
                }

            }
            catch (Exception ex)
            {
                log.Log("regexp" + ex.Message);
                Console.WriteLine(ex.Message);
            }
            
        }

        private void txtfirstname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {
            regexp(@"^[a-zA-z0-9]{8,}$", txtpassword, passpicbox);

        }
        private void txtemail_TextChanged(object sender, EventArgs e)
        {
            regexp(@"^([\w]+)@([\w]+)\.([\w]+)$", txtemail, emailpicbox);
        }


        private void txtaddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }
    }
}
