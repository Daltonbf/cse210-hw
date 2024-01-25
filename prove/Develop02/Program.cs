using System;
using System.Collections.Generic;

class JournalProgram
{
    static void Main()
    {
        PromptGenerator promptGenerator = new PromptGenerator
        {
            _prompts = new List<string>
            {
                "Who was the most interesting person I interacted with today?",
                "What was the best part of my day?",
                "How did I see the hand of the Lord in my life today?",
                "What was the strongest emotion I felt today?",
                "If I had one thing I could do over today, what would it be?"
            }
        };
        Journal journal = new Journal();
        while (true)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Entry newEntry = new Entry
                    {
                        _date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                        _promptText = promptGenerator.GetRandomPrompt()
                    };
                    Console.Write("Enter your response: ");
                    newEntry._entryText = Console.ReadLine();
                    journal.AddEntry(newEntry);
                    Console.WriteLine("Entry added successfully!\n");
                    break;
                case "2":
                    Console.WriteLine("\nJournal Entries:\n");
                    journal.DisplayAll();
                    break;
                case "3":
                    Console.Write("Enter filename to save: ");
                    string saveFileName = Console.ReadLine();
                    journal.SaveToFile(saveFileName);
                    Console.WriteLine("Journal saved to file successfully!\n");
                    break;
                case "4":
                    Console.Write("Enter filename to load: ");
                    string loadFileName = Console.ReadLine();
                    journal.LoadFromFile(loadFileName);
                    Console.WriteLine("Journal loaded from file successfully!\n");
                    break;
                case "5":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please enter a valid option.\n");
                    break;
            }
        }
    }
}
