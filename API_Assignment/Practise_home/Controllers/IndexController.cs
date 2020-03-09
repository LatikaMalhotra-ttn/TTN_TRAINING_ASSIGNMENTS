using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Practise_home.DATA;
using Practise_home.DB;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Practise_home.Controllers
{
    public class IndexController : ApiController
    {
        // Practise_home.DB.Employee dbemp = new Practise_home.DB.Employee();
        // Practise_home.DATA.EmployeeE DataEmp = new Practise_home.DATA.EmployeeE();
        DB.Employee employee = new DB.Employee();
        DATA.EmployeeE employeeE = new DATA.EmployeeE();

        [HttpGet]
        public IHttpActionResult GetData()
        {
            //EmployeeE employee = new EmployeeE();
            DataSet dataSet = employeeE.GetData();
           // DataSet ds = DataEmp.GetData();
            return Ok(dataSet);
        }

        public IHttpActionResult GetData(int id)
        {
            DataSet ds = employeeE.GetData(id);
            // DataSet ds = DataEmp.GetData(id);
            return Ok(ds);
        }

        [HttpPost]
        public IHttpActionResult InsertEmp(Employee emp)
        {
            try
            {
                if (emp == null)
                {
                    return Ok(BadRequest());
                }

                //employeeE.InsertEmp(emp);
                bool result = employeeE.InsertEmp(emp);
                if (result)
                {
                    return Ok(new { Status = true });
                }
                else
                {
                    return Ok(new { Status = false, description = " unable to insert data" });
                }

            }
            catch(Exception ex)
            {
                throw ex;

            }
            finally{

            }

        }
        [HttpPut]

        public IHttpActionResult UpdateData(int id, [FromBody]Employee emp)
        {
            //Student student = new Student();
            try
            {
                if (emp == null)
                {
                    return Ok(BadRequest());
                }
                bool result = employeeE.UpdateData(id, emp);
                if (result)
                {
                    return Ok(new { Status = true });
                }
                else
                {
                    return Ok(new { Status = false, description = "unable to update data" });
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        [HttpDelete]
        public IHttpActionResult DeleteEmp(int id)
        {

            try
            {
                if (employee == null)
                {
                    return Ok(BadRequest());
                }
                bool result = employeeE.DeleteEmp(id);
                if (result)
                {
                    return Ok(new { Status = true });
                }
                else
                {
                    return Ok(new { Status = false, description = "Something went wrong" });
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
