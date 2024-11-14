using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string userInput = Console.ReadLine();
        int percentage = int.Parse(userInput);

        string grade = "";

        if (percentage >= 90)
        {
            grade = "A";
        }

        else if (percentage >= 80)
        {
            grade = "B";
        }

        else if (percentage >= 70)
        {
            grade = "C";
        }

        else if (percentage >= 60)
        {
            grade = "D";
        }

        else if (percentage < 60)
        {
            grade = "F";
        }

        Console.WriteLine($"Your grade is : {grade}");

        if (percentage >= 70)
        {
            Console.WriteLine("congratulations, you have passed the course");
        }

        else
        {
            Console.WriteLine("We are very sorry, you have not passed the course, do not give up, try again");
        }

    }
}