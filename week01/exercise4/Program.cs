using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        int number;
        do
        {
            Console.Write("Enter number: ");
            string? input = Console.ReadLine();

            if (!int.TryParse(input, out number))
            {
                Console.WriteLine("Please enter a valid integer.");
                continue;
            }

            if (number != 0)
            {
                numbers.Add(number);
            }

        } while (number != 0);

        if (numbers.Count == 0)
        {
            Console.WriteLine("No numbers were entered.");
        }
        else
        {
            int sum = 0;
            foreach (int n in numbers)
            {
                sum += n;
            }

            double average = (double)sum / numbers.Count;

            int max = numbers[0];
            foreach (int n in numbers)
            {
                if (n > max)
                    max = n;
            }

            Console.WriteLine($"The sum is: {sum}");
            Console.WriteLine($"The average is: {average}");
            Console.WriteLine($"The largest number is: {max}");
        }
    }
}
