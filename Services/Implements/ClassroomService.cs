using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackEndDotNetValidation.DbContexts;
using BackEndDotNetValidation.Dtos.Classroom;
using BackEndDotNetValidation.Entities;
using BackEndDotNetValidation.Services.Interfaces;

namespace BackEndDotNetValidation.Services.Implements
{
    public class ClassroomService : IClassroomServices
    {
        private readonly ApplicationDbContext _context;

        public ClassroomService(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Create(CreateClassroomDto input)
        {
            _context.Classrooms.Add(
                new Classroom()
                {
                    NameClassroom = input.NameClassroom,
                    MaClassroom = input.MaClassroom,
                }
            );
            _context.SaveChanges();
        }

        public void Delete(int IdClassroom)
        {
            var classroom = _context.Classrooms.SingleOrDefault(classroom =>
                classroom.IdClassroom == IdClassroom
            );
            if (classroom == null)
            {
                throw new NotImplementedException(
                    $"Không tìm thấy sinh viên nào có id {IdClassroom}"
                );
            }
            _context.Classrooms.Remove(classroom);
            _context.SaveChanges();
        }

        public List<ClassroomDto> GetAllClassroom()
        {
            var results = new List<ClassroomDto>();
            foreach (var classroom in _context.Classrooms)
            {
                results.Add(
                    new ClassroomDto()
                    {
                        IdClassroom = classroom.IdClassroom,
                        NameClassroom = classroom.NameClassroom,
                        MaClassroom = classroom.MaClassroom,
                    }
                );
            }
            return results;
        }

        public void Update(UpdateClassroomDto input)
        {
            var classroom = _context.Classrooms.SingleOrDefault(classroom =>
                classroom.IdClassroom == input.IdClassroom
            );
            if (classroom == null)
            {
                throw new NotImplementedException(
                    $"Không tìm thấy sinh viên nào có id {input.IdClassroom}"
                );
            }
            classroom.NameClassroom = input.NameClassroom;
            classroom.MaClassroom = input.MaClassroom;
            _context.SaveChanges();
        }
    }
}
