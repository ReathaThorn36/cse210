using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string fileName)
    {
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}|{entry._promptText}|{entry._entryText}|{entry._tag}");
            }
        }
    }

    public void LoadFromFile(string fileName)
    {
        _entries.Clear();

        string[] lines = File.ReadAllLines(fileName);
        foreach (string line in lines)
        {
            string[] parts = line.Split("|");

            Entry entry = new Entry
            {
                _date = parts[0],
                _promptText = parts[1],
                _entryText = parts[2],
                _tag = parts.Length > 3 ? parts[3] : ""
            };

            _entries.Add(entry);
        }
    }

    public void SearchByTag(string tag)
    {
        bool found = false;
        foreach (Entry entry in _entries)
        {
            if (!string.IsNullOrEmpty(entry._tag) && entry._tag.ToLower() == tag.ToLower())
            {
                entry.Display();
                found = true;
            }
        }

        if (!found)
        {
            Console.WriteLine($"No entries found with tag '{tag}'.");
        }
    }
}
