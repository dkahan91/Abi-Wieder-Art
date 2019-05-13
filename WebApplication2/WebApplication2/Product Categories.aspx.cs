using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace WebApplication2
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /*if (Session["User"] == null)
            {
                Response.Redirect("Login.aspx");
            }*/

            using (SqlDataReader cat = SQLHelper.ExecuteQuery("Select * From dbo.Categories"))
            {
                int i = 0;
                category.InnerHtml += "<table class='table_format'><tr>";
                while (cat.Read())
                {
                    if (i % 3 != 0 || i==0)
                    {
                        category.InnerHtml += "<td><div><a href='Product List.aspx?ID=" + cat["ID"] + "'>" + "<div class='grow pic'><img src=" + cat[2] + "></div></a><br><a href = 'Product List.aspx?ID=" + cat["ID"] + "'>" + cat[1] + "</a><p>" + cat[3] + "</p></div></td>";
                        i++;
                    }
                    else if (i % 3 == 0 && i!=0)
                    {
                        category.InnerHtml += "</tr><tr><td><div><a href='Product List.aspx?ID=" + cat["ID"] + "'>" + "<div class='grow pic'><img src=" + cat[2] + "></a></div><br><a href = 'Product List.aspx?ID=" + cat["ID"] + "'>" + cat[1] + "</a><p>"+cat[3]+"</p></div></td>";
                        i++;
                    }

                }
                category.InnerHtml += "</tr></table>";
            }
        }
    }
}