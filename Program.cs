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
            
            Console.WriteLine( SubtractNumbers(myNumber, yourNumber) );
            
        }
         public static int SubtractNumbers(int number1, int number2){
            int result = (number1 - number2); 
            return result;
        }
    }
}
