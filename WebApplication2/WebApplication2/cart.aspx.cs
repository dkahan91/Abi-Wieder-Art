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

            using (SqlDataReader cart = SQLHelper.ExecuteQuery("SELECT Product_Table.[Product Name],Product_Table.Price FROM dbo.Product_Table INNER JOIN dbo.Cart3 ON dbo.Product_Table.ID = dbo.Cart3.[Product ID] WHERE dbo.Cart3.[Cutomer ID]=" + Session["ID"] + ";"))
            {
                while (cart.Read())
                {
                    cartItems.InnerHtml += " " + cart[0] + "£" + cart[1]  + "<br>";
                }
            }
        }
    }
}