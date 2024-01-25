using System;
class Program1 {
    static void Main() {
        Reference reference = new Reference("John", 3, 16);
        Scripture scripture = new Scripture(reference, "For God so loved the world...");
        Console.Clear();
        Console.WriteLine($"Reference: {reference.GetDisplayText()}");
        Console.WriteLine($"Scripture: {scripture.GetDisplayText()}");
        while (!scripture.IsCompletelyHidden()) {
            Console.WriteLine("Press Enter to hide more words or type 'quit' to exit.");
            string input = Console.ReadLine().ToLower();
            if (input == "quit") break;
            scripture.HideRandomWords(3);
            Console.Clear();
            Console.WriteLine($"Reference: {reference.GetDisplayText()}");
            Console.WriteLine($"Scripture: {scripture.GetDisplayText()}");
        }
        Console.WriteLine("Program ended.");
    }
}