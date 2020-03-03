using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace Ques_6
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLoadData_Click(object sender, EventArgs e)
        {
            
            if (Cache["Data"] == null)
            {
            
                string CS = ConfigurationManager.ConnectionStrings["ADO_Prac"].ConnectionString;
                using (SqlConnection connection = new SqlConnection(CS))
                {
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("Select * from Employee", connection);
                    DataSet dataset = new DataSet();
                    dataAdapter.Fill(dataset);

                    gvProducts.DataSource = dataset;
                    gvProducts.DataBind();

            
                    Cache["Data"] = dataset;
                    lblMessage.Text = "Data loaded from the Database";
                }
            }
            
            else
            {
            
                gvProducts.DataSource = (DataSet)Cache["Data"];
                gvProducts.DataBind();
                lblMessage.Text = "Data loaded from the Cache";
            }

        }

        protected void btnClearnCache_Click(object sender, EventArgs e)
        {
            
            if (Cache["Data"] != null)
            {
            
                Cache.Remove("Data");
                lblMessage.Text = "DataSet removed from the cache";
            }
            
            else
            {
                lblMessage.Text = "There is nothing in the cache to remove";
            }
        }
    }
}