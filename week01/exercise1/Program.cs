﻿using System;

class Program
{
    static void Main()
    {
        // Prompt for first name
        Console.Write("What is your first name? ");
        string? firstName = Console.ReadLine();

        // Prompt for last name
        Console.Write("What is your last name? ");
        string? lastName = Console.ReadLine();

        // Display the output in the required format
        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");
    }
}
