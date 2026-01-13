using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your grade percentage.");
        int percentage = int.Parse(Console.ReadLine());

        string letter = "";

        if (percentage >= 90)
        {
            letter = "A";
        }
        else if (percentage >= 80)
        {
            letter = "B";
        }
        else if (percentage >= 70)
        {
            letter = "C";
        }
        else if (percentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        string sign = "";
        int LastDigit = percentage % 10;
        if (LastDigit >= 7)
        {
            sign = "+";
        }
        else if (LastDigit < 3)
        {
            sign = "-";
        }
        if (letter == "A" && sign == "+")
        {
            sign = "";
        }
        if (letter == "F")
        {
            sign = "";
        }

        Console.WriteLine($"Your grade is: {letter}{sign}");

        if (percentage >= 70)
        {
            Console.WriteLine("Congratulation! You passed the course.");
        }
        else
        {
            Console.WriteLine("You did not pass this time. Keep trying!");
        }

    }
    

}