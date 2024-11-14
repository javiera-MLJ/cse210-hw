using System;

class Program
{

    static void Main(string[] args)
    {

        while (true)
        {

            Random randomGenerator = new Random();
            int magicN = randomGenerator.Next(1, 101);
            int guess = -1;


            while (guess != magicN)
            {

                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());


                if (guess < magicN)
                {
                    Console.WriteLine("Higher");
                }

                else if (guess > magicN)
                {
                    Console.WriteLine("Lower");
                }

                else
                {
                    Console.WriteLine("You guessed it!");
                }
            }

            Console.Write("do you want to play again? ");
            string response = Console.ReadLine();

            if (response != "yes")
            {
                Console.WriteLine("Thanks for playing! Goodbye!");
                break;
            }
        }
    }
}