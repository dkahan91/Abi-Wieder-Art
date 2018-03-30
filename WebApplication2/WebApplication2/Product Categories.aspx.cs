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
            using (SqlDataReader cat = SQLHelper.ExecuteQuery("Select ID,Name,[Category Image] From dbo.Categories"))
            {
                int i = 0;
                category.InnerHtml += "<table><tr>";
                while (cat.Read())
                {
                    if (i < 3)
                    {
                        category.InnerHtml += "<td><a href='Product List.aspx?ID=" + cat["ID"] + "'>" + "<img src=" + cat[2] + "></a><br><a href = 'Product List.aspx?ID=" + cat["ID"] + "'>" + cat[1] + "</a></td>";
                        i++;
                    }
                    else if (i == 3)
                    {
                        category.InnerHtml += "</tr><br/><tr><td><a href='Product List.aspx?ID=" + cat["ID"] + "'>" + "<img src=" + cat[2] + "></a><br><a href = 'Product List.aspx?ID=" + cat["ID"] + "'>" + cat[1] + "</a></td>";
                        i++;
                    }
                    else
                    {
                        category.InnerHtml += "<td><a href='Product List.aspx?ID=" + cat["ID"] + "'>" + "<img src=" + cat[2] + "></a><br><a href = 'Product List.aspx?ID=" + cat["ID"] + "'>" + cat[1] + "</a></td>";
                        i++;
                    }

                }
                category.InnerHtml += "</tr></table>";
            }
        }
    }
}