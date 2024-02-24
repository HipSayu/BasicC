using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndDotNetValidation.Dtos.Classroom
{
    public class UpdateClassroomDto : CreateClassroomDto
    {
          public int IdClassroom {get; set;}

    }
}