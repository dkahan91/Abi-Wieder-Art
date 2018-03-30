using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace WebApplication2
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
       
      
        
        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {

        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["User"] == null)
            {
                user.InnerHtml = "You are not logged in";
            }
            else {
                user.InnerHtml = "You are now logged in " + Session["User"];
            }
        }

        /*protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            string search = TextBox1.Text;
            string SQLQuery = "Select * from dbo.Product_Table Where [Product Name] Like '%" + search + "%'";
            using (SqlDataReader cat = SQLHelper.ExecuteQuery(SQLQuery))
            //, System.Data.CommandType.Text, new SqlParameter("@User", username), new SqlParameter("@Pass", password)))
            {
                results.InnerHtml = " ";
                while (cat.Read())
                    results.InnerHtml += " " + cat[0] + "<br>";

            }*/






    }
}