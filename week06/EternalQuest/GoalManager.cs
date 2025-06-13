using System.IO;

class GoalManager
{
    private List<Goal> _goals;
    private List<Guild> _guilds;
    private List<Guild> _guildsJoined;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _guilds = new List<Guild>();
        _guildsJoined = new List<Guild>();
        _score = 0;
    }

    public void Start()
    {
        //This is the main loop
        Console.WriteLine("Welcome to Eternal Quest!");
        while (true)
        {
            Console.WriteLine("\n");
            DisplayPlayerInfo();
            Console.WriteLine("\n---------------");
            Console.WriteLine("Menu");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Join a Guild");
            Console.WriteLine("7. Quit Program");
            Console.Write("---------------\nWhat would you like to do: ");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    CreateGoal();
                    break;
                case 2:
                    ListGoalDetails();
                    break;
                case 3:
                    SaveGoals();
                    break;
                case 4:
                    LoadGoals();
                    break;
                case 5:
                    RecordEvent();
                    break;
                case 6:
                    ListGuilds();
                    break;
                default:
                    break;
            }
            if (choice == 7) break;
            Console.WriteLine("\n");
        }
    }

    public void AddGuild(Guild guild) {
        _guilds.Add(guild);
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Your current score is: {_score}.");
    }

    public void AddGuildGoals(Guild guild)
    {
        foreach (Goal goal in guild.GetGoals()) _goals.Add(goal);
    }
    public void ListGuilds()
    {
        Console.WriteLine("\nGuilds:\n");
        int i = 0;
        foreach (Guild guild in _guilds)
        {
            ++i;
            Console.WriteLine($"{i}) {guild.GetDisplayString()}");
            Console.WriteLine("\n");
        }
        Console.WriteLine("Would you like to join a guild?  Enter which number of guild if yes, otherwise write 'n'.\n");
        string guildChoice = Console.ReadLine();
        if (guildChoice == "n") return;
        int guildNumber = int.Parse(guildChoice) - 1;
        if (guildNumber < 0 || guildNumber >= _guilds.Count)
        {
            Console.WriteLine("Invalid Guild Choice.");
            return;
        }
        AddGuildGoals(_guilds[guildNumber]);
        _guildsJoined.Add(_guilds[guildNumber]);
        Console.WriteLine("\nYou have joined the guild!  New goals have been added.\n");
    }

    public void GetTitle()
    {
        Console.WriteLine("Your Titles:");
        foreach (Guild guild in _guildsJoined)
        {
            Console.WriteLine($"Level {guild.GetLevel()} {guild.GetName()}");
        }
        Console.WriteLine();
    }
    public void ListGoalDetails()
    {
        Console.WriteLine("\nGoals:\n");
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetDetails());
        }
    }

    public void ListGoalNames()
    {
        int j = 0;
        foreach (Goal goal in _goals)
        {
            ++j;
            Console.WriteLine($"{j}. {goal.GetName()}");
        }

    }

    public void RecordEvent()
    {
        Console.WriteLine("Which Goal would you like to record?");
        ListGoalNames();
        int choice = int.Parse(Console.ReadLine()) - 1;
        int scoreIncrease;
        if (choice >= 0 && choice < _goals.Count)
            scoreIncrease = _goals[choice].RecordEvent();
        else
        {
            Console.WriteLine("Invalid Goal Choice");
            return;
        }
        Console.WriteLine($"You have earned {scoreIncrease} points!");
        _score += scoreIncrease;
    }

    public void CreateGoal()
    {
        Console.WriteLine("What type of goal would you like to create?\n1. Simple Goal\n2. Eternal Goal\n3. Checklist Goal");
        int choice = int.Parse(Console.ReadLine());
        if (choice == 1)
        {
            Console.Write("What is the name of your goal: ");
            string name = Console.ReadLine();
            Console.Write("What is a brief description of your goal: ");
            string description = Console.ReadLine();
            Console.Write("How many points is this goal worth: ");
            int points = int.Parse(Console.ReadLine());
            _goals.Add(new SimpleGoal(name, description, points));
            Console.WriteLine("The Goal has been added.");
        }
        else if (choice == 2)
        {
            Console.Write("What is the name of your goal: ");
            string name = Console.ReadLine();
            Console.Write("What is a brief description of your goal: ");
            string description = Console.ReadLine();
            Console.Write("How many points is this goal worth: ");
            int points = int.Parse(Console.ReadLine());
            _goals.Add(new EternalGoal(name, description, points));
            Console.WriteLine("The Goal has been added.");
        }
        else if (choice == 3)
        {
            Console.Write("What is the name of your goal: ");
            string name = Console.ReadLine();
            Console.Write("What is a brief description of your goal: ");
            string description = Console.ReadLine();
            Console.Write("How many times would you like to do this goal: ");
            int times = int.Parse(Console.ReadLine());
            Console.Write("How many points is this goal worth: ");
            int points = int.Parse(Console.ReadLine());
            Console.Write("When completed, what bonus should be rewarded for this goal: ");
            int bonus = int.Parse(Console.ReadLine());
            _goals.Add(new ChecklistGoal(name, description, points, times, bonus));
            Console.WriteLine("The Goal has been added.");
        }
        else
        {
            Console.WriteLine("Invalid Choice Number.");
        }
    }

    public void SaveGoals()
    {
        Console.WriteLine("What file would you like to save to?");
        string filename = Console.ReadLine();
        Console.WriteLine("Saving...");
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }

        }
        Console.WriteLine("Goals Saved.\n");
    }

    public void LoadGoals()
    {
        Console.WriteLine("What file would you like to load from?");
        string filename = Console.ReadLine();
        Console.WriteLine("Loading...");
        string[] lines = File.ReadAllLines(filename);
        _score += int.Parse(lines[0]);
        foreach (string line in lines)
        {
            if (!line.StartsWith("Simple") && !line.StartsWith("Checklist") && !line.StartsWith("Eternal")) continue;
            string[] parts = line.Split("|");
            if (parts[0] == "Simple")
            {
                _goals.Add(new SimpleGoal(parts[1], parts[2], int.Parse(parts[4])));
                bool completed = (parts[3] == "1") ? true : false;
                if (completed) _goals[_goals.Count - 1].RecordEvent();
            }
            else if (parts[0] == "Checklist")
            {
                _goals.Add(new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[6])));
                for (int i = 0; i < int.Parse(parts[5]); ++i) _goals[_goals.Count - 1].RecordEvent();
            }
            else if (parts[0] == "Eternal")
            {
                _goals.Add(new EternalGoal(parts[1], parts[2], int.Parse(parts[3])));
            }
        }
        Console.WriteLine("Goals Loaded.\n");
    }


}