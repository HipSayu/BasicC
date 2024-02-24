using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackEndDotNetValidation.Entities;
using Microsoft.EntityFrameworkCore;

namespace BackEndDotNetValidation.DbContexts
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options)
            : base(options) { }

        public DbSet<Student> Students { get; set; }
        public DbSet<Classroom> Classrooms { get; set; }
        public DbSet<StudentClassroom> studentClassrooms { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>(entity =>
            {
                entity.ToTable("Student");
                entity.HasKey(e => e.IdStudent);
            });

            modelBuilder.Entity<Classroom>(entity =>
            {
                entity.ToTable("Clasroom");
                entity.HasKey(e => e.IdClassroom);
            });

            modelBuilder.Entity<StudentClassroom>(entity =>
            {
                entity.ToTable("StudentClassroom");
                entity.HasKey(e => e.Id);
                entity
                    .HasOne(e => e.student)
                    .WithMany(e => e.StudentClassrooms)
                    .HasForeignKey(e => e.IdStudent)
                    .HasConstraintName("FK_StudentClassroom_Student");

                entity
                    .HasOne(e => e.classroom)
                    .WithMany(e => e.StudentClassrooms)
                    .HasForeignKey(e => e.IdClassroom)
                    .HasConstraintName("FK_StudentClassroom_Classroom");
            });
        }
    }
}
