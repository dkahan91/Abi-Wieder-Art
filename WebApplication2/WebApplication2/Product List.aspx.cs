using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace WebApplication2
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int productsID = int.Parse(Request.QueryString["ID"]);
            int a = 3;
            list.InnerHtml = "ID is " + productsID;
            string query1 = "SELECT Product_Table.[Product Name],Product_Table.ID, Product_Images.[Is Main Image]" +
                "FROM dbo.Product_Table " +
                "INNER JOIN dbo.Product_Category ON dbo.Product_Table.[ID] = dbo.Product_Category.[Product ID] " +
                "INNER JOIN dbo.Product_Images ON dbo.Product_Table.[ID] =dbo.Product_Images.[Product ID]" +
                "WHERE dbo.Product_Category.[Category ID]=" + productsID+";";
            string query2 = "SELECT ID,Name FROM dbo.Categories WHERE ID LIKE " + productsID + ";";
            using (SqlDataReader productcat = SQLHelper.ExecuteQuery(query2))
            {
                while (productcat.Read())
                {
                    list.InnerHtml = "<h2>Products of " + productcat[1]+"<h2>";
                }
            }

            using (SqlDataReader productList = SQLHelper.ExecuteQuery(query1))
            {
                while (productList.Read())
                    query.InnerHtml += "<a href = 'Product Page.aspx?ID=" + productList["ID"] + "'>" + productList["Product Name"] + "<img src="+productList["Is Main Image"]+ "></ a ><br>";

            }
                }
    }
}

//"<a href='Product List.aspx?'>"+ "</a>" 