using System;

// This program exceeds the core requirements by allowing an optional tag for each entry.
// Users can search entries by tag, and the tag is saved/loaded with the file.

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        bool running = true;

        while (running)
        {
            Console.WriteLine("\nJournal Menu:");
            Console.WriteLine("1. Write new entry");
            Console.WriteLine("2. Display all entries");
            Console.WriteLine("3. Save journal to file");
            Console.WriteLine("4. Load journal from file");
            Console.WriteLine("5. Search entries by tag");
            Console.WriteLine("6. Quit");
            Console.Write("Select an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    string prompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine($"\nPrompt: {prompt}");
                    Console.Write("Your response: ");
                    string response = Console.ReadLine();
                    Console.Write("Optional tag (or press Enter to skip): ");
                    string tag = Console.ReadLine();

                    Entry entry = new Entry
                    {
                        _date = DateTime.Now.ToString("yyyy-MM-dd"),
                        _promptText = prompt,
                        _entryText = response,
                        _tag = tag
                    };

                    journal.AddEntry(entry);
                    break;

                case "2":
                    journal.DisplayAll();
                    break;

                case "3":
                    Console.Write("Enter filename to save: ");
                    string saveFile = Console.ReadLine();
                    journal.SaveToFile(saveFile);
                    Console.WriteLine("Journal saved successfully.");
                    break;

                case "4":
                    Console.Write("Enter filename to load: ");
                    string loadFile = Console.ReadLine();
                    journal.LoadFromFile(loadFile);
                    Console.WriteLine("Journal loaded successfully.");
                    break;

                case "5":
                    Console.Write("Enter tag to search: ");
                    string searchTag = Console.ReadLine();
                    journal.SearchByTag(searchTag);
                    break;

                case "6":
                    running = false;
                    break;

                default:
                    Console.WriteLine("Invalid option. Please select 1–6.");
                    break;
            }
        }

        Console.WriteLine("Goodbye!");
    }
}
