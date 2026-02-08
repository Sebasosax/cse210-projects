using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people you have helped recently?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity()
        : base("Listing", "This activity will help you list positive things in your life.")
    { }

    public override void Run()
    {
        Start();

        Random rand = new Random();
        Console.WriteLine($"\n{_prompts[rand.Next(_prompts.Count)]}");
        Console.WriteLine("You may begin in:");
        ShowCountdown(5);

        List<string> items = new List<string>();
        DateTime end = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < end)
        {
            Console.Write("> ");
            items.Add(Console.ReadLine());
        }

        Console.WriteLine($"\nYou listed {items.Count} items!");
        End();
    }
}
