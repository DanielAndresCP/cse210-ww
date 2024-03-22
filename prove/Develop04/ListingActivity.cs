class ListingActivity : Activity
{
    private List<string> _answers = new List<string>();
    private List<string> _prompts;

    // I know that passing these values to the base constructor like this doesn't look pretty,
    // but I believe it is a good option, because any other way of doing it requires exposing one way or another
    // the needed attributes
    public ListingActivity() : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine("");
        DisplayPrompt(GetRandomPrompt());
        Console.WriteLine("");
        Console.Write("You may begin in: ");
        ShowCountdown(10);
        Console.WriteLine("");

        int duration = GetDuration();
        DateTime endTime = DateTime.Now.AddSeconds(duration);

        while (DateTime.Now < endTime)
        {
            GetAnswerFromUser();
        }

        Console.WriteLine("");
        Console.WriteLine($"You listed {GetAnswerCount()} items!");
        Console.WriteLine("");

        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int i = random.Next(0, _prompts.Count);
        return _prompts[i];
    }

    public void DisplayPrompt(string prompt)
    {
        Console.WriteLine($" --- {prompt} ---");
    }

    public int GetAnswerCount()
    {
        return _answers.Count;
    }

    public void GetAnswerFromUser()
    {
        Console.Write("> ");
        string answer = Console.ReadLine();

        _answers.Add(answer);
    }
}