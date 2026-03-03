using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_task;

internal class Student
{
    private string Name;
    private string SurName;
    private double Gpa;

    public void information(string name,string surName, double gpa)
    {
        Name = name;
        SurName = surName;
        Gpa = gpa;
    
    }

    public void PrintInfo()
    {
        Console.WriteLine(Name + SurName + Gpa);
    }

    public double GetGpa()
    { return  Gpa; }
        
}

