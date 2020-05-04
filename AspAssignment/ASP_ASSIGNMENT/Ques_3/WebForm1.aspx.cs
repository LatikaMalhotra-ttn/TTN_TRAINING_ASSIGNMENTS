using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace Ques_3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                TextBox1.Focus();   //as soon as the page is loaded focus is given to username textbox
                DropDownList1.SelectedValue ="1";   //as soon as the page is loaded ->default valuue of dropdown is set to male
            }
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            string CS = ConfigurationManager.ConnectionStrings["ASP_Prac"].ConnectionString;
            using(SqlConnection connection_s=new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand("SP_INNSERT_VALUES_IN_TABLE",connection_s);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Name", TextBox1.Text);
                cmd.Parameters.AddWithValue("@Gender", DropDownList1.SelectedValue);
                cmd.Parameters.AddWithValue("@Salary", TextBox2.Text);

                SqlParameter outParameter = new SqlParameter();
                outParameter.ParameterName = "@EmployeeId";
                outParameter.SqlDbType = System.Data.SqlDbType.Int;
                outParameter.Direction = System.Data.ParameterDirection.Output;
                cmd.Parameters.Add(outParameter);


                connection_s.Open();
                cmd.ExecuteNonQuery();

                
                string EmployeeId = outParameter.Value.ToString();
                Label1.Text = "Employee with id = " + EmployeeId + " added and all employees of table are shown below";
                connection_s.Close();

                SqlCommand cmd1 = new SqlCommand("SELECT * FROM Employee", connection_s);
                connection_s.Open();
                GridView1.DataSource=cmd1.ExecuteReader();
                GridView1.DataBind();
                connection_s.Close();
            }
        }
    }
}