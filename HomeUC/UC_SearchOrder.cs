using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Pharma_App.HomeUC
{
    public partial class UC_SearchOrder : UserControl
    {
        function fn = new function();
        MyLogger log = new MyLogger();
        String query;
        DataSet ds;
        string imgLoc = "";
        public UC_SearchOrder()
        {
            InitializeComponent();
        }
        public string ID
        {
            set { usernameid.Text = value; }
        }
        /// <summary>
        /// This is browse button which helps to upload a document from the local desktop
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Please select the precripion";
            ofd.Filter = "JPG|*.jpg|PNG|*.png";
            ofd.Multiselect = false;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                
                imgLoc = ofd.FileName.ToString();
                

            }
        }
        /// <summary>
        /// This is will load all the medicines in the database
        /// </summary>
        private void UC_SearchOrder_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            query = "select MedName from Medic where Quantity>0";
            ds = fn.getData(query);
            for(int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                listBox1.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }
        /// <summary>
        /// This will search for the medicines as the user type in
        /// </summary>
        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear ();

            query = "select MedName from Medic where Medname like '" + txtsearch.Text + "%'";
            ds = fn.getData(query);
            
            for(int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                listBox1.Items.Add (ds.Tables[0].Rows[i][0].ToString());
            }
        }
        /// <summary>
        /// Load the meds as when we select
        /// </summary>


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtquantity.Clear();
            String name = listBox1.GetItemText(listBox1.SelectedItem);
            txtmedname.Text = name;

            query = "select MedID,PerUnit,Diagosis from Medic where MedName = '" + name+"'";
            ds = fn.getData (query);

            txtmedid.Text = ds.Tables[0].Rows[0][0].ToString();
            txtperunit.Text = ds.Tables[0].Rows[0][1].ToString();
            
            txtdia.Text = ds.Tables[0].Rows[0][2].ToString();

        }
        
        private void txtquantity_TextChanged(object sender, EventArgs e)
        {
            if(txtquantity.Text != "")
            {
                Int64 unitprice = Int64.Parse(txtperunit.Text);
                Int64 Noofunits = Int64.Parse(txtquantity.Text);
                Int64 Totalamt = unitprice * Noofunits;
                txttotprice.Text = Totalamt.ToString();
            }
           
        }

        public int n, totamt = 0;
        protected Int64 quantity, newquantity;

        int valueamt;
        String valueid;
        protected Int64 noofunit;

        /// <summary>
        /// Select the appropriate row and place the order
        /// </summary>
       
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                valueamt = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString());
                valueid = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                noofunit = Int64.Parse(dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Select the appropriate row and remove the order
        /// </summary>
        private void btnremove_Click(object sender, EventArgs e)
        {
            if(valueid != null)
            {
                try
                {
                    dataGridView1.Rows.RemoveAt(this.dataGridView1.SelectedRows[0].Index);
                }
                catch(Exception ex)
                {
                    log.Log("remove" + ex.Message);
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    query = "select Quantity from Medic where MedID = '" + valueid + "'";
                    ds = fn.getData(query);
                    quantity = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                    newquantity = quantity + noofunit;

                    query = "update Medic set Quantity='" + newquantity + "' where MedID='" + valueid + "'";
                    fn.setData(query, "Medicine Removed from Cart");
                    totamt = totamt - valueamt;
                    totprilabel.Text = "Rs." + totamt.ToString();
                }
                UC_SearchOrder_Load(this, null);
                log.Log("Removed from the Cart");
            }
        }


        /// <summary>
        /// ADD the cart
        /// </summary>

        private void cartbtn_Click(object sender, EventArgs e)
        {
            string query1 = "select PresReq from Medic where MedID='" + txtmedid.Text + "'";
            ds = fn.getData(query1);
            string checktorf = ds.Tables[0].Rows[0]["PresReq"].ToString();
           if ( checktorf == "false")
           {



                if (txtmedid.Text != "")
                {
                    query = "select Quantity from Medic where MedID='" + txtmedid.Text + "'";
                    ds = fn.getData(query);

                    quantity = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                    newquantity = quantity - Int64.Parse(txtquantity.Text);

                    try
                    {
                        if (newquantity >= 0)
                        {
                            n = dataGridView1.Rows.Add();
                            dataGridView1.Rows[n].Cells[0].Value = txtmedid.Text;
                            dataGridView1.Rows[n].Cells[1].Value = txtmedname.Text;
                            dataGridView1.Rows[n].Cells[2].Value = txtdia.Text;
                            dataGridView1.Rows[n].Cells[3].Value = membercombo.Text;
                            
                            dataGridView1.Rows[n].Cells[4].Value = txtquantity.Text;
                            dataGridView1.Rows[n].Cells[5].Value = txttotprice.Text;
                            dataGridView1.Rows[n].Cells[6].Value = imgLoc;

                            totamt = totamt + int.Parse(txttotprice.Text);
                            totprilabel.Text = "Rs. " + totamt.ToString();

                            query = "update Medic set Quantity = '" + newquantity + "'where MedID = '" + txtmedid.Text + "'";
                            fn.setData(query, "Medicine Added");
                            log.Log("Added to the cart");
                        }


                        else
                        {
                            MessageBox.Show("Out of Stock", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        }
                        clearall();
                        UC_SearchOrder_Load(this, null);
                        
                    }
                    catch (Exception ex)
                    {
                        log.Log("cartbtn" + ex.Message);
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Select Medicine First", "Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

           }
           else if(checktorf == "true")
           {
                if (imgLoc == "")
                {
                    MessageBox.Show("Add Presciption", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {             

                    if (txtmedid.Text != "")
                    {
                        query = "select Quantity from Medic where MedID='" + txtmedid.Text + "'";
                        ds = fn.getData(query);

                        quantity = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                        newquantity = quantity - Int64.Parse(txtquantity.Text);

                        try
                        {
                            if (newquantity >= 0)
                            {
                                n = dataGridView1.Rows.Add();
                                dataGridView1.Rows[n].Cells[0].Value = txtmedid.Text;
                                dataGridView1.Rows[n].Cells[1].Value = txtmedname.Text;
                                dataGridView1.Rows[n].Cells[2].Value = txtdia.Text;
                                dataGridView1.Rows[n].Cells[3].Value = membercombo.Text;
                             
                                dataGridView1.Rows[n].Cells[4].Value = txtquantity.Text;
                                dataGridView1.Rows[n].Cells[5].Value = txttotprice.Text;
                                dataGridView1.Rows[n].Cells[6].Value = imgLoc;
                                totamt = totamt + int.Parse(txttotprice.Text);
                                totprilabel.Text = "Rs. " + totamt.ToString();

                                query = "update Medic set Quantity = '" + newquantity + "'where MedID = '" + txtmedid.Text + "'";
                                fn.setData(query, "Medicine Added");
                                log.Log("Added to the cart");
                            }


                            else
                            {
                                MessageBox.Show("Out of Stock", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                            }
                            clearall();
                            UC_SearchOrder_Load(this, null);
                        }
                        catch (Exception ex)
                        {
                            log.Log("btncart" + ex.Message);
                            MessageBox.Show(ex.Message);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Select Medicine First", "Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                
            
            }
            
        }

        /*
         * CLEAR ALL 
         */
        private void clearall()
        {
            txtmedid.Clear();
            txtmedname.Clear();
            txtdia.Clear();
            //txtmdate.Clear();
            txtperunit.Clear();
            txtquantity.Clear();
            membercombo.ResetText();
            txttotprice.Clear();
        }

        /// <summary>
        /// Select the appropriate row and place the order
        /// </summary>
        private void btnplaceorder_Click(object sender, EventArgs e)
        {
            String img1 = String.Empty;



                string ConnectionString = "Server=BV4V2F3;Database=E-Pharma;User Id=sa;Password=7128Saru!@#;Trusted_Connection=False;MultipleActiveResultSets=True;";

                SqlConnection con = new SqlConnection(ConnectionString);


                try
                {
                    if (dataGridView1.Rows.Count > 0)
                    {
                        String medID = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                        String medname = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                       
                        String Member = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
               
                        String Quan = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                        String totpri = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();



                        if (!String.IsNullOrEmpty(dataGridView1.SelectedRows[0].Cells[6].Value.ToString()))
                        {
                            
                            img1 = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                            byte[] img = null;
                            FileStream fs = new FileStream(img1, FileMode.Open, FileAccess.Read);
                            BinaryReader br = new BinaryReader(fs);
                            img = br.ReadBytes((int)fs.Length);
                            query = "insert into Orders (UserID,MedName,MedID,Member,Quantity,OrderDate" +
                                    ",TotalPrice,Pres)values('" + usernameid.Text + "','" + medname + "','" + medID + "','"
                                    + Member + "','" + Quan + "','" + DateTime.Now.Date
                                    + "','" + totpri + "',@img)";

                            if (con.State != ConnectionState.Open)
                                con.Open();
                            SqlCommand cmd = new SqlCommand(query, con);
                            cmd.Parameters.Add(new SqlParameter("@img", img));
                            int x = cmd.ExecuteNonQuery();
                            con.Close();
                            
                            MessageBox.Show(x.ToString() + " Order Placed!");
                             totamt = totamt - int.Parse(totpri);
                            totprilabel.Text = "Rs. " + totamt.ToString();
                            log.Log("Placed the order");
                    }
                        else
                        {
                        query = "insert into Orders (UserID,MedName,MedID,Member,Quantity,OrderDate" +
                            ",TotalPrice)values('" + usernameid.Text + "','" + medname + "','" + medID + "','"
                            + Member + "','" + Quan + "','" + DateTime.Now.Date
                            + "','" + totpri + "')";
                        fn.setData(query, "Order Placed");
                        totamt = totamt -  int.Parse(totpri);
                         totprilabel.Text = "Rs. " + totamt.ToString();
                        log.Log("Placed the order");

                    }


                }
                }
                catch (Exception ex)
                {
                    con.Close();
                    log.Log("btnplace" + ex.Message);
                    MessageBox.Show(ex.Message);
                }
                finally
                {
               
                dataGridView1.Rows.RemoveAt(this.dataGridView1.SelectedRows[0].Index);
                }

        }


        }
}
