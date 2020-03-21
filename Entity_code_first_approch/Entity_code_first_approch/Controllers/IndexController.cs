using Entity_code_first_approch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Entity_code_first_approch.Data;
using Microsoft.EntityFrameworkCore;
//using System.Web.Mvc;

namespace Entity_code_first_approch.Controllers
{
    public class IndexController : ApiController
    {
        CustomerClass _customer = new CustomerClass();
            
        //this method is used to get data from the customer and order table
        [HttpGet]
        public IHttpActionResult GetData()
        {
            try
            {
                var result = _customer.GetData();
                return Ok(result);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        //this method is used to get the data from all the three tables by using id parameter which can have values 1,2,3,4,5,7,8 
        [HttpGet]
        public IHttpActionResult GetData1(int id)
        {

            try
            {
                var context = new CustomerDBContext();

                var list = context.Customers.Where(c => c.CustomerId == id).Include(s => s.Orders).ThenInclude(s => s.Product).FirstOrDefault();

                return Ok(list);

            }
            catch(Exception ex)
            {
                throw ex;
            }

        }


        //this method is used to insert values in tables
        [HttpPost]
        public IHttpActionResult Insert(Customer customer)
        {
            try
            {
                if (customer == null)
                {
                    return Ok(BadRequest());
                }

                bool result = _customer.Insert(customer);
                if (result)
                {
                    return Ok(new { Status = true });
                }
                else
                {
                    return Ok(new { Status = false, description = "Unable to insert data" });
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }



        }



        //this method is used to update value in order(Customer id) table using order id as parameter 
        [HttpPut]
        public IHttpActionResult Update(int id, Order order)
        {
            try
            {
                var context = new CustomerDBContext();
                var std = context.Orders.FirstOrDefault(s => s.OrderId == id);
                std.CustomerID = order.CustomerID;
                context.SaveChanges();
                return Ok("Row Updated Successfully");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        //this method is used to delete values from customer using customer id
        [HttpDelete]
        public IHttpActionResult DeleteCustId(int id)
        {
            Customer customer = new Customer();
            try
            {
                if (customer == null)
                {
                    return Ok(BadRequest());
                }

                bool result = _customer.DeleteByCustId(id);
                if (result)
                {
                    return Ok(new { Status = true });
                }
                else
                {
                    return Ok(new { Status = false, description = "Unable to delete data" });
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }



        //this method is used to delete values from Product using Product id
        [HttpDelete]
        public IHttpActionResult DeleteProdId(int id)
        {
            Customer customer = new Customer();
            try
            {
                if (customer == null)
                {
                    return Ok(BadRequest());
                }

                bool result = _customer.DeleteByProdId(id);
                if (result)
                {
                    return Ok(new { Status = true });
                }
                else
                {
                    return Ok(new { Status = false, description = " unable to delete data" });
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}
