using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_demo
{
    internal class Student
    {
        private int student_id;
        public string name;
        int age;
        string contactno;
        String emailid;

        public void initialize()
        {
            student_id = 10;
            name = "abcd";
        }

        public void showDisplay()

        {

            Console.WriteLine("Displaying object");
            Console.WriteLine(name);
        
        }

        public Student(int id, string std_name, int age, string contactno, string emailid)

        {
            student_id = id;
            name = std_name;


        }

        public Student()
        {



        }

        public void getTotal()
        {



        }

        public void getAverage()
        {


        }

        public void grade()

        {



        }

    }
}
