using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackEndDotNetValidation.Dtos.Student;
using BackEndDotNetValidation.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BackEndDotNetValidation.Controllers
{
    [Route("[controller]")]
    public class StudentController : ApiControllerBase
    {
        private readonly IStudentService _studentService;

        public StudentController(IStudentService studentService,
            ILogger<StudentController> logger)
            : base(logger)
        {
            _studentService = studentService;
        }

        [HttpGet("GetAll")]   
        public ActionResult<List<StudentDto>> GetAll () {
            try {
                return Ok(_studentService.GetAll());

            }
            catch (Exception ex)
            {
                return HandleException(ex);
            }
        }


        [HttpGet("GetAllStudentInClassroom")]
        public ActionResult<List<StudentDto>> GetAllStudentInClassroom(int IdClassroom)
        {
            try
            {
                return Ok(_studentService.GetAllStudentInClassroom(IdClassroom));

            }
            catch (Exception ex)
            {
                return HandleException(ex);
            }
        }
        [HttpPost("Create")]
        public ActionResult Create ([FromBody] CreateStudentDto input)
        {
            try {
                _studentService.Create(input);
                return Ok();
            }
            catch (Exception ex)
            {
                return HandleException(ex);
            }
        }
        [HttpPut("Update")]
        public ActionResult Update ( [FromBody] UpdateStudentDto input)
        {
            try 
            {
                 _studentService.Update(input);
                 return Ok();
            }
            catch (Exception ex) 
            {
                return HandleException(ex);
            }
        }
        [HttpDelete("Delete")]
        public ActionResult Delete (int IdStudent)
        {
            try
                {
                    _studentService.Delete(IdStudent);
                    return Ok();
                }
            catch (Exception ex)
                {
                    return HandleException(ex);
                }
        }
    }
}