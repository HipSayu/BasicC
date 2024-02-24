using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndDotNetValidation.Entities
{
    [Table("Classroom")]
    public class Classroom
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdClassroom { get; set; }

        [Required]
        [MaxLength(100, ErrorMessage = "Không tối đa 100 ký tự")]
        public string NameClassroom { get; set; }

        [Required]
        [MaxLength(10, ErrorMessage = "Không tối đa 10 ký tự")]
        [Unicode(false)]
        public string MaClassroom { get; set; }

        public ICollection<StudentClassroom> StudentClassrooms { get; set; }
    }
}
