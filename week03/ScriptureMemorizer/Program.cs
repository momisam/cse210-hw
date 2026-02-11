using System;

class Program
{
    static void Main(string[] args)
    {
        /*
         * EXCEEDS REQUIREMENTS:
         * - Random word hiding instead of sequential
         * - Scripture remains visible until user quits or all words are hidden
         * - Clear separation of responsibilities using encapsulation
         */

        Reference reference = new Reference("Proverbs", 3, 5, 6);
        Scripture scripture = new Scripture(
            reference,
            "Trust in the Lord with all thine heart and lean not unto thine own understanding"
        );

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress ENTER to hide words or type 'quit' to exit:");

            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            if (scripture.IsCompletelyHidden())
            {
                break;
            }

            scripture.HideRandomWords(3);
        }
    }
}
