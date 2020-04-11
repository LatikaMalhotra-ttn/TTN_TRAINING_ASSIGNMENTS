using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVC_Assignment1.Models.Entity;

namespace MVC_Assignment1.Controllers
{
    [RoutePrefix("Employees")]
    public class EmployeesController : Controller
    {
        private EmployeeDBEntities1 db = new EmployeeDBEntities1();

        // GET: Employees
        public ActionResult Index()
        {
            return View(db.Employees.ToList());
        }


        [HttpGet]

        [Route("{id}")]
        // GET: Employees/5
        public ActionResult Details_Checking_Attribute_Routing(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee employee = db.Employees.Find(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }


        [HttpGet]

        [Route("{id}/Details_Checking_Attribute_Routing_Again")]
        // GET: Employees/5
        public ActionResult Details_Checking_Attribute_Routing_Again(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee employee = db.Employees.Find(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }


    }
}
