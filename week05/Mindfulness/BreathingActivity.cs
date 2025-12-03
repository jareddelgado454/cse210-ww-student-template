using System;

public class BreathingActivity : Activity
{
    public BreathingActivity() 
        : base("Breathing Activity",
              "This activity will help you relax by walking you through breathing slowly. Clear your mind and focus on your breathing.")
    { }

    public void Run()
    {
        StartMessage();

        int duration = GetDuration();
        int elapsed = 0;

        while (elapsed < duration)
        {
            Console.Write("\nBreathe in... ");
            Countdown(4);
            elapsed += 4;

            if (elapsed >= duration) break;

            Console.Write("\nBreathe out... ");
            Countdown(4);
            elapsed += 4;
        }

        EndMessage();
    }
}
