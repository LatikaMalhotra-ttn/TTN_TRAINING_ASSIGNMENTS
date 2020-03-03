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
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string CS = ConfigurationManager.ConnectionStrings["ADO_Prac"].ConnectionString;
            using (SqlConnection con = new SqlConnection(CS))
            {

                //SQL INJECTION WOULD BE THERE IF UNDER QUERY IS EXECUTED

                //SqlCommand cmd = new SqlCommand(" Select * from tb_Login where (UserName like '" + TextBox1.Text + "')"+"AND (UserPassword like'" + TextBox2.Text+"')", connection);
                //connection.Open();
                //GridView1.DataSource = cmd.ExecuteReader();
                //GridView1.DataBind();



                //SQL INJECTION AVOIDED BY USING STORED PROCEDURE

                SqlCommand cmd = new SqlCommand("spGetLogin", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;


                cmd.Parameters.AddWithValue("@UserName", TextBox1.Text + "%");
                cmd.Parameters.AddWithValue("@Password", TextBox2.Text + "%");
                con.Open();

                GridView1.DataSource = cmd.ExecuteReader();
                GridView1.DataBind();

                if (GridView1.Rows.Count != 0)
                {
                    GridView1.Visible = true;
                    Label1.Text = "User - " + TextBox1.Text + " has successfully loged in and details of the user are as follows";
                    table12.Visible = false;
                }
                else
                {
                    Label1.Text = "Wrong credentaials";
                    table12.Visible = false;
                    GridView1.Visible = false;
                }
            }
        }
    }
}