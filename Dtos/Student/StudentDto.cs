using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndDotNetValidation.Dtos.Student
{
    public class StudentDto
    {
        public int IdStudent { get; set;}
        public string Name {get; set;}
        public string MaStudent { get; set;}
        public DateTime BirthOfDate {get; set;}
    }
}