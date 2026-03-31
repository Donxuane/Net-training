using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsManagementSystem;

public class StudentsWithConsole : IStudentsManagement
{
    public void AddStudentToTheQueue(List<Student> students, string name)
    {
       students.Add(new Student { Name = name });
        Console.WriteLine(name);
    }
}
