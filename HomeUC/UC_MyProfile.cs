using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace E_Pharma_App.HomeUC
{
    
    public partial class UC_MyProfile : UserControl 
    {
        function fn = new function();
        MyLogger log = new MyLogger();
        String query;
        public UC_MyProfile()
        {
            InitializeComponent();
        }
      
        public string ID
        { set { userNameLabel.Text = value; } 
        } 
        private void profilegrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void UC_MyProfile_Load(object sender, EventArgs e)
        {
            //query = "select * from Users";
            //DataSet ds = fn.getData(query);
            //profilegrid.DataSource = ds.Tables[0];
        }

        private void profilelabel_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //query = "select * from Users where UserName like '"+profilelabel+"'";
            //DataSet ds = fn.getData(query);
            //profilegrid.DataSource = ds.Tables[0];
        }

        /// <summary>
        /// This will take you to the forget password API
        /// </summary>
      
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ChangePassword cp = new ChangePassword();
            cp.Show();
            this.Hide();
        }
       /// <summary>
       /// This will update the Users table
       /// </summary>
     
        private void button1_Click(object sender, EventArgs e)
        {
            String firstname = txtfirstname.Text;
            String lastname = txtlastname.Text;
            String username = userNameLabel.Text;
            String password = txtpassword.Text;
            String dob = txtdob.Text;
            String email= txtemail.Text;
            String address = txtaddress.Text;

            
            query = "update Users set FirstName = '" + firstname + "',LastName='" + lastname + "',Password='" + password + "',DateOfBirth='" + dob + "',Email='" + email + "',Address='" + address + "' where UserID='"+username+"'";
            fn.setData(query, "Profile Updated!");
            log.Log("Updated Values");
        }
        /// <summary>
        /// This will show all the details of the particular User
        /// </summary>
      
        private void UC_MyProfile_Enter(object sender, EventArgs e)
        {
            query = "select * from Users where UserID='"+userNameLabel.Text+"'";
            DataSet ds = fn.getData(query);
            txtfirstname.Text = ds.Tables[0].Rows[0][1].ToString();
            txtlastname.Text = ds.Tables[0].Rows[0][2].ToString();
            txtusername.Text = ds.Tables[0].Rows[0][3].ToString();
            txtpassword.Text = ds.Tables[0].Rows[0][4].ToString();
            txtdob.Text = ds.Tables[0].Rows[0][5].ToString();
            txtemail.Text = ds.Tables[0].Rows[0][6].ToString();
            txtaddress.Text = ds.Tables[0].Rows[0][7].ToString();

            log.Log("Showing details");

        }
        /// <summary>
        /// This will reset the textboxes of both username and password to the original form
        /// </summary>
        
        private void btnreset_Click(object sender, EventArgs e)
        {
            UC_MyProfile_Enter(this,null);
        }
    }
}
