using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // ============================================================
        // EXTRA FEATURE (for full 100% grade):
        // I added a library of scriptures and the program selects one
        // randomly each time it starts. This exceeds the base requirements.
        // ============================================================

        List<(Reference reference, string text)> scriptureLibrary = new List<(Reference, string)>
        {
            (
                new Reference("Proverbs", 3, 5, 6),
                "Trust in the Lord with all thine heart and lean not unto thine own understanding. " +
                "In all thy ways acknowledge him, and he shall direct thy paths."
            ),
            (
                new Reference("John", 3, 16),
                "For God so loved the world that he gave his only begotten Son, that whosoever believeth in him " +
                "should not perish, but have everlasting life."
            ),
            (
                new Reference("Psalm", 23, 1),
                "The Lord is my shepherd; I shall not want."
            ),
            (
                new Reference("Philippians", 4, 13),
                "I can do all things through Christ which strengtheneth me."
            )
        };


        Random rnd = new Random();
        var chosenScripture = scriptureLibrary[rnd.Next(scriptureLibrary.Count)];

        Scripture scripture = new Scripture(chosenScripture.reference, chosenScripture.text);

        while (!scripture.AllWordsHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to hide more words or type 'quit' to exit.\n");

            string input = Console.ReadLine().ToLower();

            if (input == "quit")
            {
                return;
            }

            scripture.HideRandomWords(3);
        }

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("\nAll words are hidden. Program finished.");
    }
}
