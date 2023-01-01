using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Namespace
{
    class Class
    {
        static void Main(string[] args)
        {

        Person person1 = new Person();

        Console.WriteLine("PERSON name: " + person1.name);

        Student student1 = new Student();

        Console.WriteLine("STUDENT name: " + student1.name);

        Console.WriteLine("STUDENT id: " + student1.ID);

        student1.name = "John"; // changes the name of the student 
        Console.WriteLine(student1.name);


        Console.ReadLine();

        }
    }

    class Person
    {
        public string name = getName();
        public int age = getAge();



        static string getName()
        {
            Console.Write("Enter the name: ");
            return Console.ReadLine();
        }

        static int getAge()
        {
            Console.Write("Enter the age: ");
            return Convert.ToInt32(Console.ReadLine());
        }



    }

    class Student : Person // Student class inherits from Person class
        //Has access to same functions and methods as Person class 
     {
        public int ID = getID();

        static int getID()
        {
            Console.WriteLine("Enter your student ID: ");
            return Convert.ToInt32(Console.ReadLine());
        }
     }

}