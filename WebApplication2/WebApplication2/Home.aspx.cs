using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class Welcome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        /*protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            string SQLQuery = "Select * from dbo.Product_Table Where [Product Name] Like '% + @search + %'";
        }
        using (SqlDataReader cat = SQLHelper.ExecuteQuery(SQLQuery, System.Data.CommandType.Text, new SqlParameter("@search", username), new SqlParameter("@Pass", password)))
   {
       while (cat.Read())
           details.InnerHtml += " " + cat[0] + cat[1] + "<br>";

   }*/
    }
}