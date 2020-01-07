using System;

namespace control_flow
{
    class Program
    {
        static void Main(string[] args)
        {
            // Check if user enters the valid number between one to ten.
            /*
               Console.WriteLine("Enter the number between 1 to 10");
               int number = int.Parse(Console.ReadLine());
               if(number <= 10 && number >= 1)
               {
                   Console.WriteLine("Valid number");
               }
               else
               {
                   Console.WriteLine("Invalid number");
               }*/

            // Compare and print maximum of two numbers
            /*
            Console.Write("Enter the first number: ");
            var number1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            var number2 = int.Parse(Console.ReadLine());
            if ( number1 > number2)
                Console.WriteLine("Maximum value is first number having value: " + number1);
            else
                Console.WriteLine("Maximum value is second number having value: " + number2);*/

            //Check if image is landscape or portrait by width and height
            /*
            Console.Write("Enter the width of an image: ");
            int width = int.Parse(Console.ReadLine());
            Console.Write("Enter the width of an height: ");
            int height = int.Parse(Console.ReadLine());
            if (width > height)
                Console.WriteLine("The image is landscape");
            else
                Console.WriteLine("The image is portrait");*/
            //Speed camera
            Console.Write("Enter the speed limit: ");
            int speed_limit = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the speed of the car: ");
            int speed_of_car = int.Parse(Console.ReadLine());

            if (speed_of_car < speed_limit)
                Console.WriteLine("Ok");
            else
            {
                const int kmPerDemeritPoint = 5;
                var demeritPoints = (speed_of_car - speed_limit) / kmPerDemeritPoint;
                if (demeritPoints > 12)
                    Console.WriteLine("License Suspended");
                else
                    Console.WriteLine("Demerit points: " + demeritPoints);
            }


        }
    }
}
