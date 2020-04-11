using MVC_Assignment1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Assignment1.Controllers
{
    public class Day1Controller : Controller
    {
        // GET: Question
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
        /// Get Request of Passing Data From Controller To View
        /// </summary>
        /// <returns>View</returns>

        public ActionResult Passing_Data_From_Controller_ToView()
        {
            Student student1 = new Student{
                Roll_No=4056,
                Name="Latika",
                PhoneNumber=43801286
            };


            Student student2 = new Student
            {
                Roll_No=4028,
                Name="Deepak",
                PhoneNumber=43834286
            };
            ViewData["StudentDetail"] = student2;   //passing data usinng View data
            

            ViewBag.StudentDetail = student1;   //passing data using view bag


            TempData["Professor_Name"] = "Komalavalli";   //passing data throuugh temp data


            return View();
        }

        /// <summary>
        /// Get Request of Passing Data From View To controller
        /// </summary>
        /// <returns>View</returns>


        public ActionResult Passing_Data_From_View_To_controller()
        {
            return View();
        }


        /// <summary>
        /// Post Request of Passing Data From View To controller using request
        /// </summary>
        /// <returns>string</returns>



        [HttpPost]

        public string Create_Using_Request()
        {
            try
            {
                int Roll_Number =Convert.ToInt32( Request["Roll_Number"]);   //getting roll no using request
                string Student_Name = Request["Student_Name"];   //getting name using request
                int Phone_Number = Convert.ToInt32(Request["Phone_Number"]);   //getting phone number using request
                return "From parameters : " + Roll_Number + " has name " + Student_Name + "and his phone number is " + Phone_Number;
                
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        /// <summary>
        /// Post Request of Passing Data From View To controller using form collection
        /// </summary>
        /// <returns>string</returns>

        [HttpPost]
        public string Create_Using_Form_Collection(FormCollection formCollection)
        {
            try
            {
                int Roll_Number = Convert.ToInt32(formCollection["Roll_Number"]);  //getting roll no using form collection
                string Student_Name = formCollection["Student_Name"];  //etting name using form collection
                int Phone_Number = Convert.ToInt32(formCollection["Phone_Number"]);   //getting phone number using form collection
                return "From parameters : " + Roll_Number + " has name " + Student_Name + "and his phone number is " + Phone_Number;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }





        /// <summary>
        /// Post Request of Passing Data From View To controller using parameters
        /// </summary>
        /// <returns>string</returns>

        [HttpPost]
        public string Create_Using_Parameter(int Roll_Number,string Student_Name,int Phone_Number)   //got all data from view using parameters
        {
            try
            {
                return "From parameters : " + Roll_Number + " has name " + Student_Name + "and his phone number is " + Phone_Number;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}