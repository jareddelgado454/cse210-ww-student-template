using System;
using System.IO;

class Program
{
    // ---- EXTRA CREDIT COUNTERS ----
    static int breathingCount = 0;
    static int reflectionCount = 0;
    static int listingCount = 0;

    static void LogActivity(string activityName, int duration)
    {
        string entry = $"{DateTime.Now} - Completed {activityName} for {duration} seconds";
        File.AppendAllText("activityLog.txt", entry + Environment.NewLine);
    }

    /*
     EXTRA CREDIT IMPLEMENTATION:
     ----------------------------------------
     I added a logging system that tracks:
     - how many times each activity is performed
     - logs every activity to a file with date/time
     This exceeds the core requirements and adds
     additional functionality for tracking user progress.
     ----------------------------------------
    */

    static void Main(string[] args)
    {
        int choice = 0;

        while (choice != 4)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("\nChoose an option: ");

            choice = int.Parse(Console.ReadLine());
            Console.Clear();

            switch (choice)
            {
                case 1:
                    var b = new BreathingActivity();
                    b.Run();
                    breathingCount++;
                    LogActivity("Breathing Activity", b.GetDuration());
                    break;

                case 2:
                    var r = new ReflectionActivity();
                    r.Run();
                    reflectionCount++;
                    LogActivity("Reflection Activity", r.GetDuration());
                    break;

                case 3:
                    var l = new ListingActivity();
                    l.Run();
                    listingCount++;
                    LogActivity("Listing Activity", l.GetDuration());
                    break;

                case 4:
                    Console.WriteLine("\nActivity Summary (extra credit feature):");
                    Console.WriteLine($"Breathing: {breathingCount} times");
                    Console.WriteLine($"Reflection: {reflectionCount} times");
                    Console.WriteLine($"Listing: {listingCount} times");
                    Console.WriteLine("\nGoodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }

            Console.WriteLine("\nPress Enter to continue...");
            Console.ReadLine();
        }
    }
}
