using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static MyRobotStats j42;//makes new object.

        public static void Main(string[] args)
        {
            j42.DisplayPower();
            int myNumber = 21;
            int yourNumber = 19;
            int newNumber = myNumber + yourNumber;
            string firstLine = "Hello World! This is my first C# project.";
            Console.WriteLine(firstLine);
            Console.WriteLine(newNumber);
        }
    }
}
