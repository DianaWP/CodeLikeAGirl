using System;

namespace Lesson4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number Guesser");

            bool playWhilstTrue = true;

            while (playWhilstTrue)
            {
                Console.WriteLine("What numbers should we guess between");
                
                Console.WriteLine("What number should be the lowest to guess between");
                var lowerRange = int.Parse(Console.ReadLine().Trim());

                Console.WriteLine($"{lowerRange}! Ok, now what is the highest number to guess between");
                var higherRange = int.Parse(Console.ReadLine().Trim());

                Console.WriteLine("Ok so we are guessing between {lowerRange} and {higherRange}?");

                Console.WriteLine("Final queation, how many guesses do you need?");
                var numberOfGuesses = int.Parse(Console.ReadLine().Trim());

                bool invalidGuesses = true;
                while (invalidGuesses)
                {
                    if (numberOfGuesses > 20)
                    {
                        Console.WriteLine("Ok have as many guesses as you need");
                        invalidGuesses = false;

                    }

                    else if (numberOfGuesses <= 0)

                    {
                        Console.WriteLine("Cant have 0 guesses, please enter a positive number");
                        var newNumberOfGuesses = int.Parse(Console.ReadLine().Trim());
                        numberOfGuesses = newNumberOfGuesses;
                    }
                    else
                    {
                        Console.WriteLine($"So you reckon you can do it in {numberOfGuesses} guesses");
                        invalidGuesses = false;
                    }
                }
            

            var randomNumberCreator = new Random();
            var randomNumber = randomNumberCreator.Next(lowerRange, higherRange + 1);

            Console.WriteLine($"I am thinking of a number between {lowerRange} and {higherRange}. What is it?");

            if (numberOfGuesses > 20)
            {
                Console.WriteLine($"You have as many guesses as you like");
            }

            else 
            {
                Console.WriteLine($"You have {numberOfGuesses} guesses left");
            }

        var guess = int.Parse(Console.ReadLine().Trim());

        int guessCounter = 0;
        while (guess != randomNumber)
        {
            if (guess < higherRange || guess > lowerRange)
            {
                Console.WriteLine($"Nope, looking for a number between {higherRange} and {lowerRange}");
            }
            else if (guess > randomNumber)
            {
                Console.WriteLine($"Close but try going lower");
            }
            else if (guess < randomNumber)
            {
                Console.WriteLine($"Not quite, try going higher");

            }

            guessCounter++;

            if (numberOfGuesses <= guessCounter)
            {
                break;
            }

            else 
            {
                if (numberOfGuesses < 21)
                {
                    Console.WriteLine($"You have {numberOfGuesses - guessCounter} left");
                }
            var nextGuess = int.Parse(Console.ReadLine().Trim());
            guess = nextGuess;
            }
        }
        if (guess == randomNumber && (guessCounter <= numberOfGuesses || numberOfGuesses > 20))
        {
            Console.WriteLine($"Woohoo, it was {randomNumber}!");
        }
        else
        {
            Console.WriteLine($"Better Luck Next Time, it was actually {randomNumber}");
        }

        Console.WriteLine("Thanks for playing");

        }


    }
}
}
