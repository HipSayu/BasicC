using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackEndDotNetValidation.Dtos.Classroom;
using BackEndDotNetValidation.Dtos.Student;
using BackEndDotNetValidation.Entities;

namespace BackEndDotNetValidation.Services.Interfaces
{
    public interface IClassroomServices
    {
        List<ClassroomDto> GetAllClassroom ();
        void Create(CreateClassroomDto input);
        void Update(UpdateClassroomDto input);
        void Delete (int IdClassroom);
    }
}