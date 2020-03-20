using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entity_database_first_approch.Data;
using Entity_database_first_approch.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Entity_database_first_approch.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class IndexController : ControllerBase
    {

        public readonly ICustomer _customer;
        public IndexController(ICustomer customer)
        {
            _customer = customer;
        }


        //this method is used to get data from the customer and order table
        [HttpGet]
        public IActionResult GetData()
        {
            try
            {
                var result = _customer.GetData();
                return Ok(result);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }


        //this method is used to get the data from all the three tables by using id parameter which can have values 1,2,3,4,5,7,8 
        [HttpGet("{id}")]
        public IActionResult GetData1(int id)
        {

            var context = new entity_database_first_approchContext();

            var list = context.TblCustomer.Where(c => c.Id == id).Include(s => s.TblOrder).ThenInclude(s => s.Product).FirstOrDefault();
            return Ok(list);



        }


        //this method is used to insert values in tables
        [HttpPost]
        public IActionResult Insert(TblCustomer customer)
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
        [HttpPut("{id}")]
        public IActionResult Update(int id, TblOrder order)
        {
            var context = new entity_database_first_approchContext();
            var std = context.TblOrder.FirstOrDefault(s => s.Id == id); 
            std.CustomerId = order.CustomerId;
            context.SaveChanges();
            return Ok("Row Updated Successfully");
        }


        //[HttpPut]
        //public IActionResult UpdateData([FromBody]TblOrder order)
        //{
              
        //      try
        //      {
        //          if (order == null)
        //          {
        //             return Ok(BadRequest());
        //          }

        //          bool result = _customer.Update(order);
        //          if (result)
        //          {
        //             return Ok(new { Status = true });
        //          }
        //          else
        //          {
        //             return Ok(new { Status = false, description = "Unable to insert data" });
        //          }
        //      }
        //      catch (Exception ex)
        //      {

        //         throw ex;
        //      }
             
        //}



        //this method is used to delete values from customer using customer id
        [HttpDelete("{id}")]
        public IActionResult DeleteCustId(int id)
        {
            TblCustomer customer = new TblCustomer();
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
        [HttpDelete("{id}")]
        public IActionResult DeleteProdId(int id)
        {
            TblCustomer customer = new TblCustomer();
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