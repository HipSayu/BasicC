using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndDotNetValidation.Entities
{   
    public class StudentClassroom
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id {get; set;}

        public int IdStudent{get; set;}

        public int IdClassroom {get; set;}

        public Student student { get; set;}

        public Classroom classroom { get; set;}

        
    }
}