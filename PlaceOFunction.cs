using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Pharma_App
{
    /// <summary>
    /// Checks for the place function returns true if the record is added or returns false
    /// </summary>
    public class PlaceOFunction
    {
        function fn = new function();
        String query;

        public bool placeo(String usernameid, String medname, String medID, String username, String Member, String Quan, String dob,String totpri)
        {

            query = "insert into Orders (UserID,MedName,MedID,Member,Quantity" +
                            ",TotalPrice)values('" + usernameid + "','" + medname + "','" + medID + "','"
                            + Member + "','" + Quan + "','" + totpri + "')";
            fn.setData(query, "Order Placed");
            return true;
        }
    }
}
