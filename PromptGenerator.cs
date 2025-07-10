using System;
using System.Collections.Generic;

public class PromptGenerator
{
    private List<string> _prompts = new List<string>
    {
        "What was the best part of your day?",
        "How did you show kindness today?",
        "What challenge did you face today?",
        "Describe a moment you felt grateful today.",
        "What did you learn today that surprised you?"
    };

    private Random _random = new Random();

    public string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }

    public string GetTodayPrompt()
    {
        int index = DateTime.Now.Day % _prompts.Count;
        return _prompts[index];
    }
}
