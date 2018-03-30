using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace WebApplication2
{
    public partial class cart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            using (SqlDataReader cart = SQLHelper.ExecuteQuery("SELECT * FROM dbo.Cart3"))
            {
                while (cart.Read())
                {
                    cartItems.InnerHtml += " "+ cart[0] +" " + cart[1] + cart[2]+"<br>";
                }
            }
        }
    }
}