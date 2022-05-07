using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace E_Pharma_App.HomeUC
{
    public partial class UC_Members : UserControl
    {
        function fn = new function();
        MyLogger log = new MyLogger();  
        String query;
        
        string imgLoc = "";
        public UC_Members()
        {
            InitializeComponent();
        }

        public string ID
        {
            set { usernameid.Text = value; }
        }

        
        

        byte[] ConvertImageToBytes(Image img)
        {
            using(MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }

        public Image ConvertByteArrayToImage(byte[] data)
        {
            using (MemoryStream ms = new MemoryStream(data))
            {
                return Image.FromStream(ms);
            }
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

            if(ofd.ShowDialog() == DialogResult.OK)
            {
            
                imgLoc = ofd.FileName.ToString();
                pictureBox1.ImageLocation = imgLoc;

            }
            
        }

        /// <summary>
        /// This will insert the member to the database
        /// </summary>
        


        private void btnaddmember_Click(object sender, EventArgs e)
        {
            
            string ConnectionString = "Server=BV4V2F3;Database=E-Pharma;User Id=sa;Password=7128Saru!@#;Trusted_Connection=False;MultipleActiveResultSets=True;";

            SqlConnection con = new SqlConnection(ConnectionString);

            
            try
            {
                byte[] img = null;
                FileStream fs = new FileStream(imgLoc, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                img=br.ReadBytes((int)fs.Length);
                query = "insert into Member(UserID,MemberN,Relation,DOB,Memdia,Pres)values('" + usernameid.Text + "','" + txtname.Text + "','" + txtcombo.Text + "','" + dateTimePicker1.Value.ToString() + "','" + txtdia.Text + "',@img)";

                if(con.State!= ConnectionState.Open)
                    con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.Add(new SqlParameter("@img", img));
                int x = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show(x.ToString() + "record(s)");

                
                UC_Members_Load(this,null);
                log.Log("Member is added");


            }
            catch (Exception ex)
            {
                con.Close();
                log.Log("btnaddmem" + ex.Message);
                MessageBox.Show(ex.Message);
            }



            txtcombo.Text = "";
            txtdia.Text = "";
            txtname.Text = "";
            pictureBox1.Image = null;
        }
        /// <summary>
        /// This will load all the members from the database of the particular user
        /// </summary>
      
        private void UC_Members_Load(object sender, EventArgs e)
        {
            try
            {
                string ConnectionString = "Server=BV4V2F3;Database=E-Pharma;User Id=sa;Password=7128Saru!@#;Trusted_Connection=False;MultipleActiveResultSets=True;";

                SqlConnection con = new SqlConnection(ConnectionString);

                con.Open();

                query = "select * from Member where UserID = '"+usernameid.Text+"'";
                SqlCommand cmd = new SqlCommand(query, con);

                var reader = cmd.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(reader);

                dataGridView1.DataSource = dt;

                con.Close();
                log.Log("Member is loaded");
            }
            catch (Exception ex)
            {
                log.Log("member_load" + ex.Message);
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            dataGridView1.CurrentRow.Selected = true;
            txtname.Text = dataGridView1.Rows[e.RowIndex].Cells["MemberN"].Value.ToString();
            txtcombo.Text = dataGridView1.Rows[e.RowIndex].Cells["Relation"].Value.ToString();
            txtdia.Text = dataGridView1.Rows[e.RowIndex].Cells["Memdia"].Value.ToString();
            dateTimePicker1.Text = dataGridView1.Rows[e.RowIndex].Cells["DOB"].Value.ToString();
            txtmemid.Text = dataGridView1.Rows[e.RowIndex].Cells["MemberId"].Value.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// This will update any of the fields in the database
        /// </summary>
        

        private void button2_Click(object sender, EventArgs e)
        {
            
            query = "update Member set MemberN = '" + txtname.Text + "',Relation='" + txtcombo.Text + "',Memdia='" + txtdia.Text + "',DOB='" + dateTimePicker1.Value.ToString() + "' where MemberId='" + txtmemid.Text.ToString() + "'";
            fn.setData(query, "Profile Updated!");
            UC_Members_Load(this,null);
            log.Log("Updated the member");


        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            
            txtname.Clear();
            txtdia.Clear();
            txtcombo.Text = "";
            txtmemid.Clear();
            

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}