using System;
// So to show some extra creativity, I made "guilds", which are basically sets of premade Goals around a theme.
// I also made a way to display your level within each guild, but I couldn't come up with a good way to save it, so it's kind of just there in the code.
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the EternalQuest Project.");
        Guild adventurersGuild = new Guild("Adventurer", "A guild for the adventurous and the brave!");
        adventurersGuild.AddGoal(new SimpleGoal("Venture to Foreign Lands", "Visit a new country you've never been to", 2000));
        adventurersGuild.AddGoal(new ChecklistGoal("Go Exploring", "Visit five new places", 20, 5, 100));
        adventurersGuild.AddGoal(new EternalGoal("Go Hiking", "Go for a short hike", 20));

        Guild scholarsGuild = new Guild("Scholar", "A guild for those who love learning and intellectual pursuits.");
        scholarsGuild.AddGoal(new SimpleGoal("Read a Book", "Finish reading a book", 100));
        scholarsGuild.AddGoal(new ChecklistGoal("Attend Class", "Attend three educational classes or lectures", 50, 3, 200));
        scholarsGuild.AddGoal(new EternalGoal("Learn Something New", "Learn a new skill or fact", 10));

        Guild artistsGuild = new Guild("Artist", "A guild for those who enjoy creativity and artistic expression.");
        artistsGuild.AddGoal(new SimpleGoal("Paint", "Complete a painting or drawing", 300));
        artistsGuild.AddGoal(new ChecklistGoal("Write Poems", "Write five poems", 40, 5, 150));
        artistsGuild.AddGoal(new EternalGoal("Sketch Daily", "Create a small sketch", 10));


        GoalManager manager = new GoalManager();
        manager.AddGuild(adventurersGuild);
        manager.Start();
    }
}