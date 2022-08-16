using System;

namespace SchoolPractice
{
    class Program
    {
        public static void Main(string[] args)
        {
            // TODO: Instantiate your objects and test your exercise solutions with print statements here.
            Student jack = new Student("Jack", 1, 1, 4.0);
            Console.WriteLine("The Student class works! " + jack.Name + " is a student!");
        }
    }
}
