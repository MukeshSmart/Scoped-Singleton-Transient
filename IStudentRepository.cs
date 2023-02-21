namespace Scoped_Singleton_Transient
{
    public interface IStudentRepository
    {
        IEnumerable<Student> GetStudents();
        Student Add(Student student);
    }
}
