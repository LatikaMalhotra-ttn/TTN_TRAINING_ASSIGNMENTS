using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Ques_2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string ConnectionString = ConfigurationManager.ConnectionStrings["ADO_Prac"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter("spGetEmployeeAndLoginData", connection);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataSet dataset = new DataSet();
                dataAdapter.Fill(dataset);

                GridView1.DataSource = dataset.Tables[0];
                GridView1.DataBind();

                GridView2.DataSource = dataset.Tables[1];
                GridView2.DataBind();

                GridView3.DataSource = dataset.Tables[2];
                GridView3.DataBind();
            }
        }
    }
}