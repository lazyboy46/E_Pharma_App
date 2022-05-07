using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Pharma_App
{
    public class User
    {
        function fn = new function();
        String query;
        
        //String query2;
        public bool Login12(String user,String pwd)
        {
            //String gooduser = "as";
            //String goodpwd = "sa";
            String pass;
            query = "select Password from Users where UserName = '"+user+"' ";
            DataSet ds = fn.getData(query);
            pass = ds.Tables[0].Rows[0]["Password"].ToString();
            

            ////query2 = "select Password from Users where '" + pwd + "'";
            ////DataSet ds2 = fn.getData(query2);



            return ( 0 == string.Compare(pwd, pass));
        }
    }
}
