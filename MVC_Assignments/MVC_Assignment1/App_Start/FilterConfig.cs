using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVC_Assignment1.App_Start
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }

        //Example of action filter
        public class MyLogActionFilter : ActionFilterAttribute
        {
            public override void OnActionExecuting(ActionExecutingContext filterContext)
            {
                Log("OnActionExecuting", filterContext.RouteData);
            }

            public override void OnActionExecuted(ActionExecutedContext filterContext)
            {
                Log("OnActionExecuted", filterContext.RouteData);
            }

            public override void OnResultExecuting(ResultExecutingContext filterContext)
            {
                Log("OnResultExecuting", filterContext.RouteData);
            }

            public override void OnResultExecuted(ResultExecutedContext filterContext)
            {
                Log("OnResultExecuted", filterContext.RouteData);
            }

            private void Log(string methodName, RouteData routeData)
            {
                var controllerName = routeData.Values["controller"];
                var actionName = routeData.Values["action"];

                var message = String.Format("{0} controller:{1} action:{2}", methodName, controllerName, actionName);

                Debug.WriteLine(message, "Action Filter Log");
            }
        }
        //Implementing IException Filter
        public class MyExceptionFilter : FilterAttribute, IExceptionFilter

        {

            public void OnException(ExceptionContext filterContext)

            {

                filterContext.Controller.ViewBag.onExceptionError = "ExceptionFilter called";

                filterContext.HttpContext.Response.Write("ExceptionFilter called");

            }

        }


        public class ExceptionClass : FilterAttribute, IExceptionFilter
        {
            public void OnException(ExceptionContext filterContext)
            {
                filterContext.Result = new ViewResult()
                {
                    ViewName = "Error"
                };
                filterContext.ExceptionHandled = true;
            }

        }
    }
}