
using GutierrezFStudentDatabaseProject.Models;
using GutierrezFStudentDatabaseProject.Services;
using Microsoft.AspNetCore.Mvc;

namespace GutierrezFStudentDatabaseProject.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController : Controller
    {
        private readonly IStudentServices _studentServices;

        public StudentController(IStudentServices studentServices)
        {
            _studentServices = studentServices;
        }

        // public string studentFirstName(string firstName)
        // {
        //     return _studentServices.studentFirstName(firstName);
        // }
        [HttpGet]
        [Route("FetchStudents")]
        public List<Student> GetStudents()
        {
            return _studentServices.GetStudents();
        }
        [HttpPost]
        [Route("AddStudent/{firstName}/{lastName}/{hobby}")]
        public List<Student> AddStudent(string firstName, string lastName, string hobby)
        {
            return _studentServices.AddStudent(firstName, lastName, hobby);
        }
        
        [HttpDelete]
        [Route("DeleteStudent/{studentFirstName}")]
        public List<Student> DeleteStudent(string studentFirstName)
        {
            return _studentServices.DeleteStudent(studentFirstName);
        }



    }
}