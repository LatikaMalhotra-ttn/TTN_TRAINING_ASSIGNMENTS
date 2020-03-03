using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Ques_4
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string ConnectionString = ConfigurationManager.ConnectionStrings["ADO_Prac"].ConnectionString;
            using (SqlConnection connection_s = new SqlConnection(ConnectionString))
            {
                GridView1.Visible = true;
                SqlCommand cmd1 = new SqlCommand("SELECT * FROM Employee", connection_s);
                connection_s.Open();
                GridView1.DataSource = cmd1.ExecuteReader();
                GridView1.DataBind();
                Button1.Visible = false;
            }
            

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            GridView2.Visible = true;
            GridView3.Visible = true;
            string ConnectionString = ConfigurationManager.ConnectionStrings["ADO_Prac"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter("spGetEmployeeAndLoginData1", connection);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataSet dataset = new DataSet();
                dataAdapter.Fill(dataset);

                GridView2.DataSource = dataset.Tables[0];
                GridView2.DataBind();

                GridView3.DataSource = dataset.Tables[1];
                GridView3.DataBind();

                Button2.Visible = false;

                
            }
        }
    }
}