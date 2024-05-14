namespace GakkoAppVertical.Students;

public interface IStudentsService
{
    IEnumerable<Student> GetStudents();
    int CreateStudent(Student student);
    Student? GetStudent(int idStudent);
    int UpdateStudent(Student student);
    int DeleteStudent(int idStudent);
}