using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace MVC_Assignment1.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundle(BundleCollection bundelCollection)
        {
            bundelCollection.Add(new ScriptBundle("~/bundle/script")
                 .Include("~/Temp/js/jquery.min.js",
                          "~/Temp/js/popper.js",
                          "~/Temp/js/bootstrap.min.js",
                          "~/Temp/js/main.js"
                          
                   ));
            bundelCollection.Add(new StyleBundle("~/bundle/css")
                    .Include("~/Content/bootstrap.css",
                        "~/Temp/css/style.css"
                  ));



        }

    }
}