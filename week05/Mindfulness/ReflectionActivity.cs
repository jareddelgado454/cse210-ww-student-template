using System;
using System.Collections.Generic;

public class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new List<string>()
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times?",
        "What could you learn from this experience?",
        "What did you learn about yourself?",
        "How can you keep this experience in mind?"
    };

    public ReflectionActivity()
        : base("Reflection Activity",
               "This activity will help you reflect on times when you have shown strength and resilience.")
    { }

    public void Run()
    {
        StartMessage();

        Random rand = new Random();
        int duration = GetDuration();
        int elapsed = 0;

        string prompt = _prompts[rand.Next(_prompts.Count)];
        Console.WriteLine($"\nPrompt: {prompt}\n");
        Spinner(4);
        elapsed += 4;

        while (elapsed < duration)
        {
            string q = _questions[rand.Next(_questions.Count)];
            Console.WriteLine($"\n> {q}");
            Spinner(5);

            elapsed += 5;
        }

        EndMessage();
    }
}
