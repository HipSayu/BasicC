using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndDotNetValidation.Dtos.Student
{
    public class UpdateStudentDto :CreateStudentDto
    {
        public int IdStudent {get; set;}
    }
}