using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using BackEndDotNetValidation.Dtos.Classroom;
using BackEndDotNetValidation.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace BackEndDotNetValidation.Controllers
{

    [Route("[controller]")]
    public class ClassroomController : ApiControllerBase
    {
       private readonly IClassroomServices _classroomService ;

        public ClassroomController(IClassroomServices classroomServices,
            ILogger<ClassroomController> logger)
            : base(logger)
        {
            _classroomService = classroomServices;
        }

        [HttpGet("GetAll")]   
        public ActionResult<List<ClassroomDto>> GetAll () {
            try {
                return Ok(_classroomService.GetAllClassroom());
            }
            catch (Exception ex)
            {
                return HandleException(ex);
            }
        }
        [HttpPost("Create")]
        public ActionResult Create ([FromBody] CreateClassroomDto input)
        {
                _classroomService.Create(input);
                return Ok();
        }
        [HttpPut("Update")]
        public ActionResult Update ([FromBody] UpdateClassroomDto input)
        {
            try 
            {
                 _classroomService.Update(input);
                 return Ok();
            }
            catch (Exception ex) 
            {
                return HandleException(ex);
            }
        }
        [HttpDelete("Delete")]
        public ActionResult Delete (int IdClassroom){
            try
                {
                    _classroomService.Delete(IdClassroom);
                    return Ok();
                }
            catch (Exception ex)
                {
                    return HandleException(ex);
                }
        }
    }
}