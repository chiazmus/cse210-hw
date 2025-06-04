class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    private int promptCounter = 0;
    private Random randomNumberGenerator = new Random();
    public ReflectingActivity() : base("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience.")
    {
        _prompts = new List<string>();
        _questions = new List<string>();
        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless.");

        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What made this time different than other times when you were not as successful?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("What could you learn from this experience that applies to other situations?");
        _questions.Add("What did you learn about yourself through this experience?");
        _questions.Add("How can you keep this experience in mind in the future?");

        // Now I'm going to randomise the prompts and questions right here so I don't have to worry about pulling the same ones.  I can just iterate on a list of them.
        _prompts = _prompts.OrderBy(x => randomNumberGenerator.Next()).ToList();
        _questions = _questions.OrderBy(x => randomNumberGenerator.Next()).ToList();


    }

    public string GetRandomPrompt()
    {
        string nextPrompt = _prompts[promptCounter];
        return nextPrompt;
    }

    public string GetRandomQuestion()
    {
        string nextQuestion = _questions[promptCounter];
        promptCounter = (promptCounter + 1) % Math.Max(_questions.Count, _prompts.Count);
        return nextQuestion;
    }

    public void DisplayPrompt()
    {
        Console.WriteLine($"-- {GetRandomPrompt()} --");
        Console.WriteLine("Press Enter when you're ready to continue.");
        Console.ReadLine();
        Console.WriteLine();
    }

    public void DisplayQuestion(int seconds)
    {
        Console.WriteLine(GetRandomQuestion());
        DisplaySpinner(seconds);
    }

    public void Run()
    {
        const int promptTime = 10;

        DisplayStartingMessage();
        DisplayPrompt();

        int promptQuestions = GetDuration() / promptTime;
        for (int i = 1; i <= promptQuestions; ++i)
        {
            DisplayQuestion(promptTime);
            Console.WriteLine();
        }

        DisplayEndingMessage();

    }

}