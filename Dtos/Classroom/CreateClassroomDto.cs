using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndDotNetValidation.Dtos.Classroom
{
    public class CreateClassroomDto
    {
        public string NameClassroom { get; set; }

        public string MaClassroom { get; set; }
    }
}
