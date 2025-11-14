using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();

        bool running = true;

        while (running)
        {
            Console.WriteLine("\nJournal Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display journal");
            Console.WriteLine("3. Save journal to file");
            Console.WriteLine("4. Load journal from file");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    journal.AddEntry();
                    break;

                case "2":
                    journal.DisplayJournal();
                    break;

                case "3":
                    Console.Write("Enter filename: ");
                    journal.SaveToFile(Console.ReadLine());
                    break;

                case "4":
                    Console.Write("Enter filename: ");
                    journal.LoadFromFile(Console.ReadLine());
                    break;

                case "5":
                    running = false;
                    break;

                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }
    }
}
