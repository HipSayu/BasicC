using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackEndDotNetValidation.Migrations
{
    /// <inheritdoc />
    public partial class AddInitDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clasroom",
                columns: table => new
                {
                    IdClassroom = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameClassroom = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    MaClassroom = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clasroom", x => x.IdClassroom);
                });

            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    IdStudent = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    MaStudent = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    BirthOfDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.IdStudent);
                });

            migrationBuilder.CreateTable(
                name: "StudentClassroom",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdStudent = table.Column<int>(type: "int", nullable: false),
                    IdClassroom = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentClassroom", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StudentClassroom_Classroom",
                        column: x => x.IdClassroom,
                        principalTable: "Clasroom",
                        principalColumn: "IdClassroom",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentClassroom_Student",
                        column: x => x.IdStudent,
                        principalTable: "Student",
                        principalColumn: "IdStudent",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StudentClassroom_IdClassroom",
                table: "StudentClassroom",
                column: "IdClassroom");

            migrationBuilder.CreateIndex(
                name: "IX_StudentClassroom_IdStudent",
                table: "StudentClassroom",
                column: "IdStudent");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudentClassroom");

            migrationBuilder.DropTable(
                name: "Clasroom");

            migrationBuilder.DropTable(
                name: "Student");
        }
    }
}
