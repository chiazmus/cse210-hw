class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", "This is a simple breathing activity, desgined to help you acheive a state of mindfulness.") { }

    public void Run()
    {
        const int breathIn = 4;
        const int breathOut = 6;

        DisplayStartingMessage();

        int breaths = GetDuration() / (breathIn + breathOut);
        for (int i = 1; i <= breaths; ++i)
        {
            Console.WriteLine();
            Console.Write("Breathe In ");
            CountDown(breathIn);
            Console.WriteLine();
            Console.Write("Breathe Out ");
            CountDown(breathOut);
            Console.WriteLine();
        }

        DisplayEndingMessage();

    }
}