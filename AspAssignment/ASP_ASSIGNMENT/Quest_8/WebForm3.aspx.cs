﻿//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Web.UI;
//using System.Data;
//using System.Data.SqlClient;
//using System.Configuration;
//using System.Web.UI.WebControls;
//using System.Web.Security;

//namespace Quest_8
//{
//    public partial class WebForm3 : System.Web.UI.Page
//    {
//        protected void Page_Load(object sender, EventArgs e)
//        {

//        }

//        protected void Button1_Click(object sender, EventArgs e)
//        {
//            if (TextBox1.Text == "admin" && TextBox2.Text == "12345")
//            {
//                //if (FormsAuthentication.Authenticate(TextBox1.Text, TextBox2.Text))
//                //{
//                    FormsAuthentication.RedirectFromLoginPage(TextBox1.Text, true);

//                //}

//                string CS = ConfigurationManager.ConnectionStrings["ASP_Prac"].ConnectionString;
//                using (SqlConnection con = new SqlConnection(CS))
//                {
//                    SqlCommand cmd = new SqlCommand("spGetLogin", con);
//                    cmd.CommandType = System.Data.CommandType.StoredProcedure;


//                    cmd.Parameters.AddWithValue("@UserName", TextBox1.Text + "%");
//                    cmd.Parameters.AddWithValue("@Password", TextBox2.Text + "%");
//                    con.Open();

//                    GridView1.DataSource = cmd.ExecuteReader();
//                    GridView1.DataBind();

//                    if (GridView1.Rows.Count != 0)
//                    {
//                        GridView1.Visible = true;
//                        Label1.Text = "User-" + TextBox1.Text + "has successfully loged in and details of the user are as follows";
//                        table12.Visible = false;
//                    }
//                    else
//                    {
//                        Label1.Text = "Wrong credentaials";
//                        table12.Visible = false;
//                        GridView1.Visible = false;
//                    }
//                }
//            }
//        }
//    }
//}















using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Web.UI.WebControls;

namespace Quest_8
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string CS = ConfigurationManager.ConnectionStrings["ASP_Prac"].ConnectionString;
            using (SqlConnection con = new SqlConnection(CS))
            {
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
                    Label1.Text = "User- " + TextBox1.Text + "has successfully loged in and details of the user are as follows";
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