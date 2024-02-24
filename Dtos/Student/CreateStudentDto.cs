using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndDotNetValidation.Dtos.Student
{
    public class CreateStudentDto
    {
        public string Name { get; set; }

        public string MaStudent{ get; set; }

        public DateTime BirthOfDate { get; set; }
    }
}
