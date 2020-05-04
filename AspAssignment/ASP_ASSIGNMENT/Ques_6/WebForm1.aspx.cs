using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ques_6
{
    public partial class WebForm1 : System.Web.UI.Page
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

                if (Session["Click1"] == null)
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

        protected void Button10_Click(object sender, EventArgs e)
        {
            int ClicksCount7 = (int)Application["Clicks"] + 1;
            TextBox3.Text = ClicksCount7.ToString();
            Application["Clicks"] = ClicksCount7;

        }
    }
}