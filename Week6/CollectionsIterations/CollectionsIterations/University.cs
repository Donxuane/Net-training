namespace CollectionsIterations;

public class University
{
    private List<Student> students = new();
    private Dictionary<string, List<float>> dictionary = new();

    public void FillStudentsData()
    {
        while (true)
        {
            Console.Write("student Name: ");
            string studentName = Console.ReadLine();
            if (studentName == "0")
            {
                break;
            }
            Console.Write("\ngrade: ");
            float studentGrade = float.Parse(Console.ReadLine());
            Student student = CreateStudent(studentName, studentGrade);
            students.Add(student);
            if (dictionary.TryGetValue(student.Name, out List<float> studentGrades) == true)
            {
                studentGrades.Add(student.Grade);
            }
            else
            {
                dictionary.Add(student.Name, new List<float> { student.Grade });
            }
        }
    }

    public Student CreateStudent(string studentName, float studentGrade)
    {
        return new Student { Name = studentName, Grade = studentGrade };
    }

    public void PrintStudents()
    {
        foreach (Student student in students)
        {
            Console.WriteLine($"name: {student.Name}, grade: {student.Grade}");
        }

        foreach (KeyValuePair<string, List<float>> value in dictionary)
        {
            float avarage = value.Value.Sum() / value.Value.Count;
            Console.WriteLine($"{value.Key} - {avarage}");
        }

    }
}
