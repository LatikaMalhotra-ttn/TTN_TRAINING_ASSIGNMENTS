using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Ques_10
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            //Using try catch finally
            
            SqlConnection connection = new SqlConnection("data Source =.; database = ADO_ASSIGNMENT; User id = SA; password = Programmer@4");
            try
            {
                SqlCommand cmd = new SqlCommand("Select * from Employee", connection);
            
                            connection.Open();
                GridView1.DataSource = cmd.ExecuteReader();
                GridView1.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write("u are in catch block");
            }
            finally
            {
                connection.Close();
            }



            //using 'using' block
            using (SqlConnection connection1 = new SqlConnection("data Source=.;database=ADO_ASSIGNMENT;User id=SA;password=Programmer@4"))
            {
                SqlCommand cmd1 = new SqlCommand("Select * from Employee", connection1);
                connection1.Open();
                GridView2.DataSource = cmd1.ExecuteReader();
                GridView2.DataBind();
            }
        }
    }
}