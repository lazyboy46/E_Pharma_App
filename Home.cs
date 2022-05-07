using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using E_Pharma_App.HomeUC;


namespace E_Pharma_App
{
    public partial class Home : Form
    {
        String user = "";
        function fn = new function();
        MyLogger log = new MyLogger();
        String query;
        public Home()
        {
            InitializeComponent();
        }
        public string ID
        {
            get { return user.ToString(); }
        }
        public Home(String username)
        {
            InitializeComponent();
            userlabel.Text = username;
            user = username;
            uC_MyProfile1.ID = ID;
            uC_SearchOrder1.ID = ID;
            uC_myorders1.ID = ID;
            uC_Members1.ID = ID;
        }
        /// <summary>
        /// Logging out from the application
        /// </summary>
  
        private void btnlogout_Click(object sender, EventArgs e)
        {
            Login fm = new Login();
            fm.Show();
            this.Hide();
            log.Log("Logged out");

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {
            uC_MyProfile1.Visible = false;
            uC_SearchOrder1.Visible = true;
            uC_SearchOrder1.BringToFront();  
            uC_myorders1.Visible = false;
            uC_Members1.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            uC_MyProfile1.Visible = true;
            uC_MyProfile1.BringToFront();
        }

        private void uC_MyProfile1_Load(object sender, EventArgs e)
        {
            query = "select * from Users where UserName = '" + userlabel.Text + "'";
            DataSet ds = fn.getData(query);           
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            uC_SearchOrder1.Visible = true;
            uC_SearchOrder1.BringToFront();
        }

        private void btnmyorders_Click(object sender, EventArgs e)
        {
            uC_myorders1.Visible = true;
            uC_myorders1.BringToFront();            
        }

        private void btnmembers_Click(object sender, EventArgs e)
        {
            uC_Members1.Visible = true;
            uC_Members1.BringToFront();
        }

        private void uC_MyProfile1_Load_1(object sender, EventArgs e)
        {

        }

        private void uC_MyProfile1_Load_2(object sender, EventArgs e)
        {

        }
    }
}
