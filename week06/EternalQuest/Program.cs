// EXCEEDS REQUIREMENTS:
// Added a basic LEVEL SYSTEM: user levels up every 1000 points.

using System;

class Program
{
    static void Main()
    {
        GoalManager gm = new GoalManager();

        int level = 1;

        int choice = 0;

        while (choice != 7)
        {
            Console.WriteLine($"\nYour score: {gm.GetScore()}  | Level: {level}");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Show Score");
            Console.WriteLine("7. Quit");

            Console.Write("Choose an option: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1: gm.CreateGoal(); break;
                case 2: gm.ListGoals(); break;
                case 3: gm.SaveGoals(); break;
                case 4: gm.LoadGoals(); break;
                case 5: gm.RecordEvent(); break;
                case 6: Console.WriteLine($"Your score is {gm.GetScore()}"); break;
            }

            level = (gm.GetScore() / 1000) + 1;
        }
    }
}
