using System;
using System.Collections.Generic;

/*
 * This program:
 * - Demonstrates polymorphism with exercise classes
 * - Displays a summary report of all exercises
 * - Is structured for future input validation and menu interface additions
 */

class Program
{
    static void Main()
    {
        List<Exercise> activities = new List<Exercise>
        {
            new Running("03 Aug 2025", 30, 4.8),
            new Cycling("03 Aug 2025", 45, 15.0),
            new Swimming("03 Aug 2025", 40, 30)
        };

        foreach (Exercise activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}

