using E_Pharma_App.HomeUC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Pharma_App
{
    public partial class Login : Form
    {
        function fn  = new function();
        MyLogger log = new MyLogger();
        String query;
        public Login() => InitializeComponent();
         
        /// <summary>
        /// This is a Exit Button,it will the exit the application
        /// </summary>
       
         
        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// This is a Reset Button,it will clear out both username and password
        /// </summary>
        
        private void btnreset_Click(object sender, EventArgs e)
        {   

            txtusername.Clear();
            txtpassword.Clear();
        }
        /// <summary>
        /// This is a login function where we take in username and password 
        /// </summary>
        /// <param name="username">Enter the username</param>
        /// <param name="password">Enter the password</param>

        internal void Login1(string username, string password)
        {
            string userid;
            if (String.IsNullOrEmpty(txtusername.Text))
            {
                MessageBox.Show("Please Enter Name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtusername.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtpassword.Text))
            {
                MessageBox.Show("Please Enter Password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtpassword.Focus();
                return;
            }
            try
            {
                query = "select * from Users where UserName  = '" + txtusername.Text + "' and Password = '" + txtpassword.Text + "'";

                DataSet ds = fn.getData(query);

                if (ds.Tables[0].Rows.Count != 0)
                {

                    
                    userid = ds.Tables[0].Rows[0]["UserID"].ToString();
                    Home hm = new Home(userid);  
                    hm.Show();                    
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Please Valid Username and Password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            catch (Exception ex)
            {   
                log.Log("login1"+ex.Message);
                Console.WriteLine(ex.Message);
            }
        }
        /// <summary>
        /// This is Login Button,verifies if the username and password is eligble then takes it into the Home Section
        /// </summary>
        
        private void btnlogin_Click(object sender, EventArgs e)

        {
            User LoginUser = new User();  
           bool res = LoginUser.Login12(txtusername.Text.Trim(), txtpassword.Text.Trim());

            try
            {

                if (res)
                    Login1(txtusername.Text.Trim(), txtpassword.Text.Trim());
                log.Log("Login Successfull");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                log.Log("btnlogin"+ex.Message);
            }

        }

    

        /// <summary>
        /// This will take into the new user section where user has to create an account 
        /// </summary>
       
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp up = new SignUp();
            up.Show();
            this.Hide();
        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {

        }
        
         /// <summary>
         /// This will take into the forget mail section where the user can reset his password
         /// </summary>
         
        private void forgotpassLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Send_Code send_Code = new Send_Code();
            send_Code.Show();
            this.Hide();
            
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
