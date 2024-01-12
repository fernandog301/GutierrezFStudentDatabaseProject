
using GutierrezFStudentDatabaseProject.Data;
using GutierrezFStudentDatabaseProject.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.EntityFrameworkCore;

namespace GutierrezFStudentDatabaseProject.Services;

    public class StudentServices : IStudentServices
    {

        private readonly DataContext _db;
        public List<string> studentList = new();

        public StudentServices(DataContext db)
        {
            _db = db;
        }

        public List<Student> AddStudent(string firstName, string lastName, string hobby)
        {
            Student newStudent = new();

            newStudent.FirstName = firstName;
            newStudent.LastName = lastName;
            newStudent.Hobby= hobby;

            _db.Students.Add(newStudent);
            _db.SaveChanges();

            return _db.Students.ToList();
        }

        public List<Student> DeleteStudent(string studentFirstName)
        {
            var student = _db.Students.FirstOrDefault(foundStudent => foundStudent.FirstName == studentFirstName);

            if(student != null){
                _db.Students.Remove(student);
                _db.SaveChanges();
            } 
            return _db.Students.ToList();
        }

        public List<Student> GetStudents()
        {
            return _db.Students.ToList();
        }


    }
