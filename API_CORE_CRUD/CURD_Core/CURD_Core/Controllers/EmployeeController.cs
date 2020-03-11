using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CURD_Core.DATA;
using CURD_Core.Model;
using System.Data;
using Microsoft.AspNetCore.Authorization;

namespace CURD_Core.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
       

        private readonly IEmployee _data;
        

        public EmployeeController(IEmployee data)
        {
            _data = data;
        }

        [HttpGet]
        public IActionResult GetData()
        {

            DataSet ds = _data.GetData();
            return Ok(ds);
        }

        [HttpGet("{id}")]
        public IActionResult GetDataId(int id)
        {
            DataSet ds = _data.GetDataId(id);
            return Ok(ds);
        }

        [HttpPost]
        public ActionResult<bool> InsertData(Employee employee)
        {

            try
            {
                if (employee == null)
                {
                    return Ok(BadRequest());
                }

                bool result = _data.InsertData(employee);
                if (result)
                {
                    return Ok(new { Status = true });
                }
                else
                {
                    return Ok(new { Status = false, description = " unable to insert data" });
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        [HttpPut("{id}")]
        public ActionResult<bool> UpdateData(int id, Employee employee)
        {

            try
            {
                if (employee == null)
                {
                    return Ok(BadRequest());
                }

                bool result = _data.UpdateData(id, employee);
                if (result)
                {
                    return Ok(new { Status = true });
                }
                else
                {
                    return Ok(new { Status = false, description = " unable to insert data" });
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        [HttpDelete("{id}")]
        public ActionResult<bool> DeleteData(int id)
        {

            Employee employee = new Employee();

            try
            {
                if (employee == null)
                {
                    return Ok(BadRequest());
                }

                bool result = _data.DeleteData(id);
                if (result)
                {
                    return Ok(new { Status = true });
                }
                else
                {
                    return Ok(new { Status = false, description = " unable to insert data" });
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}