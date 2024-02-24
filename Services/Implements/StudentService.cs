using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackEndDotNetValidation.DbContexts;
using BackEndDotNetValidation.Dtos.Classroom;
using BackEndDotNetValidation.Dtos.Student;
using BackEndDotNetValidation.Entities;
using BackEndDotNetValidation.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BackEndDotNetValidation.Services.Implements
{
    public class StudentService : IStudentService
    {
        private readonly ApplicationDbContext _context;

        public StudentService(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Create(CreateStudentDto input)
        {
            _context.Students.Add(
                new Student()
                {
                    Name = input.Name,
                    MaStudent = input.MaStudent,
                    BirthOfDate = input.BirthOfDate,
                }
            );
            _context.SaveChanges();
        }

        public void Delete(int IdStudent)
        {
            var student = _context.Students.SingleOrDefault(student =>
                student.IdStudent == IdStudent
            );
            if (student == null)
            {
                throw new NotImplementedException(
                    $"Không tìm thấy sinh viên nào có id {IdStudent}"
                );
            }
            _context.Students.Remove(student);
            _context.SaveChanges();
        }

        public List<StudentDto> GetAll()
        {
            var results = new List<StudentDto>();
            foreach (var student in _context.Students)
            {
                results.Add(
                    new StudentDto()
                    {
                        IdStudent = student.IdStudent,
                        Name = student.Name,
                        MaStudent = student.MaStudent,
                        BirthOfDate = student.BirthOfDate
                    }
                );
            }
            return results;
        }

        public void Update(UpdateStudentDto input)
        {
            var student = _context.Students.SingleOrDefault(student =>
                student.IdStudent == input.IdStudent
            );
            if (student == null)
            {
                throw new NotImplementedException(
                    $"Không tìm thấy sinh viên nào có id {input.IdStudent}"
                );
            }
            student.Name = input.Name;
            student.MaStudent = input.MaStudent;
            student.BirthOfDate = input.BirthOfDate;
            _context.SaveChanges();
        }

        public List<StudentDto> GetAllStudentInClassroom(int IdClassroom)
        {
            var query =

                from studentClassroom in _context.studentClassrooms
                join student in _context.Students
                    on studentClassroom.IdStudent equals student.IdStudent
                where studentClassroom.IdClassroom == IdClassroom
                orderby student.BirthOfDate
                select new StudentDto
                {
                    IdStudent = student.IdStudent,
                    Name = student.Name,
                    MaStudent = student.MaStudent,
                };
            return query.ToList();
        }

       /* public List<ClassroomDto> GetClassroomStudentStudy(string NameStudent)
        {
            var students = _context.Students.Include(s => s.StudentClassrooms).ToList();

            var query = from  student in students
                        join classroom in _context.Classrooms on student.Id equals student.Id


                
        }*/
    }
}
