namespace StudentsManagementSystem;

public class StudentManagements : IStudentsManagement
{
    public void AddStudentToTheQueue(List<Student> students, string name)
    {
        students.Add(new Student
        {
            Name = name
        });
    }
}
