using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        int UserNumber = -1;

        int sum = 0;
        int maxNumber = 0;
        int mixNumber = int.MaxValue;

        while (UserNumber != 0)
        {
            Console.Write("Enter number: ");
            UserNumber = int.Parse(Console.ReadLine());

            if (UserNumber != 0)
            {
                numbers.Add(UserNumber);
            }
        }

        foreach (int number in numbers)
        {
            sum += number;

            if (number > maxNumber)
            {
                maxNumber = number;
            }

            if (number < mixNumber && number > 0)
            {
                mixNumber = number;
            }

        }

        float average = (float)sum / numbers.Count;
        numbers.Sort();

        Console.WriteLine($"The sum is:{sum}");
        Console.WriteLine($"The average is:{average}");
        Console.WriteLine($"The largest number is:{maxNumber}");
        Console.WriteLine($"The smallest positive number is:{mixNumber}");
        Console.WriteLine($"The sorted list is: ");

        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }

    }
}