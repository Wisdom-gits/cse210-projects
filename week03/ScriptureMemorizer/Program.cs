using System;

class Program
{
    static void Main(string[] args)
    {
        // Example scripture: you can easily change this or load from a file
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        string text = "Trust in the Lord with all thine heart; and lean not unto thine own understanding.";
        Scripture scripture = new Scripture(reference, text);

        while (true)
        {
            scripture.Display();
            Console.WriteLine("Press Enter to hide more words or type 'quit' to end.");
            string input = Console.ReadLine();

            if (input?.ToLower() == "quit")
                break;

            scripture.HideRandomWords(3); // Hide 3 random words each time

            if (scripture.AllWordsHidden())
            {
                scripture.Display();
                Console.WriteLine("All words are now hidden. Program ending...");
                break;
            }
        }
    }
}
