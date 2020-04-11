using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static MVC_Assignment1.App_Start.FilterConfig;

namespace MVC_Assignment1.Controllers
{
   
    [MyLogActionFilter] 
    [MyExceptionFilter] 
    public class Day3Controller : Controller
    {
        // GET: Day3
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Get Request of Ques1
        /// </summary>
        /// <returns>View</returns>

        public ActionResult Ques1()
        {
            return View();

        }

        /// <summary>
        /// Get Request of Ques2
        /// </summary>
        /// <returns>View</returns>

        public ActionResult Ques2()
        {
            return View();

        }


        /// <summary>
        /// Get Request of Ques3
        /// </summary>
        /// <returns>View</returns>

        public ActionResult Ques3()
        {
            return View();

        }

        /// <summary>
        /// Get Request of Ques4
        /// </summary>
        /// <returns>View</returns>

        public ActionResult Ques4()
        {
            return View();

        }


        /// <summary>
        /// Get Request of Ques5
        /// </summary>
        /// <returns>View</returns>

        public ActionResult Ques5()
        {
            return View();

        }



        /// <summary>
        /// Get Request of GetStrinf method on which i have used filters
        /// </summary>
        /// <returns>string</returns>

        [HandleError(Order =2)]   
        [OutputCache(Order=1,Duration = 15)] 
        public string GetString()
        {
            return "Testing Result Filter";
        }


        /// <summary>
        /// Get Request of GetCurrentTime  on which i have used filters
        /// </summary>
        /// <returns>string</returns>

        [OutputCache(Duration = 20)] 
        public string GetCurrentTime()
        {
            return DateTime.Now.ToString("T");
        }



        /// <summary>
        /// Get Request of Error_Page to show use of Iexception filter
        /// </summary>
        /// <returns>View</returns>

        [ExceptionClass]
        public ActionResult Error_page()
        {
            try
            {
                return View();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}