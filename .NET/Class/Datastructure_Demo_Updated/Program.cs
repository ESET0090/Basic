using System;
using System.Collections.Generic;

namespace Data_Structure_Updated
{
 
    public class Student : IEquatable<Student>
    {
        public int id { get; set; }
        public string name { get; set; }
        public int marks { get; set; }

        public Student(int id, string name, int marks)
        {
            this.id = id;
            this.name = name;
            this.marks = marks;
        }

      
        public override bool Equals(object obj)
        {
            return Equals(obj as Student);
        }

        public bool Equals(Student other)
        {
            return other != null &&
                   id == other.id &&
                   name == other.name &&
                   marks == other.marks;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(id, name, marks);
        }

        public override string ToString()
        {
            return $"ID: {id}, Name: {name}, Marks: {marks}";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
      
            List<Student> students = new List<Student>();

         
            Student first = new Student(1, "Alice", 10);
            Student second = new Student(2, "Bob", 90);
            Student third = new Student(3, "Charlie", 78);
            students.Add(first);
            students.Add(second);
            students.Add(third);

            
            Console.WriteLine("Student List:");
            foreach (Student s in students)
            {
                Console.WriteLine($"ID: {s.id}, Name: {s.name}, Marks: {s.marks}");
            }

           
            Console.WriteLine($"\nSecond student is: {students[1].name}");

        
            Dictionary<string, Student> students_dict = new Dictionary<string, Student>();
            students_dict.Add("firstStudent", first);
            students_dict.Add("secondStudent", second); 
            students_dict.Add("thirdStudent", third);

            Console.WriteLine("\nDictionary demo:");
            foreach (KeyValuePair<string, Student> student in students_dict)
            {
                Console.WriteLine($"{student.Key}: ID={student.Value.id}");
            }

           
            Console.WriteLine("\nHashset demo:");
            HashSet<Student> students_hashset = new HashSet<Student>();
            students_hashset.Add(first);
            students_hashset.Add(second);
            students_hashset.Add(first);
            students_hashset.Add(third);

            foreach (Student student in students_hashset)
            {
                Console.WriteLine($"ID: {student.id}");
            }

          
            Console.WriteLine("\nStack demo:");
            Stack<Student> students_stack = new Stack<Student>();
            students_stack.Push(first);
            students_stack.Push(second);
            students_stack.Push(third);

            Student pop_stack = students_stack.Pop();
            Console.WriteLine($"Popped: {pop_stack.name}");

           
            Console.WriteLine("\nQueue demo:");
            Queue<Student> students_queue = new Queue<Student>();
            students_queue.Enqueue(first);
            students_queue.Enqueue(second);
            students_queue.Enqueue(third);

            Console.WriteLine($"Dequeued: {students_queue.Dequeue().name}");

           
            Console.WriteLine("\nL.L demo:");
            LinkedList<Student> students_ll = new LinkedList<Student>();
            students_ll.AddLast(first);
            students_ll.AddLast(second);
            students_ll.AddLast(third);

         
            Console.WriteLine("1st student in LL: " + students_ll.First.Value.name);
            Console.WriteLine("last student in LL: " + students_ll.Last.Value.name);

           
            Console.WriteLine("All students in LL format:");
            LinkedListNode<Student> currentNode = students_ll.First;
            while (currentNode != null)
            {
                Console.WriteLine($"ID: {currentNode.Value.id}, Name: {currentNode.Value.name}");
                currentNode = currentNode.Next;
            }

            
            Console.WriteLine("\nTuple demo:");

            // Create tuples from student data
            var studentTuple1 = (ID: first.id, Name: first.name, Marks: first.marks);
            var studentTuple2 = (ID: second.id, Name: second.name, Marks: second.marks);
            var studentTuple3 = (ID: third.id, Name: third.name, Marks: third.marks);

          
            List<(int ID, string Name, int Marks)> studentTuples = new List<(int, string, int)>();
            studentTuples.Add(studentTuple1);
            studentTuples.Add(studentTuple2);
            studentTuples.Add(studentTuple3);

          
            Console.WriteLine("Data in tuples format:");
            foreach (var tuple in studentTuples)
            {
                Console.WriteLine($"ID: {tuple.ID}, Name: {tuple.Name}, Marks: {tuple.Marks}");
            }

           
            Console.WriteLine($"\nFirst student from tuple: {studentTuples[0].Name}");
            Console.WriteLine($"Second student marks: {studentTuples[1].Marks}");

            
            Console.WriteLine("\nLinkedList with Tuple demo:");
            LinkedList<(int ID, string Name, int Marks)> tupleLinkedList = new LinkedList<(int, string, int)>();
            tupleLinkedList.AddLast((first.id, first.name, first.marks));
            tupleLinkedList.AddLast((second.id, second.name, second.marks));
            tupleLinkedList.AddLast((third.id, third.name, third.marks));


            foreach (var studentTuple in tupleLinkedList)
            {
                Console.WriteLine($"Tuple LL - ID: {studentTuple.ID}, Name: {studentTuple.Name}");
            }
        }
    }
}
