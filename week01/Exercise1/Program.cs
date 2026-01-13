using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise1 Project.");

        Console.WriteLine("");

        Console.WriteLine("What is your first name?");
        string name = Console.ReadLine();

        Console.WriteLine("");
        
        Console.WriteLine("What is your last name?");
        string lname = Console.ReadLine();

        Console.WriteLine("");
        Console.WriteLine($"Your  name is {lname}, {name} {lname} ");
    }
}