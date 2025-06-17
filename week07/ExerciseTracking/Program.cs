using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ExerciseTracking Project.");
        List<Activity> activities = new List<Activity>();
        activities.Add(new Swimming("Swimming", 45, 5));
        activities.Add(new Cycling("Cycling", 60, 25));
        activities.Add(new Running("Running", 30, 5));
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}