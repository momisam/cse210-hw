using System;

class Entry
{
    public string Date { get; private set; }
    public string Prompt { get; private set; }
    public string Text { get; private set; }

    public Entry(string prompt, string text)
    {
        Date = DateTime.Now.ToShortDateString();
        Prompt = prompt;
        Text = text;
    }

    // Overloaded constructor used when loading from file
    public Entry(string prompt, string text, string date)
    {
        Date = date;
        Prompt = prompt;
        Text = text;
    }

    public void Display()
    {
        Console.WriteLine($"Date: {Date}");
        Console.WriteLine($"Prompt: {Prompt}");
        Console.WriteLine($"Response: {Text}");
    }
}
