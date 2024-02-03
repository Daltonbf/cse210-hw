class Program
{
    static void Main()
    {
        BreathingActivity breathingActivity = new BreathingActivity();
        ReflectionActivity reflectionActivity = new ReflectionActivity();
        ListingActivity listingActivity = new ListingActivity();
        Console.WriteLine("Choose an activity:");
        Console.WriteLine("1. Breathing Activity");
        Console.WriteLine("2. Reflection Activity");
        Console.WriteLine("3. Listing Activity");
        int choice = int.Parse(Console.ReadLine());
        switch (choice)
        {
            case 1:
                breathingActivity.StartBreathingActivity();
                break;
            case 2:
                reflectionActivity.StartReflectionActivity();
                break;
            case 3:
                listingActivity.StartListingActivity();
                break;
            default:
                Console.WriteLine("Invalid choice.");
                break;
        }
    }
}