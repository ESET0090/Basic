using System;
using System.Collections.Generic;

namespace Datastructure_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            List<Student> list_of_student = new List<Student>();


            list_of_student.Add(new Student("John", 20));
            list_of_student.Add(new Student("Sarah", 21));
            list_of_student.Add(new Student("Mike", 19));

            // Display the students using for loop
            Console.WriteLine("Student List:");

            for (int i = 0; i < list_of_student.Count; i++)
            {
                Console.WriteLine($"Name: {list_of_student[i].Name}, Age: {list_of_student[i].Age}");
            }
        }
    }

    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }

        // Constructor to initialize Student objects
        public Student(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}