using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentApi.Models;
using StudentApi.Repository;

namespace StudentApi.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudent _student;
        public StudentController(IStudent student)
        {
            _student = student;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Students>> GetData()
        {
            return Ok(_student.GetStudents());
        }

        [HttpGet("{id}")]
        public ActionResult<Students> GetDataById(int id)
        {
            return Ok(_student.GetStudentById(id));
        }
        [HttpPost]
        public ActionResult<bool> InsertData(Students students)
        {
            try
            {
                bool insertedStudent = _student.AddStudent(students);
                if (insertedStudent)
                {
                    return Ok(true);
                }
                else
                {
                    return Ok(false);
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
         
        }
        [HttpPut]
        public ActionResult<bool> UpdateData(Students students)
        {
            try
            {
                bool updatedStudent = _student.EditStudent(students);
                if (updatedStudent)
                {
                    return Ok(true);
                }
                else
                {
                    return Ok(false);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}