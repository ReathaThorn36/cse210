using System;

public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;
    public string _tag;  // Optional tag field

    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_promptText}");
        Console.WriteLine($"{_entryText}");
        if (!string.IsNullOrWhiteSpace(_tag))
        {
            Console.WriteLine($"Tag: {_tag}");
        }
        Console.WriteLine();
    }
}
