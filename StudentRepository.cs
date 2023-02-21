namespace Scoped_Singleton_Transient
{
    public class StudentRepository : IStudentRepository
    {
        private readonly List<Student> _students;

        public StudentRepository()
        {
            _students = new List<Student>()
            {
                new Student(){StudentId = 1, Name ="Mukesh Dubey", Age =10, ClassName ="1"},
                new Student(){StudentId = 2, Name ="Saurabh Dwivedi", Age =10, ClassName ="1"},
                new Student(){StudentId = 3, Name ="Ashutosh Mishra", Age =10, ClassName ="1"},

            };    
        }
        public Student Add(Student student)
        {
            student.StudentId = _students.Max(x => x.StudentId)+1;
            _students.Add(student);
            return student;
        }

        public IEnumerable<Student> GetStudents()
        {
           return _students;
        }
    }
}
