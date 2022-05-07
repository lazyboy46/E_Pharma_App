using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace E_Pharma_App
{
    class function
    {
        /// <summary>
        /// This checks for the SQL Connection 
        /// </summary>
        /// <returns>returns true if there is connection </returns>
        protected SqlConnection getConnection()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Server=BV4V2F3;Database=E-Pharma;User Id=sa;Password=7128Saru!@#;Trusted_Connection=False;MultipleActiveResultSets=True;";
            return con;
        }
        /// <summary>
        /// This takes care about the SELECT statement query
        /// </summary>
        /// <param name="query">The query</param>
        /// <returns>return the data from the database</returns>
        public DataSet getData(String query)
        {
            SqlConnection con = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = query;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            return ds;
        }
        /// <summary>
        /// This takes care about the CRUD Operations
        /// </summary>
        
        public void setData(String query,String msg)
        {
            SqlConnection con = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show(msg,"Information",MessageBoxButtons.OK,MessageBoxIcon.Information);


        }

    }
}
