using Entity_code_first_approch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
//using System.Web.Mvc;

namespace Entity_code_first_approch.Controllers
{
    public class IndexController : ApiController
    {
        [HttpGet]
        public IHttpActionResult GetData()
        {
            var context = new CustomerDBContext();
            var result = from s in context.Customers
                         join o in context.Orders on s.Id equals o.CustomerID
                         select new
                         {
                             Customerid = s.Id,
                             firstName = s.FirstName,
                             secondName = s.LastName,
                             Email = s.Email,
                             orderId = o.Id
                         };
            return Ok(result);
        }






    }
}
