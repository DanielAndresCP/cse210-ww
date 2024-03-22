// In order to exceed the requirements I added:
//  - Some changes to the way the ListingActivity class handles the answers of the users:
//      - It now stores a list of the user answers, instead of just a count of them. This can
//        help in case future changes in the code require having the text of the user answers.
//      - I added a method to get the count of user answers.
//      - I now have two different methods for getting and displaying a prompt,
//        which is different from the instructions (the instructions define just one method).
//      - The instructions say that there is a GetListFromUser method that returns a List<string>,
//        I suppose that the contents of this method is a loop to ask the user for their answers,
//        and the with the return value we update the count attribute to then use it. Instead of this,
//        I have a method that asks for a single answer and adds it to the answers attribute,
//        and I let the Run method handle the loop.
//  - Changes to the DiplayPrompt and DisplayQuestion methods, they now take the prompt and question as a parameter
//  - A method in the Activity class to get the duration. I did this instead as declaring it as private because
//    declaring it as private makes it possible for the attribute to be changed after the duration has been decided
//    (which could cause problems)


using System;

class Program
{
    static void Main(string[] args)
    {
        string answer = "";
        while (answer != "4")
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");
            answer = Console.ReadLine();

            if (answer == "1")
            {
                BreathingActivity bActivity = new BreathingActivity();
                Console.Clear();
                bActivity.Run();
            }
            else if (answer == "2")
            {
                ReflectingActivity rActivity = new ReflectingActivity();
                Console.Clear();
                rActivity.Run();
            }
            else if (answer == "3")
            {
                ListingActivity lActivity = new ListingActivity();
                Console.Clear();
                lActivity.Run();
            }
        }
    }
}