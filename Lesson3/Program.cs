using System;
using System.Collections.Generic;

namespace Lesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to your Shoe Calculator");

            var firstList = new List<double>{};

            userInput(firstList);
            var finalAmount = totalEndAmount(firstList);
            checkIfSavedEnough(firstList, finalAmount);
        }

        static void userInput(List<double> list)
        {
            Console.WriteLine("First Deposit: ");
            list.Add(double.Parse(Console.ReadLine()));

            Console.WriteLine("Interest Rate (percentage(): ");
            list.Add(double.Parse(Console.ReadLine()));

            Console.WriteLine("Number of months to save: ");
            list.Add(double.Parse(Console.ReadLine()));

            Console.WriteLine("Savings Goal:");
            list.Add(double.Parse(Console.ReadLine()));

            Console.WriteLine();
        }

        static double totalEndAmount(List<double> list)
        {
            var balance = list[0];
            for (int i = 0; i < list[2]; i++)
            {
                var x = balance * (list[1]/100);
                balance += x;
            }
            return Math.Round(balance, 2);
        }

        static void checkIfSavedEnough(List<double> list, double finalBalance)
        {
            Console.WriteLine($"After {list[2]} months, you should have ${finalBalance}");
            if (list[3] <= finalBalance)
            {
                Console.WriteLine($"You have reached your goal of ${list[3]}, Go get those shoes!");
            }
            else
            {
                Console.WriteLine($"You do not have enough for shoes");
            }
        }
    }
}
