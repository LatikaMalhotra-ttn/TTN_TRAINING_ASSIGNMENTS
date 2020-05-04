using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
namespace PracticalQues
{
    public partial class Calculator : System.Web.UI.Page
    {
        int ClickCount = 1;
        int ClickCount7 = 1;
        int ClickCount1 = 1;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (ViewState["Click"] == null)
                {
                    ViewState["Click"] = 0;
                }
                TextBox9.Text = ViewState["Click"].ToString();

                if(Session["Click1"] == null)
                {
                    Session["Click1"] = 0;
                }
                TextBox8.Text = Session["Click1"].ToString();

                if (Application["Clicks"] == null)
                {
                    Application["Clicks"] = 0;
                }
                TextBox3.Text = Application["Clicks"].ToString();
            }
        }
        public static double Evaluate(string expr)
        {
            DataTable table = new DataTable();
            return Convert.ToDouble(table.Compute(expr, String.Empty));
        }
        protected void btn_click(object sender, CommandEventArgs e)
        {
            switch (e.CommandName)
            {
                case "zero":
                    if (output.Text == "0" && output.Text != null)
                        output.Text = "0";
                    else
                        output.Text = output.Text + "0";
                    break;
                case "one":
                    if (output.Text == "0" && output.Text != null)
                        output.Text = "1";
                    else
                        output.Text = output.Text + "1";
                    break;
                case "two":
                    if (output.Text == "0" && output.Text != null)
                        output.Text = "2";
                    else
                        output.Text = output.Text + "2";
                    break;
                case "three":
                    if (output.Text == "0" && output.Text != null)
                        output.Text = "3";
                    else
                        output.Text = output.Text + "3";
                    break;
                case "four":
                    if (output.Text == "0" && output.Text != null)
                        output.Text = "4";
                    else
                        output.Text = output.Text + "4";
                    break;
                case "five":
                    if (output.Text == "0" && output.Text != null)
                        output.Text = "5";
                    else
                        output.Text = output.Text + "5";
                    break;
                case "six":
                    if (output.Text == "0" && output.Text != null)
                        output.Text = "6";
                    else
                        output.Text = output.Text + "6";
                    break;
                case "seven":
                    if (output.Text == "0" && output.Text != null)
                        output.Text = "7";
                    else
                        output.Text = output.Text + "7";
                    break;
                case "eight":
                    if (output.Text == "0" && output.Text != null)
                        output.Text = "8";
                    else
                        output.Text = output.Text + "8";
                    break;
                case "nine":
                    if (output.Text == "0" && output.Text != null)
                        output.Text = "9";
                    else
                        output.Text = output.Text + "9";
                    break;
                case "plus":
                    output.Text = output.Text + "+";
                    break;
                case "minus":
                    output.Text = output.Text + "-";
                    break;
                case "multiply":
                    output.Text = output.Text + "*";
                    break;
                case "divide":
                    output.Text = output.Text + "/";
                    break;
                case "clear":
                    output.Text = "0";
                    break;
                case "mod":
                    output.Text = output.Text + "%";
                    break;
                case "delete":
                    if (output.Text != null && output.Text != "0")
                    {
                        if (output.Text.Length > 1)
                            output.Text = output.Text.Substring(0, (output.Text.Length- 1));
                        else
                        {
                            output.Text = "0";
                        }
                    }
                    break;
                case "equal":
                    double results = Evaluate(output.Text);
                    output.Text = Convert.ToString(results);
                    break;
                case "dot":
                    output.Text = output.Text + ".";
                    break;
                default:
                    Response.Write("errroorr...");
                    break;
            }
        }

        protected void ButtonCheck_Click(object sender, EventArgs e)
        {

            int ClickCount = (int)ViewState["Click"] + 1;
            TextBox9.Text = ClickCount.ToString();
            ViewState["Click"] = ClickCount;
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            int ClickCount1 = (int)Session["Click1"] + 1;
            TextBox8.Text = ClickCount1.ToString();
            Session["Click1"] = ClickCount1;
        }

        protected void output_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button10_Click(object sender, EventArgs e)
        {
            int ClicksCount7 = (int)Application["Clicks"] + 1;
            TextBox3.Text = ClicksCount7.ToString();
            Application["Clicks"] = ClicksCount7;
        }
    }
}