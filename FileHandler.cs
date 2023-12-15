// FileHandler.cs
using System;
using System.Collections.Generic;
using System.IO;

public class FileHandler
{
    public List<Student> ReadData(string filePath)
    {
        List<Student> students = new List<Student>();

        try
        {
            string[] lines = File.ReadAllLines(filePath);

            foreach (string line in lines)
            {
                string[] data = line.Split(',');
                Student student = new Student
                {
                    Name = data[0],
                    Age = int.Parse(data[1]),
                    Grade = data[2]
                };
                students.Add(student);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error reading file: {ex.Message}");
        }

        return students;
    }
}
