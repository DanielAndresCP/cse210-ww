class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    // I know that passing these values to the base constructor like this doesn't look pretty,
    // but I believe it is a good option, because any other way of doing it requires exposing one way or another
    // the needed attributes
    public ReflectingActivity() : base("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
        _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };
        _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine("");
        DisplayPrompt(GetRandomPrompt());
        Console.WriteLine("");
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        ShowCountdown(5);
        Console.WriteLine("");

        Console.Clear();
        int duration = GetDuration();
        int secondsPerQuestion = 15;

        DateTime endTime = DateTime.Now.AddSeconds(duration);
        while (DateTime.Now < endTime)
        {
            DisplayQuestion(GetRandomQuestion());
            Console.Write(" ");
            ShowSpinner(secondsPerQuestion);
            Console.WriteLine("");
        }

        Console.WriteLine("");
        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int i = random.Next(0, _prompts.Count);
        return _prompts[i];
    }

    public string GetRandomQuestion()
    {
        Random random = new Random();
        int i = random.Next(0, _questions.Count);
        return _questions[i];
    }

    public void DisplayPrompt(string prompt)
    {
        Console.WriteLine($" --- {prompt} ---");
    }

    public void DisplayQuestion(string question)
    {
        Console.Write($"> {question}");
    }
}