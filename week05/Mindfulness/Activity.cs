using System;
using System.Threading;

public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void StartMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}.\n");
        Console.WriteLine(_description);
        Console.Write("\nHow long (in seconds) would you like this session? ");
        _duration = int.Parse(Console.ReadLine());

        Console.WriteLine("\nPrepare to begin...");
        Spinner(3);
    }

    public void EndMessage()
    {
        Console.WriteLine("\nGreat job!");
        Spinner(3);
        Console.WriteLine($"\nYou completed the {_name} for {_duration} seconds.");
        Spinner(3);
    }

    public int GetDuration()
    {
        return _duration;
    }

    // ----- Animaciones -----
    public void Spinner(int seconds)
    {
        string[] frames = { "|", "/", "-", "\\" };
        DateTime end = DateTime.Now.AddSeconds(seconds);

        int i = 0;
        while (DateTime.Now < end)
        {
            Console.Write(frames[i % 4]);
            Thread.Sleep(200);
            Console.Write("\b");
            i++;
        }
    }

    public void Countdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}
