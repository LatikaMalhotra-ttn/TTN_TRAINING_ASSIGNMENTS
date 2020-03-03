using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ques_5
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = "Number of Applications : " + Application["TotalApplicationsRunning"];

            Label2.Text = "Number of Users Online: " + Application["TotalUserSessionsRunning"];
            
            
        }
    }
}