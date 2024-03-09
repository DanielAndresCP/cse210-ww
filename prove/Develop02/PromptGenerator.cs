public class PromptGenerator
{
    public List<string> _prompts = new List<string> {
        "If I had one thing I could do over today, what would it be?",
        "What was the best part of my day?",
        "Who was the most interesting person I interacted with today?",
        "What am I grateful for today?",
        "What did I do today that I am proud of?",
        "What is the current problem or challenge I am facing?",
        "What did I learn today?",
        "How did I show gratitude today?",
        "What is one fun thing I want to do this week?",
        "Is there someone that has been on my mind lately? If so, why?",
    };

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int i = random.Next(0, _prompts.Count);
        return _prompts[i];
    }
}