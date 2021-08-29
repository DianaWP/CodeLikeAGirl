using System;

namespace Lesson6
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 0;
            int number2 = 0;

            Console.WriteLine("Basic Calculator");

            Console.WriteLine("Enter your first number and press enter");
            number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your second number and press enter");
            number2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Choose an operator from the list");
            Console.WriteLine("a - Add");
            Console.WriteLine("s - Subtract");
            Console.WriteLine("m - Multiply");
            Console.WriteLine("d - Divide");
            Console.WriteLine("Which will you choose");

            switch (Console.ReadLine())
            {
                case "a":
                    Console.WriteLine($"Your resule: {number1} + {number2} = " + (number1 + number2));
                    break;

                case "s":
                    Console.WriteLine($"Your resule: {number1} - {number2} = " + (number1 - number2));
                    break;

                case "m":
                    Console.WriteLine($"Your resule: {number1} * {number2} = " + (number1 * number2));
                    break;

                case "d":
                    Console.WriteLine($"Your resule: {number1} / {number2} = " + (number1 / number2));
                    break;
            }
        }
    }
}
