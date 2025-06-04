using System;

// To exceed requierements, I made it so that no prompts or questions are displayed twice until all of them have been used up in the listing activity and reflecting activity.
// I also added in a counter for each activity that displays how many times the user has done them.
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project.");
        ListingActivity listAct = new ListingActivity();
        BreathingActivity breatheAct = new BreathingActivity();
        ReflectingActivity reflectAct = new ReflectingActivity();

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine($"1. Start breathing activity. (Completed {breatheAct.GetTimesPerformed()} times)");
            Console.WriteLine($"2. Start reflecting activity. (Completed {reflectAct.GetTimesPerformed()} times)");
            Console.WriteLine($"3. Start listing activity. (Completed {listAct.GetTimesPerformed()} times)");
            Console.WriteLine("4. Quit");
            Console.Write("> ");
            string choice = Console.ReadLine();

            if (choice == "1") breatheAct.Run();
            else if (choice == "2") reflectAct.Run();
            else if (choice == "3") listAct.Run();
            else if (choice == "4") break;
            else Console.WriteLine("Thats not a valid choice.  Please try again.");
        }

        Console.WriteLine("Goodbye!");
    }
}