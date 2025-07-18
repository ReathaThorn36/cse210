using System;

/// <summary>
/// Scripture Memorizer Program
/// This program meets and exceeds the core requirements by:
/// - Supporting verse ranges in the Reference class (e.g., Proverbs 3:5-6)
/// - Hiding multiple words at a time for faster memorization
/// - Using clean, encapsulated classes each with a single responsibility
/// - Designed to be extendable for multiple scriptures or saving progress
/// </summary>
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
        Console.WriteLine(scripture.GetDisplayText());

        while (!scripture.AllWordsHidden())
        {
            Console.WriteLine("\nPress Enter to hide more words or type 'quit' to exit:");
            string input = Console.ReadLine().Trim().ToLower();

            if (input == "quit")
            {
                break;
            }

            scripture.HideRandomWords(5);  // hide 5 words per enter for faster hiding
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
        }

        if (scripture.AllWordsHidden())
        {
            Console.WriteLine("\nAll words are hidden! Great job memorizing.");
        }

        Console.WriteLine("\nGood job! Goodbye.");
    }
}
