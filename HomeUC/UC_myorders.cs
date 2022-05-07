using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DGVPrinterHelper;

namespace E_Pharma_App.HomeUC
{
    public partial class UC_myorders : UserControl
    {
        function fn = new function();
        MyLogger log = new MyLogger();
        String query;
        
        public UC_myorders()
        {
            InitializeComponent();
            
        }
        public string ID
        {
            set { usernameid.Text = value; }
        }
        /// <summary>
        /// This will load all the orders of the particular user
        /// </summary>
        
        private void UC_myorders_Load(object sender, EventArgs e)
        {
           
            try
            {
                string ConnectionString = "Server=BV4V2F3;Database=E-Pharma;User Id=sa;Password=7128Saru!@#;Trusted_Connection=False;MultipleActiveResultSets=True;";

                SqlConnection con = new SqlConnection(ConnectionString);

                con.Open();

                query = "select OrderID,OrderDate,MedName,Member,Quantity,TotalPrice from Orders where UserID = '" + usernameid.Text.ToString() + "'";
                SqlCommand cmd = new SqlCommand(query, con);

                var reader = cmd.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(reader);

                dataGridView1.DataSource = dt;

                con.Close();
                log.Log("Showing the orders");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                log.Log("uc_myorders_load"+ex.Message);
            }
            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        /// <summary>
        /// It will refresh the orders table
        /// </summary>
        
        private void btnrefresh_Click(object sender, EventArgs e)
        {
            UC_myorders_Load(this, null);
            log.Log("btnrefresh");
            MessageBox.Show("Updated Orders", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
         
        }






        public Int64 totamt;
        public Int64 valueamt;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                valueamt = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString());





            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        /*
         * Print Order
         */
        private void btncancel_Click(object sender, EventArgs e)
        {
            DGVPrinter print = new DGVPrinter();
            print.Title = "Medicine Bill";
            print.SubTitle = String.Format("Date:- {0} Time:-{1}", DateTime.Now.Date,DateTime.Now.TimeOfDay);
            print.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            print.PageNumbers = true;
            print.PageNumberInHeader = false;
            print.PorportionalColumns = true;
            print.HeaderCellAlignment = StringAlignment.Near;

            log.Log("Printing the orders bill");

            print.PrintDataGridView(dataGridView1);
        }
    }
}
