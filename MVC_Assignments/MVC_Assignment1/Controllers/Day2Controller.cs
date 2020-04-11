using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Assignment1.Controllers
{
    public class Day2Controller : Controller
    {
        // GET: Day2
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
        /// Get Request of Extra through which i have shown use of render action
        /// </summary>
        /// <returns>View</returns>

        public ActionResult Extra()
        {
            return View();

        }


        /// <summary>
        /// Get Request of Using Render Action method 
        /// </summary>
        /// <returns>Partial View</returns>

        public PartialViewResult Using_RenerAction()
        {
            return PartialView("_PartialViewForRenderAction");
        }




        /// <summary>
        /// A non action method created 
        /// </summary>
        /// <returns>View</returns>
        [NonAction]
        public PartialViewResult Usage_of_NonAction() 
        {
            return PartialView("_PartialViewForRenderAction");
        }





        /// <summary>
        /// Get Request of Child Only  Action method created
        /// </summary>
        /// <returns>Partial View</returns>
        [ChildActionOnly]
        public PartialViewResult Usage_of_ChildAction() 
        {                                      
            return PartialView("_PartialViewForChildAction");
        }
    }
}