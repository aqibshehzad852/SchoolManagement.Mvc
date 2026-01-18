using System;
using Microsoft.EntityFrameworkCore;
using SchoolManagement.Mvc.Models;

namespace SchoolManagement.Mvc.Data;

public static class SeedData
{
    public static void Apply(ModelBuilder modelBuilder)
    {
        // Courses
        modelBuilder.Entity<Course>().HasData(
            new Course { Id = 1, Name = "Mathematics", Code = "MTH01", Credits = 3 },
            new Course { Id = 2, Name = "Physics", Code = "PHY01", Credits = 3 },
            new Course { Id = 3, Name = "Chemistry", Code = "CHM01", Credits = 3 },
            new Course { Id = 4, Name = "Biology", Code = "BIO01", Credits = 3 },
            new Course { Id = 5, Name = "History", Code = "HIS01", Credits = 2 },
            new Course { Id = 6, Name = "Geography", Code = "GEO01", Credits = 2 },
            new Course { Id = 7, Name = "English", Code = "ENG01", Credits = 3 },
            new Course { Id = 8, Name = "Computer Science", Code = "CSC01", Credits = 4 },
            new Course { Id = 9, Name = "Art", Code = "ART01", Credits = 2 },
            new Course { Id = 10, Name = "Economics", Code = "ECO01", Credits = 3 }
        );

        // Lecturers
        modelBuilder.Entity<Lecturer>().HasData(
            new Lecturer { Id = 1, FirstName = "Alice", LastName = "Smith" },
            new Lecturer { Id = 2, FirstName = "Bob", LastName = "Johnson" },
            new Lecturer { Id = 3, FirstName = "Carol", LastName = "Williams" },
            new Lecturer { Id = 4, FirstName = "David", LastName = "Brown" },
            new Lecturer { Id = 5, FirstName = "Eve", LastName = "Jones" },
            new Lecturer { Id = 6, FirstName = "Frank", LastName = "Miller" },
            new Lecturer { Id = 7, FirstName = "Grace", LastName = "Davis" },
            new Lecturer { Id = 8, FirstName = "Hank", LastName = "Garcia" },
            new Lecturer { Id = 9, FirstName = "Ivy", LastName = "Martinez" },
            new Lecturer { Id = 10, FirstName = "Jack", LastName = "Rodriguez" }
        );

        // Students
        modelBuilder.Entity<Student>().HasData(
            new Student { Id = 1, FirstName = "Student1", LastName = "One", DateOfBirth = new DateTime(2005, 1, 1) },
            new Student { Id = 2, FirstName = "Student2", LastName = "Two", DateOfBirth = new DateTime(2005, 2, 2) },
            new Student { Id = 3, FirstName = "Student3", LastName = "Three", DateOfBirth = new DateTime(2005, 3, 3) },
            new Student { Id = 4, FirstName = "Student4", LastName = "Four", DateOfBirth = new DateTime(2005, 4, 4) },
            new Student { Id = 5, FirstName = "Student5", LastName = "Five", DateOfBirth = new DateTime(2005, 5, 5) },
            new Student { Id = 6, FirstName = "Student6", LastName = "Six", DateOfBirth = new DateTime(2005, 6, 6) },
            new Student { Id = 7, FirstName = "Student7", LastName = "Seven", DateOfBirth = new DateTime(2005, 7, 7) },
            new Student { Id = 8, FirstName = "Student8", LastName = "Eight", DateOfBirth = new DateTime(2005, 8, 8) },
            new Student { Id = 9, FirstName = "Student9", LastName = "Nine", DateOfBirth = new DateTime(2005, 9, 9) },
            new Student { Id = 10, FirstName = "Student10", LastName = "Ten", DateOfBirth = new DateTime(2005, 10, 10) }
        );

        // Classes
        modelBuilder.Entity<Class>().HasData(
            new Class { Id = 1, CourseId = 1, LecturerId = 1, Time = new TimeSpan(8, 0, 0) },
            new Class { Id = 2, CourseId = 2, LecturerId = 2, Time = new TimeSpan(9, 0, 0) },
            new Class { Id = 3, CourseId = 3, LecturerId = 3, Time = new TimeSpan(10, 0, 0) },
            new Class { Id = 4, CourseId = 4, LecturerId = 4, Time = new TimeSpan(11, 0, 0) },
            new Class { Id = 5, CourseId = 5, LecturerId = 5, Time = new TimeSpan(12, 0, 0) },
            new Class { Id = 6, CourseId = 6, LecturerId = 6, Time = new TimeSpan(13, 0, 0) },
            new Class { Id = 7, CourseId = 7, LecturerId = 7, Time = new TimeSpan(14, 0, 0) },
            new Class { Id = 8, CourseId = 8, LecturerId = 8, Time = new TimeSpan(15, 0, 0) },
            new Class { Id = 9, CourseId = 9, LecturerId = 9, Time = new TimeSpan(16, 0, 0) },
            new Class { Id = 10, CourseId = 10, LecturerId = 10, Time = new TimeSpan(17, 0, 0) }
        );

        // Enrollments
        modelBuilder.Entity<Enrollment>().HasData(
            new Enrollment { Id = 1, StudentId = 1, ClassId = 1, Grade = "A" },
            new Enrollment { Id = 2, StudentId = 2, ClassId = 2, Grade = "B" },
            new Enrollment { Id = 3, StudentId = 3, ClassId = 3, Grade = "C" },
            new Enrollment { Id = 4, StudentId = 4, ClassId = 4, Grade = "A" },
            new Enrollment { Id = 5, StudentId = 5, ClassId = 5, Grade = "B" },
            new Enrollment { Id = 6, StudentId = 6, ClassId = 6, Grade = "A" },
            new Enrollment { Id = 7, StudentId = 7, ClassId = 7, Grade = "C" },
            new Enrollment { Id = 8, StudentId = 8, ClassId = 8, Grade = "B" },
            new Enrollment { Id = 9, StudentId = 9, ClassId = 9, Grade = "A" },
            new Enrollment { Id = 10, StudentId = 10, ClassId = 10, Grade = "B" }
        );
        
        // Newsletter subscriptions
        modelBuilder.Entity<NewsletterSubscription>().HasData(
            new NewsletterSubscription { Id = 1, Email = "user1@example.com" },
            new NewsletterSubscription { Id = 2, Email = "user2@example.com" },
            new NewsletterSubscription { Id = 3, Email = "user3@example.com" },
            new NewsletterSubscription { Id = 4, Email = "user4@example.com" },
            new NewsletterSubscription { Id = 5, Email = "user5@example.com" },
            new NewsletterSubscription { Id = 6, Email = "user6@example.com" },
            new NewsletterSubscription { Id = 7, Email = "user7@example.com" },
            new NewsletterSubscription { Id = 8, Email = "user8@example.com" },
            new NewsletterSubscription { Id = 9, Email = "user9@example.com" },
            new NewsletterSubscription { Id = 10, Email = "user10@example.com" }
        );
    }
}