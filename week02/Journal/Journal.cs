using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> Entries { get; set; } = new List<Entry>();

    private List<string> prompts = new List<string>()
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What is something new I learned today?"
    };

    public void AddEntry()
    {
        Random rnd = new Random();
        string prompt = prompts[rnd.Next(prompts.Count)];

        Console.WriteLine(prompt);
        Console.Write("> ");
        string response = Console.ReadLine();

        string date = DateTime.Now.ToString("MM/dd/yyyy");

        Entries.Add(new Entry(date, prompt, response));
    }

    public void DisplayJournal()
    {
        foreach (var entry in Entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var entry in Entries)
            {
                writer.WriteLine(entry.GetEntryAsString());
            }
        }

        Console.WriteLine("Journal saved successfully.");
    }

    public void LoadFromFile(string filename)
    {
        Entries.Clear();

        string[] lines = File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            Entries.Add(Entry.LoadFromString(line));
        }

        Console.WriteLine("Journal loaded successfully.");
    }
}
