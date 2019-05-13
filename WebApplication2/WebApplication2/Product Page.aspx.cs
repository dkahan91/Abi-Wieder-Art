using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace WebApplication2
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int productItem = int.Parse(Request.QueryString["ID"]);
            //int a = 2;
            using (SqlDataReader product = SQLHelper.ExecuteQuery("Select dbo.Product_Table.[Product Name], dbo.Product_Table.[Price],dbo.Product_Table.[Description], dbo.Product_Images.[Is Main Image], dbo.Product_Images.[Image name]  From dbo.Product_Table LEFT JOIN dbo.Product_Images ON dbo.Product_Table.[ID]=dbo.Product_Images.[Product ID] WHERE dbo.Product_Table.[ID] = " + productItem + ";"))

            {

                while (product.Read())
                {
                    product_placeholder.InnerHtml = " " + "<h2>" + product["Product Name"] + "</h2><br>" + "<div class='view_product'><img src=" + product["Is Main Image"] + "><p>" + product["Image name"] + "</p><p class='view_price'>"+ "£" + product["Price"] +"</p><p class='view_desc'>"+ product["Description"] + "</p></div>";
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int productID = int.Parse(Request.QueryString["ID"]);
            SQLHelper.ExecuteNonQuery("INSERT INTO dbo.Cart3([Cutomer ID],[Product ID],Quantity) VALUES("+Session["ID"]+", " + productID + ",1)");
            //
        }
    }
}