using System;
class ListingActivity : Activity
{
    public ListingActivity() : base() { }
    public void StartListingActivity()
    {
        StartActivity("Listing Activity", "Guide the user to think broadly, by helping them list as many things as they can in a certain area of strength or positivity. They might discover more breadth than they previously realized.");

        string[] listingPrompts = {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
        Random random = new Random();
        string selectedPrompt = listingPrompts[random.Next(listingPrompts.Length)];
        Console.WriteLine(selectedPrompt);
        Console.WriteLine("Take a moment to think about the prompt...");
        for (int i = 5; i > 0; i--)
        {
            Console.WriteLine($"Get ready to list in {i} seconds...");
            System.Threading.Thread.Sleep(1000);
        }
        Console.WriteLine("Start listing as many items as you can:");
        Console.WriteLine("You listed X items.");

        EndActivity("Listing Activity");
    }
}
