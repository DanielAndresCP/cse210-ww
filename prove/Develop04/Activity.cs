class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name} Activity.");
        Console.WriteLine("");
        Console.WriteLine(_description);

        Console.WriteLine("");
        Console.Write("How long, in seconds, would you like your session to be? ");
        _duration = int.Parse(Console.ReadLine());

        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(5);
        Console.WriteLine("");
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!!");
        ShowSpinner(5);
        Console.WriteLine("");
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name} Activity");
        ShowSpinner(7);
    }

    public void ShowSpinner(int seconds)
    {
        List<string> spinnerChars = new List<string> { "|", "/", "-", "\\" };
        int charIndex = 0;

        // We calculate the end with a date because a frame of the spinner is shown for
        // less than a second, so we can't use a for loop like in ShowCountdown
        DateTime endTime = DateTime.Now.AddSeconds(seconds);

        while (DateTime.Now < endTime)
        {
            string spinnerChar = spinnerChars[charIndex];

            Console.Write(spinnerChar);
            Thread.Sleep(250);
            Console.Write("\b \b");

            charIndex += 1;
            if (charIndex >= spinnerChars.Count)
            {
                charIndex = 0;
            }
        }
    }

    public void ShowCountdown(int seconds)
    {
        for (int s = seconds; s > 0; s--)
        {
            Console.Write(s);
            Thread.Sleep(1000);

            // Each time we have to write a new number, we have to delete the previous one.
            // We do that by going back the lenght needed (backspaceString),
            // overwriting it with spaces (spaceString),
            // and then going back to the start (backspaceString again) to continue writing
            string backspaceString = "";
            string spaceString = "";

            foreach (var _ in s.ToString())
            {
                backspaceString += "\b";
                spaceString += " ";
            }
            Console.Write($"{backspaceString}{spaceString}{backspaceString}");
        }
    }

    public int GetDuration()
    {
        return _duration;
    }
}