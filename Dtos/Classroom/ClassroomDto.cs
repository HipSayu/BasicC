using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndDotNetValidation.Dtos.Classroom
{
    public class ClassroomDto
    {
        public int IdClassroom { get; set; }
        public string NameClassroom {get; set;}

        public string MaClassroom {get; set;}
        
        
    }
}