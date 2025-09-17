using System;
using System.Collections.Generic;

namespace Datastructure_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> List_of_Student = new List<Student>();

            List_of_Student.Add(new Student("Gaurav", 24));
            List_of_Student.Add(new Student("Yash", 20));
            List_of_Student.Add(new Student("Vinod", 27));

            Console.WriteLine("The List of Students:");

            foreach (Student student in List_of_Student)
            {
                Console.WriteLine($"Name: {student.Name}, Age: {student.Age}");
            }
        }
    }

    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Student(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}