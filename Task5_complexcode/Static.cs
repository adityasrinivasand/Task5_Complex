using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_Complexcode
{
    static class User
    {
        public static string name;
        public static string location;
        public static int age;
        public static void add()
        {
            Console.Write("Enter Employee Name:");
            User.name = Console.ReadLine();
            Console.Write("Enter Employee Location:");
            User.location = Console.ReadLine();
            Console.Write("Enter Employee age:");
            User.age = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine("USer Detail Added Successfully...!!!!:");
        }
        public static void display()
        {
            Console.WriteLine("Name: {0}", User.name);
            Console.WriteLine("Location: {0}", User.location);
            Console.WriteLine("Age: {0}", User.age);
        }
    }
}
