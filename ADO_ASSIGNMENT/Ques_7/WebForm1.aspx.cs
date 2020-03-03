using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace Ques_7
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            myfunc();
        }
        public void myfunc()
        {
            string CS = ConfigurationManager.ConnectionStrings["ADO_Prac"].ConnectionString;
            SqlConnection con = new SqlConnection(CS);

            con.Open();

            SqlCommand cmd1 = new SqlCommand("spGetEmployeeAccountData", con);
            cmd1.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataReader red = cmd1.ExecuteReader();
            GridView1.DataSource = red;
            GridView1.DataBind();


        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            string CS = ConfigurationManager.ConnectionStrings["ADO_Prac"].ConnectionString;
            SqlConnection con = new SqlConnection(CS);

            con.Open();
            SqlTransaction st = con.BeginTransaction();

            try
            {
                if (int.Parse(TextBox1.Text) == 100 || int.Parse(TextBox1.Text) == 101 || int.Parse(TextBox1.Text) == 102 || int.Parse(TextBox1.Text) == 103 || int.Parse(TextBox1.Text) == 104)
                {
                    if (int.Parse(TextBox2.Text) == 100 || int.Parse(TextBox2.Text) == 101 || int.Parse(TextBox2.Text) == 102 || int.Parse(TextBox2.Text) == 103 || int.Parse(TextBox2.Text) == 104)
                    {
                        SqlCommand cmd = new SqlCommand("spUpdateTable", con, st);
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@EmployeeId1", TextBox2.Text);
                        cmd.Parameters.AddWithValue("@EmployeeId2", TextBox1.Text);
                        cmd.ExecuteNonQuery();
                        st.Commit();


                        Label5.Visible = true;
                        Label5.Text = "Transaction complete";


                        GridView2.Visible = true;
                        SqlCommand cmd2 = new SqlCommand("spGetEmployeeAccountData", con);
                        cmd2.CommandType = System.Data.CommandType.StoredProcedure;
                        SqlDataReader red = cmd2.ExecuteReader();
                        GridView2.DataSource = red;
                        GridView2.DataBind();


                        //GridView1.Visible = false;
                        //TextBox1.Visible = false;
                        //TextBox2.Visible = false;
                        //Label2.Visible = false;
                        //Label3.Visible = false;
                        //Label4.Visible = false;
                        //Button1.Visible = false;
                        Panel1.Visible = false;
                    }
                    else
                    {
                        Label5.Visible = true;
                        Label5.Text = "Transaction Failed as you have not entered correct Employee Id";
                        Panel1.Visible = false;
                    }
                }
                else
                {
                    Label5.Visible = true;
                    Label5.Text = "Transaction Failed as you have not entered correct Employee Id";
                    Panel1.Visible = false;
                }
            }

            catch
            {
                st.Rollback();
                Label5.Text = "Transaction Failed";
                Panel1.Visible = false;
            }

            

        }

       
    }
}




