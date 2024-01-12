
using GutierrezFStudentDatabaseProject.Models;

namespace GutierrezFStudentDatabaseProject.Services;

    public interface IStudentServices
    {
        public List<Student> GetStudents();
        public List<Student> AddStudent(string firstName, string lastName, string hobby);
        public List<Student> DeleteStudent(string studentFirstName);
    }
