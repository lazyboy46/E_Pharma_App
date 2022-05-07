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
    public partial class ChangePassword : Form
    {
        function fn = new function();
        MyLogger log = new MyLogger();
        String query;
        string username = Send_Code.to;
        public ChangePassword()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Handles the regex opeartions
        /// </summary>
        /// <param name="re"> The Input String</param>
        /// <param name="tb">The Textbox</param>
        /// <param name="pc">Checks for true or false</param>
        public void regexp(string re, TextBox tb, PictureBox pc)
        {
            try
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
                log.Log("regex" + ex.Message);
                Console.WriteLine(ex.Message);
            }

        }
       /// <summary>
       /// It will Update the Password of the particular user by validating for password and re-entered password
       /// </summary>
       

        private void btnpwreset_Click(object sender, EventArgs e)
        {
            

            try
            {



                if (txtnewpass.Text == txtrenewpass.Text)
                {
                    query = "update Users set Password ='" + txtrenewpass.Text + "' where Email ='" + username + "'";
                    fn.setData(query, "Password Reset Successfully!");
                    Login form = new Login();
                    form.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show(" Doesn't match with the new password...Try again");
                }
            }
            catch(Exception ex)
            {
                log.Log("btnreset"+ex.Message);
                MessageBox.Show(ex.Message);
            }
        }

        private void txtoldpass_TextChanged(object sender, EventArgs e)
        {
            regexp(@"^[a-zA-z0-9]{8,}$", txtnewpass, pictureBoxtick1);
        }

        private void txtnewpass_TextChanged(object sender, EventArgs e)
        {
            regexp(@"^[a-zA-z0-9]{8,}$",txtrenewpass, pictureBoxtick2);
        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {

        }
    }
}
