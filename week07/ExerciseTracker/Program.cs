using System;
using System.Collections.Generic;

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
