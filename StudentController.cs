using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController : Controller
    {
        public static List<Student> GetStudent()
        {
            List<Student> student = new List<Student>();
            student.Add(new Student() { Id = 1, First_name = "Anjara", Last_name = "Rabesandratana",  Age = 19 });
            student.Add(new Student() { Id = 2, First_name = "Alexis", Last_name = "caunart", Age = 19 });
            student.Add(new Student() { Id = 3, First_name = "Tony", Last_name = "bauchet", Age = 19 });
            student.Add(new Student() { Id = 4, First_name = "Lucas", Last_name = "Sillicone", Age = 20 });
            return student;
        }

        [HttpGet]
        public IEnumerable<Student> GetStudent_List()
        {
            return GetStudent();
        }

        [HttpGet("{id}")]
        public ActionResult<Student> GetStudent_ById(int id)
        {
            var student = GetStudent().Find(x => x.Id == id);
            if (student != null)
            {
                return student;
            }
            else
            {
                return NotFound();
            }

        }
    }
}

