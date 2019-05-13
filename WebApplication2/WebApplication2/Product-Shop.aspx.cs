using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace WebApplication2
{
    public partial class WebForm6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //int productsID = int.Parse(Request.QueryString["ID"]);
            //int a = 3;
            //list.InnerHtml = "ID is " + productsID;
            string query1 = "SELECT Product_Table.[Product Name],Product_Table.Price, Product_Table.Description,Product_Table.ID, Product_Images.[Is Main Image]" +
                "FROM dbo.Product_Table " +
            /*"INNER JOIN dbo.Product_Category ON dbo.Product_Table.[ID] = dbo.Product_Category.[Product ID] " +*/
            "INNER JOIN dbo.Product_Images ON dbo.Product_Table.[ID] =dbo.Product_Images.[Product ID];";
            //string query2 = "SELECT ID,Name FROM dbo.Categories WHERE ID LIKE " + productsID + ";";
            /*using (SqlDataReader productcat = SQLHelper.ExecuteQuery(query2))
            {
                while (productcat.Read())
                {
                    list.InnerHtml = "<h2>Products of " + productcat[1]+"<h2>";
                }
            }*/
            //int i = 0;
            //List<string> Deslist = new List<string>;
            string description= "test";
            string desc_mod;
            query.InnerHtml += "<table class='list_format'>";
            using (SqlDataReader productList = SQLHelper.ExecuteQuery(query1))
                if (productList.HasRows){
                    {
                        while (productList.Read())
                        {
                            description = (string)productList["Description"];
                            desc_mod = description.Substring(0, 150)+" ...";
                            query.InnerHtml += "<tr><td><div><a href = 'Product Page.aspx?ID=" + productList["ID"] + "'><img src="+ productList["Is Main Image"]+ "></a><a href = 'Product Page.aspx?ID=" + productList["ID"] + "'><p class='list_title'>"+ productList["Product Name"] + "</p></a><p class='list_desc'>" + desc_mod + "</p><p class='list_price'>" + "£"+ productList["Price"] + "</p><input type='button' value='Buy Now'/></div></td></tr>";
                        }
                    }
                }
            query.InnerHtml += "</table>";
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

            string search = TextBox1.Text;
            string query3 = "SELECT Product_Table.[Product Name],Product_Table.Price, Product_Table.Description,Product_Table.ID, Product_Images.[Is Main Image]" +
                "FROM dbo.Product_Table " +
            "INNER JOIN dbo.Product_Images ON dbo.Product_Table.[ID] =dbo.Product_Images.[Product ID] WHERE Product_Table.[Product Name] LIKE '%" + search + "%';";
            string description = "test";
            string desc_mod;
            query.InnerHtml = "<table class='list_format'>";
            using (SqlDataReader productList = SQLHelper.ExecuteQuery(query3))
                if (productList.HasRows)
                {
                    {
                        while (productList.Read())
                        {
                            description = (string)productList["Description"];
                            desc_mod = description.Substring(0, 150) + " ...";
                            query.InnerHtml += "<tr><td><div><a href = 'Product Page.aspx?ID=" + productList["ID"] + "'><img src=" + productList["Is Main Image"] + "></a><a href = 'Product Page.aspx?ID=" + productList["ID"] + "'><p class='list_title'>" + productList["Product Name"] + "</p></a><p class='list_desc'>" + desc_mod + "</p><p class='list_price'>" + "£" + productList["Price"] + "</p><input type='button' value='Buy Now'/></div></td></tr>";
                        }
                    }
                }
            query.InnerHtml += "</table>";
        }
    }
}

//"<a href='Product List.aspx?'>"+ "</a>" 