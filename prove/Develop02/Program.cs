using System.IO;


// I added the following:
// - Checking if the file exists before calling the LoadFromFile method in order to avoid exceptions
// - An informative message if the user input for the action selection is invalid
// - An informative message if there are no entries when the user selects displaying the journal entries
// - I added the characters that separate the data on the files as an attribute on the Journal class,
//   in case it changes in the future

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");

        string input = "";
        Journal journal = new Journal();
        PromptGenerator pGen = new PromptGenerator();

        while (input != "5")
        {
            Console.WriteLine("");
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            input = Console.ReadLine();

            if (input == "1")
            {
                string prompt = pGen.GetRandomPrompt();
                Console.WriteLine(prompt);
                Console.Write("> ");

                string entryText = Console.ReadLine();
                string dateText = DateTime.Now.ToShortDateString();

                Entry newEntry = new Entry();
                newEntry._date = dateText;
                newEntry._prompt = prompt;
                newEntry._entryText = entryText;

                journal.AddEntry(newEntry);
            }
            else if (input == "2")
            {
                journal.Display();
            }
            else if (input == "3")
            {
                Console.Write("What is the filename? ");
                string filename = Console.ReadLine();

                if (File.Exists(filename))
                {
                    journal.LoadFromFile(filename);
                }
                else
                {
                    Console.WriteLine($"The file {filename} does not exist");
                }
            }
            else if (input == "4")
            {
                Console.Write("What is the filename? ");
                string filename = Console.ReadLine();

                journal.SaveToFile(filename);
            }
            else if (input == "5")
            {
                break;
            }
            else
            {
                Console.WriteLine($"'{input}' is not a valid input");
            }
        }
    }
}