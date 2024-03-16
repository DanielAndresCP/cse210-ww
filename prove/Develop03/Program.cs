// To exceed the requirements, I added:
// - checking if the word is already hidden, and if it is, selecting another one to hide
// - a list of scriptures to randomly choose from

using System;

class Program
{
    static void Main(string[] args)
    {
        List<Scripture> scriptures = new List<Scripture>{
            new Scripture(new Reference("1 Nephi",3,7), "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them."),
            new Scripture(new Reference("James",1,5,6), "If any of you lack wisdom, let him ask of God, that giveth to all men liberally, and upbraideth not; and it shall be given him. But let him ask in faith, nothing wavering. For he that wavereth is like a wave of the sea driven with the wind and tossed."),
            new Scripture(new Reference("Doctrine and Covenants",6,36), "Look unto me in every thought; doubt not, fear not."),
            new Scripture(new Reference("Proverbs",3,5,6), "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths."),
            new Scripture(new Reference("Doctrine and Covenants",88,188), "And as all have not faith, seek ye diligently and teach one another words of wisdom; yea, seek ye out of the best books words of wisdom; seek learning, even by study and also by faith.")
        };


        string answer = "";
        int hideStep = 5;

        Random rand = new Random();
        int randNum = rand.Next(0, scriptures.Count);

        Scripture scripture = scriptures[randNum];

        while (answer != "quit")
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();

            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            answer = Console.ReadLine();

            if (!scripture.IsCompletelyHidden())
            {
                scripture.HideRandomWords(hideStep);
            }
            else
            {
                break;
            }
        }
    }
}