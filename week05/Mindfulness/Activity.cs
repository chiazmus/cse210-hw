using System.ComponentModel;

class Activity
{
    private string _name;
    private int _time;
    private string _description;

    private int _timesPerformed;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
        _timesPerformed = 0;
    }

    public int GetTimesPerformed()
    {
        return _timesPerformed;

    }

    public int GetDuration()
    {
        return _time;
    }
    public void DisplayStartingMessage()
    {
        ++_timesPerformed;
        Console.WriteLine($"Beginning {_name}.");
        Console.WriteLine(_description);
        Console.Write($"How long would you like this activity to go (in seconds)? ");
        _time = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Get Ready...");
        DisplaySpinner(5);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Time's up!");
        DisplaySpinner(5);
        Console.WriteLine($"You have completed {_time} seconds of the {_name}.");
        DisplaySpinner(5);
    }

    public void DisplaySpinner(int seconds)
    {
        // Ima make the spinner do one rotation per second to simplify things
        // Animation frames: | / - \
        // Initially the animation was a bit glitchy so Im hiding the cursor while it plays.
        Console.CursorVisible = false;
        for (int i = 0; i < (seconds * 2); ++i)
        {
            Console.Write("|");
            Thread.Sleep(125);
            Console.Write("\b \b");
            Console.Write("/");
            Thread.Sleep(125);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(125);
            Console.Write("\b \b");
            Console.Write("\\");
            Thread.Sleep(125);
            Console.Write("\b \b");
        }
        Console.CursorVisible = true;

    }

    public void CountDown(int seconds)
    {
        Console.CursorVisible = false;
        for (int i = 0; i < seconds; ++i)
        {
            Console.Write($"{seconds - i}");
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.CursorVisible = true;
    }
}