using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SchoolManagement.Mvc.Migrations
{
    /// <inheritdoc />
    public partial class Adding_Seed_Data : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Code", "Credits", "Name" },
                values: new object[,]
                {
                    { 1, "MTH01", 3, "Mathematics" },
                    { 2, "PHY01", 3, "Physics" },
                    { 3, "CHM01", 3, "Chemistry" },
                    { 4, "BIO01", 3, "Biology" },
                    { 5, "HIS01", 2, "History" },
                    { 6, "GEO01", 2, "Geography" },
                    { 7, "ENG01", 3, "English" },
                    { 8, "CSC01", 4, "Computer Science" },
                    { 9, "ART01", 2, "Art" },
                    { 10, "ECO01", 3, "Economics" }
                });

            migrationBuilder.InsertData(
                table: "Lecturers",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, "Alice", "Smith" },
                    { 2, "Bob", "Johnson" },
                    { 3, "Carol", "Williams" },
                    { 4, "David", "Brown" },
                    { 5, "Eve", "Jones" },
                    { 6, "Frank", "Miller" },
                    { 7, "Grace", "Davis" },
                    { 8, "Hank", "Garcia" },
                    { 9, "Ivy", "Martinez" },
                    { 10, "Jack", "Rodriguez" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "DateOfBirth", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, new DateTime(2005, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Student1", "One" },
                    { 2, new DateTime(2005, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Student2", "Two" },
                    { 3, new DateTime(2005, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Student3", "Three" },
                    { 4, new DateTime(2005, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Student4", "Four" },
                    { 5, new DateTime(2005, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Student5", "Five" },
                    { 6, new DateTime(2005, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Student6", "Six" },
                    { 7, new DateTime(2005, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Student7", "Seven" },
                    { 8, new DateTime(2005, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Student8", "Eight" },
                    { 9, new DateTime(2005, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Student9", "Nine" },
                    { 10, new DateTime(2005, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Student10", "Ten" }
                });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "Id", "CourseId", "LecturerId", "Time" },
                values: new object[,]
                {
                    { 1, 1, 1, new TimeSpan(0, 8, 0, 0, 0) },
                    { 2, 2, 2, new TimeSpan(0, 9, 0, 0, 0) },
                    { 3, 3, 3, new TimeSpan(0, 10, 0, 0, 0) },
                    { 4, 4, 4, new TimeSpan(0, 11, 0, 0, 0) },
                    { 5, 5, 5, new TimeSpan(0, 12, 0, 0, 0) },
                    { 6, 6, 6, new TimeSpan(0, 13, 0, 0, 0) },
                    { 7, 7, 7, new TimeSpan(0, 14, 0, 0, 0) },
                    { 8, 8, 8, new TimeSpan(0, 15, 0, 0, 0) },
                    { 9, 9, 9, new TimeSpan(0, 16, 0, 0, 0) },
                    { 10, 10, 10, new TimeSpan(0, 17, 0, 0, 0) }
                });

            migrationBuilder.InsertData(
                table: "Enrollments",
                columns: new[] { "Id", "ClassId", "Grade", "StudentId" },
                values: new object[,]
                {
                    { 1, 1, "A", 1 },
                    { 2, 2, "B", 2 },
                    { 3, 3, "C", 3 },
                    { 4, 4, "A", 4 },
                    { 5, 5, "B", 5 },
                    { 6, 6, "A", 6 },
                    { 7, 7, "C", 7 },
                    { 8, 8, "B", 8 },
                    { 9, 9, "A", 9 },
                    { 10, 10, "B", 10 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
