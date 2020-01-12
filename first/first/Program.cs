using System;

namespace first
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value of first number");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the value of second number");
            int number2 = int.Parse(Console.ReadLine());
            int temp = number1;
            number1 = number2;
            number2 = temp;
            Console.WriteLine("value of number1 " + number1 + " Value of number2 " + number2);


        }
    }
}
