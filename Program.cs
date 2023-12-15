// Program.cs
using System;

class Program
{
    static void Main()
    {
        string filePath = "students.txt"; // Update with your file path

        FileHandler fileHandler = new FileHandler();
        var students = fileHandler.ReadData(filePath);

        Console.WriteLine("Student Data:");
        foreach (var student in students)
        {
            Console.WriteLine($"Name: {student.Name}, Age: {student.Age}, Grade: {student.Grade}");
        }
    }
}
