using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt peace this month?",
        "Who are your personal heroes?"
    };

    public ListingActivity()
        : base("Listing Activity",
               "This activity will help you reflect on the good things in your life by listing as many items as you can.")
    { }

    public void Run()
    {
        StartMessage();

        Random rand = new Random();
        int duration = GetDuration();

        string prompt = _prompts[rand.Next(_prompts.Count)];
        Console.WriteLine($"\nPrompt: {prompt}");
        Console.WriteLine("You will begin in...");
        Countdown(3);

        List<string> items = new List<string>();
        DateTime end = DateTime.Now.AddSeconds(duration);

        Console.WriteLine("\nStart listing items! (press Enter for each one)");

        while (DateTime.Now < end)
        {
            Console.Write("> ");
            string item = Console.ReadLine();
            items.Add(item);
        }

        Console.WriteLine($"\nYou listed {items.Count} items!");

        EndMessage();
    }
}
