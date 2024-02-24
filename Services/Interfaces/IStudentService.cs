using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackEndDotNetValidation.Dtos.Classroom;
using BackEndDotNetValidation.Dtos.Student;

namespace BackEndDotNetValidation.Services.Interfaces
{
    public interface IStudentService
    {
        void Create(CreateStudentDto input);
        List<StudentDto> GetAll();
        void Update(UpdateStudentDto input);
        void Delete (int IdStudent);

        List<StudentDto> GetAllStudentInClassroom(int IdClassroom);

       /* List<ClassroomDto> GetClassroomStudentStudy(string NameStudent );*/
    }
}