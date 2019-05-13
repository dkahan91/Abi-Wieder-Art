using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace WebApplication2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        public SqlCommand command { get; private set; }

        //protected void Page_Load(object sender, EventArgs e)
        //{




        //local
        //String ConString = "Server=DESKTOP-GLHDHL3\\SQLEXPRESS;Database=TestDatabase;Connection timeout=5;Integrated Security=SSPI;";

        //String ConString = "Server=TRAINE-WIN8-T10\\SQLEXPRESS;Database=test;Connection timeout=5;Integrated Security=SSPI;";
        //String Query = "Select * from dbo.Users";

        //online
        //String ConString = "Data Source=mssql6.gear.host;Initial Catalog=paintshop;Integrated Security=False;user id=paintshop;password=Fb1s12!v2?5I";
        //String Query = "Select * from dbo.Customer_Table";

        /*using (SqlConnection conn = new SqlConnection(ConString))
        {
            try
            {
                conn.Open();
                form1.InnerHtml = "Opened Connection";
            }
            catch (Exception ex)
            {


                return;
            }
            SqlCommand command = new SqlCommand(Query, conn);

            SqlDataReader reader = command.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    Response.Write(reader[1] + " " + reader[2]);
                }
            }
            finally
            {
                // Always call Close when done reading.
                reader.Close();
            }
            }*/

        //}
        protected void Button1_Click(object sender, EventArgs e)
        {
            test.InnerHtml = "hello world";

            string username = uname.Text;
            string password = pword.Text;
            string SQLQuery = "Select [First Name], [Last Name],[ID] From dbo.Customer_Table Where Username = @User AND Passsword = @Pass";


            using (SqlDataReader cat = SQLHelper.ExecuteQuery(SQLQuery, System.Data.CommandType.Text, new SqlParameter("@User", username), new SqlParameter("@Pass", password)))
            {
                /*while (cat.Read())
                    details.InnerHtml += " " + cat[0] + " " + cat[1] + "<br>";*/

                if (cat.HasRows)
                {
                    cat.Read();
                    Session["User"] = cat["First Name"];
                    Session["ID"] = cat["ID"];
                    Response.Redirect("Product%20Categories.aspx");
                }
                else
                {
                    details.InnerHtml = "You have not entered the correct credentials. Try again";
                }
            }







        }


        protected void Button2_Click1(object sender, EventArgs e)
        {
            test1.InnerHtml = "hello world";
            string first_name = f_name.Text;
            string last_name = l_name.Text;
            string username = new_user.Text;
            string password = new_pw.Text;
            string email = new_email.Text;
            string SQLQuery2 = "INSERT INTO dbo.Customer_Table([First Name], [Last Name],[Username],[Passsword],[Email Address]) VALUES('" + first_name + "','" + last_name + "','"+ username + "','" + password + "','"+ email + "')";
            SQLHelper.ExecuteQuery(SQLQuery2);
            

            /*using (SqlDataReader cat = SQLHelper.ExecuteQuery(SQLQuery))
            //, System.Data.CommandType.Text, new SqlParameter("@User", username), new SqlParameter("@Pass", password), new SqlParameter("@emai", email)))
            {
                while (cat.Read())
                    details.InnerHtml += " " + cat[0] + " " + cat[1] + "<br>";

                if (cat.HasRows)
                {
                    cat.Read();
                    Session["User"] = cat["First Name"];
                    Session["ID"] = cat["ID"];
                    Response.Redirect("Product%20Categories.aspx");
                }
                else
                {
                    details2.InnerHtml = "You have not entered the correct credentials. Try again";
                }*/
            details2.InnerHtml = "You have successfully created a new user - please login above.";
            
        }
    }
}