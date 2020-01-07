using System;

namespace control_flow_2
{
    class Program
    {
        static void Main(string[] args)
        {

            //To count how many number between 1 to 100 are divisible by 3 and display them.
            for (int count = 0; count <= 100; count++)
            {
                if (count % 3 == 0)
                    Console.WriteLine(count);
            }
            //Sum the user input until user enters ok or OK to quit print total  sum at the end
            int sum = 0;
            while (true)
            {

                Console.WriteLine("Enter the number or ok to quit");
                var input1 = Console.ReadLine();
                if (input1.ToUpper() == "OK")
                    break;
                else

                    sum = sum + Convert.ToInt32(input1);
            }
            Console.WriteLine("The total sum is: " + sum);


            //factorial number

            int fact = 1;
            Console.WriteLine("Enter the number to calculate the factorial number");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                fact *= i;
            }
            Console.WriteLine(fact);

            // guessing the random number by user
            Random rand = new Random();
            int random_number = rand.Next(1, 10);
            for(int i = 0; i < 4; i++)
            {
                Console.WriteLine("Guess the random number between 1 to 10: ");
                int user_guess = Convert.ToInt32(Console.ReadLine());
                if(user_guess == random_number)
                {
                    Console.WriteLine("Wow, You guessed the right number");
                }
                else
                {
                    Console.WriteLine("Nah, you guessed the wrong number you have " + i + "tries left");
                }
            }
            Console.WriteLine("Random number is: " + random_number);

            //comma seperated macimum number entered by user


            Console.Write("Enter comma separated numbers: ");
            var input = Console.ReadLine();

            var numbers = input.Split(',');

            // Assume the first number is the max 
            var max = Convert.ToInt32(numbers[0]);
            
            foreach (var str in numbers)
            {
                int number1 = Convert.ToInt32(str);
                if (number > max)
                    max = number;
            }

            Console.WriteLine("Max is " + max);
        }
        
    }
}
