using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ques_10
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label3.Visible = false;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

               
                try
                {
                    int number = int.Parse(TextBox1.Text);
                    int divisor = int.Parse(TextBox2.Text);
                    Panel1.Visible = false;
                    Response.Write("Number: " + number+"<br/>");
                    Response.Write("Divisor: " + divisor+ "<br/>");
                    Response.Write("Quotient: " + number / divisor+ "<br/>");
                }
                catch (DivideByZeroException)
                {

                   Response.Write("Not possible to Divide by zero");
                }
                catch (FormatException)
                {
                    Response.Write("Enter only integer numbers");
                    Panel1.Visible = false;
                }
                catch (Exception)
                {
                    Response.Write("Unhandled exception");
                }
                
        }
    }
}