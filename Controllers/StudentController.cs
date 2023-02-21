using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Scoped_Singleton_Transient.Controllers
{
    public class StudentController : Controller
    {
       private readonly IStudentRepository _studentRepository;

        public StudentController(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        [HttpGet]
        public ViewResult Index()
        {
            var students = _studentRepository.GetStudents();
            return View(students);
        }

        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Student student)
        {
            if(ModelState.IsValid)
            {
                Student stu = _studentRepository.Add(student);
            }
            return View();
        }
    }
}
