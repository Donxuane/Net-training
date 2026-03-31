using StudentsManagementSystem;

List<Student> students = new List<Student>();
IStudentsManagement studentsManagement = new StudentManagements();

studentsManagement.AddStudentToTheQueue(students, "vakhia");
studentsManagement.AddStudentToTheQueue(students, "khatia");

Console.WriteLine();