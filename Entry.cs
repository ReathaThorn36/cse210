using System;

public class Entry
{
    public string Date { get; set; }
    public string Prompt { get; set; }
    public string Response { get; set; }
    public string Tag { get; set; }
    public string Emotion { get; set; }

    public Entry(string date, string prompt, string response, string tag = "", string emotion = "")
    {
        Date = date;
        Prompt = prompt;
        Response = response;
        Tag = tag;
        Emotion = emotion;
    }

    public void Display()
    {
        Console.WriteLine($"Date: {Date}");
        Console.WriteLine($"Prompt: {Prompt}");
        Console.WriteLine($"Response: {Response}");
        if (!string.IsNullOrEmpty(Tag))
            Console.WriteLine($"Tag: {Tag}");
        if (!string.IsNullOrEmpty(Emotion))
            Console.WriteLine($"Emotion: {Emotion}");
        Console.WriteLine("--------------------------------------------------");
    }

    public string ToCsv()
    {
        return $"{Date}|{Prompt}|{Response}|{Tag}|{Emotion}";
    }

    public static Entry FromCsv(string csv)
    {
        string[] parts = csv.Split('|');
        return new Entry(parts[0], parts[1], parts[2], parts.Length > 3 ? parts[3] : "", parts.Length > 4 ? parts[4] : "");
    }
}
