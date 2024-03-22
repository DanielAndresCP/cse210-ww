class BreathingActivity : Activity
{
    // I know that passing these values to the base constructor like this doesn't look pretty,
    // but I believe it is a good option, because any other way of doing it requires exposing one way or another
    // the needed attributes
    public BreathingActivity() : base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
        // There's nothing we need to do here
    }

    public void Run()
    {
        DisplayStartingMessage();
        int breatheInSeconds = 4;
        int breatheOutSeconds = 6;
        int duration = GetDuration();

        DateTime endTime = DateTime.Now.AddSeconds(duration);
        while (DateTime.Now < endTime)
        {
            Console.WriteLine("");
            Console.Write("Breathe in...");
            ShowCountdown(breatheInSeconds);
            Console.WriteLine("");
            Console.Write("Breathe out...");
            ShowCountdown(breatheOutSeconds);
            Console.WriteLine("");
        }

        Console.WriteLine("");
        DisplayEndingMessage();
    }
}