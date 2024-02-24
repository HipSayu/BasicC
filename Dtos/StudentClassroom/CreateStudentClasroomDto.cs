using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndDotNetValidation.Dtos.StudentClassroom
{
    public class CreateStudentClasroomDto
    {
       
        public string MaStudent{get; set;}
        
       
        public string MaClassroom {get; set;}
    }
}