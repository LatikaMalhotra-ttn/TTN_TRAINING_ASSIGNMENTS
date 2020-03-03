using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Ques_5
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label2.Visible = false;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string CS = ConfigurationManager.ConnectionStrings["ADO_Prac"].ConnectionString;
            using (SqlConnection connection_s = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand("SP_Insert_Values_in_tb_login", connection_s);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;


                cmd.Parameters.AddWithValue("@Name", TextBox2.Text);
                cmd.Parameters.AddWithValue("@Email", TextBox1.Text);
                cmd.Parameters.AddWithValue("@Pass", TextBox3.Text);
                cmd.Parameters.AddWithValue("@conPass", TextBox4.Text);
                cmd.Parameters.AddWithValue("@mobile", TextBox5.Text);
                cmd.Parameters.AddWithValue("@gender", DropDownList1.SelectedValue);
                cmd.Parameters.AddWithValue("@age", TextBox6.Text);

                SqlParameter outParameter = new SqlParameter();
                outParameter.ParameterName = "@UserId";
                outParameter.SqlDbType = System.Data.SqlDbType.Int;
                outParameter.Direction = System.Data.ParameterDirection.Output;
                cmd.Parameters.Add(outParameter);


                connection_s.Open();
                cmd.ExecuteNonQuery();


                string UserId = outParameter.Value.ToString();
                Label2.Visible = true;
                Label2.Text = "User with id = " + UserId + " Signed in";
                connection_s.Close();
                Label1.Visible = false;
                table1.Visible = false;




            }

        }
    }
}