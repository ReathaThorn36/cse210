using System;

class Program
{
    static void Main(string[] args)
    {
        // This program exceeds the core requirements by supporting:
        // - verse ranges in Reference (e.g., Proverbs 3:5-6)
        // - hiding multiple words at a time for faster memorization
        // - clean, encapsulated classes each with a single responsibility
        // - ready for extensions like multiple scriptures or saving progress

        Reference reference = new Reference("Proverbs", 3, 5, 6);
        string text = "Trust in the Lord with all thine heart; and lean not unto thine own understanding.";

        Scripture scripture = new Scripture(reference, text);

        Console.Clear();
        Console.WriteLine("Scripture Memorizer Program");
        Console.WriteLine("---------------------------");

        while (!scripture.AllWordsHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());

            Console.WriteLine("\nPress Enter to hide more words or type 'quit' to exit:");
            string input = Console.ReadLine().Trim().ToLower();

            if (input == "quit")
            {
                break;
            }

            scripture.HideRandomWords();
        }

        Console.Clear();
        Console.WriteLine("Final Scripture:\n");
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("\nGood job! Goodbye.");
    }
}
