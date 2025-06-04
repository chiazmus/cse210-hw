class ListingActivity : Activity
{
    private List<string> _prompts;
    private int _count;

    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        _prompts = new List<string>();
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");
        _count = 0;

        //Lets do that random list order thingy again here.
        Random rng = new Random();
        _prompts = _prompts.OrderBy(x => rng.Next()).ToList();
    }

    public void GetRandomPrompt()
    {
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine($"-- {_prompts[_count]} --");
        _count = (_count + 1) % _prompts.Count;
        Console.Write("You may begin in: ");
        CountDown(5);
        Console.WriteLine();
    }

    public List<string> GetList(DateTime end_time)
    {
        List<string> inputs = new List<string>();

        DateTime currentTime = DateTime.Now;
        while (currentTime < end_time)
        {
            Console.Write('>');
            inputs.Add(Console.ReadLine());
            Console.WriteLine();
            currentTime = DateTime.Now;
        }
        return inputs;
    }

    public void Run()
    {
        DisplayStartingMessage();
        GetRandomPrompt();
        List<string> inputs = GetList(DateTime.Now.AddSeconds(GetDuration()));
        Console.WriteLine($"You listed {inputs.Count} items!");
        Console.WriteLine();
        DisplayEndingMessage();
    }


}