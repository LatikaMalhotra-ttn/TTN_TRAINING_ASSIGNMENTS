using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ques_7
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Label2.Visible = false;
                OutputLabel.Visible = false;
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            Label2.Visible = true;
            Label2.Text = "Button Click event handled here";
        }
        

        protected void CommandButton_Click(object sender, CommandEventArgs e)
        {
            switch (e.CommandName)
            {
                case "Button1":
                    OutputLabel.Visible = true;
                    OutputLabel.Text = "Button1 Command event handled (Command Button)";
                    break;
                case "Print":
                    OutputLabel.Visible = true;
                    OutputLabel.Text = "You clicked Print Button (Command Button)";
                    if (Label2.Text != " ")
                    {
                        Label2.Text = " ";
                        Label2.Visible = false;
                    }
                    break;
                case "Delete":
                    OutputLabel.Visible = true;
                    OutputLabel.Text = "You clicked Delete Button (Command Button)";
                    if (Label2.Text != " ")
                    {
                        Label2.Text = " ";
                        Label2.Visible = false;
                    }
                    break;
                case "Show":
                    if (e.CommandArgument.ToString() == "Top10")
                    {
                        OutputLabel.Visible = true;
                        OutputLabel.Text = "Button 4 handled here (Command Button)";
                        if (Label2.Text != " ")
                        {
                            Label2.Text = " ";
                            Label2.Visible = false;
                           
                        }
                    }
                    else
                    {
                        OutputLabel.Visible = true;
                        OutputLabel.Text = "Button 5 handled here (Command Button)";
                        if (Label2.Text != " ")
                        {
                            Label2.Text = " ";
                            Label2.Visible = false;
                        }
                    }
                    break;
                default:
                    OutputLabel.Visible = true;
                    OutputLabel.Text = "We don't know which button you clicked";
                    break;
            }
        }

        protected void Bottom10Button_Click(object sender, EventArgs e)
        {

        }
    }
}