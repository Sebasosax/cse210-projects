using System;

/*
EXCEEDING REQUIREMENTS:
- The program only hides words that are not already hidden.
- Multiple words are hidden during each iteration.
- The Reference class supports both single verses and verse ranges (e.g., Alma 37:6-7).
*/

class Program
{
    static void Main(string[] args)
    {
        // Reference: Alma 37:6-7
        Reference reference = new Reference("Alma", 37, 6, 7);

        // Scripture text in English
        string text = "Now ye may suppose that this is foolishness in me; but behold I say unto you, "
                    + "that by small and simple things are great things brought to pass; and small means "
                    + "in many instances doth confound the wise. "
                    + "And the Lord God doth work by means to bring about his great and eternal purposes; "
                    + "and by very small means the Lord doth confound the wise and bringeth about the salvation of many souls.";

        Scripture scripture = new Scripture(reference, text);

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to continue or type 'quit' to exit:");

            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords(3);

            if (scripture.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                break;
            }
        }
    }
}
