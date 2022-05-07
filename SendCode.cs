using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;


namespace E_Pharma_App
{
    
    public partial class Send_Code : Form
    {
        MyLogger log = new MyLogger();
        String OTPCode;
        public static string to;
        public Send_Code()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This will take in user email id and OTP will be sent to them
        /// </summary>
       

        private void btnsendotp_Click(object sender, EventArgs e)
        {
            try
            {
                string from, pass, msgbody;
                Random rand = new Random();
                OTPCode = (rand.Next(999999)).ToString();

                MailMessage mailMessage = new MailMessage();
                to = (txtusermail.Text).ToString();
                from = "epharamacerner@gmail.com";
                pass = "123!@#qwe!@#";
                msgbody = "Your Reset OTP code is " + OTPCode;
                mailMessage.To.Add(to);
                mailMessage.From = new MailAddress(from);
                mailMessage.Body = msgbody;
                mailMessage.Subject = "Forget Password code";

                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.EnableSsl = true;
                smtp.Port = 587;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Credentials = new NetworkCredential(from, pass);

                try
                {
                    smtp.Send(mailMessage);
                    MessageBox.Show("Verification code has been sent");
                    log.Log("OTP is sent");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            catch(Exception ex)
            {
                log.Log("btnsendotp" + ex.Message);
                MessageBox.Show(ex.Message);
            }
           
        }
        /// <summary>
        /// This will check for the otp and checking whether it is same as the otp that we sent before to the user
        /// </summary>
       

        private void btnverifyotp_Click(object sender, EventArgs e)
        {   try
            {


                if (OTPCode == (txtverifycode.Text).ToString())
                {
                    to = txtusermail.Text;
                    ChangePassword cg = new ChangePassword();
                    cg.Show();
                    this.Hide();
                    log.Log("OTP verification is done");

                }
                else
                {

                    MessageBox.Show("Wrong OTP");
                }
            }
            catch(Exception ex)
            {
                log.Log("btnverify" + ex.Message);
                MessageBox.Show(ex.Message);
            }
        }


    }
}
