using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Ques_3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string CS = ConfigurationManager.ConnectionStrings["ADO_Prac"].ConnectionString;
            using (SqlConnection connection_s = new SqlConnection(CS))
            {
                
                SqlCommand cmd = new SqlCommand("Select * from Employee", connection_s);
                connection_s.Open();
          
                GridView1.DataSource = cmd.ExecuteReader();
                GridView1.DataBind();
                connection_s.Close();


                SqlCommand cmd1 = new SqlCommand("Select Count(Emp_Id) from Employee", connection_s);
                connection_s.Open();
                int TotalRows = (int)cmd1.ExecuteScalar();
                Label6.Text = "Total Rows in employee table are :" + TotalRows;

                //SqlCommand cmd3 = new SqlCommand();
                cmd.CommandText = "INSERT INTO Employee(Emp_name,Emp_Gender,Salary) Values('shagun',2,1234)";
                
                int rowsAffected = cmd.ExecuteNonQuery();
                Label5.Text = "deleted Rows= " + rowsAffected;
                
            }
        }
    }
}