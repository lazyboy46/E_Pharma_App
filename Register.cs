using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Pharma_App
{
    public class Register
    {
        /// <summary>      
        /// Checks for the Register function returns true if the record is added or returns false
        /// </summary>
        function fn = new function();
        String query;
        public bool Regi1(String firstname, String lastname , String dob, String username, String password, String email,String address)
        {
            
            query = "insert into Users(FirstName,LastName,UserName,Password,DateOfBirth,Email,Address)values('" + firstname + "','" + lastname + "','" + username + "','" + password + "','" + dob + "','" + email + "','" + address + "')";
            fn.setData(query, "Done");
            return true;
        }

    }
}
