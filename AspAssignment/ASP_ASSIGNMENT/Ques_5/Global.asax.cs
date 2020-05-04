using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace Ques_5
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            // Create Application state variables
            Application["TotalApplicationsRunning"] = 0;
            Application["TotalUserSessionsRunning"] = 0;
            // Increment TotalApplications by 1
            Application["TotalApplicationsRunning"] = (int)Application["TotalApplicationsRunning"] + 1;
        }

        void Session_Start(object sender, EventArgs e)
        {
            // Increment TotalUserSessions by 1
            Application["TotalUserSessionsRunning"] = (int)Application["TotalUserSessionsRunning"] + 1;
        }
        void Session_End(object sender, EventArgs e)
        {
            // Decrement TotalUserSessions by 1
            Application["TotalUserSessionsRunning"] = (int)Application["TotalUserSessionsRunning"] - 1;
        }
    }



}