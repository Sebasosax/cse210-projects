using System;
using System.Collections.Generic;

namespace ExerciseTracking
{
    class Program
    {
        static void Main(string[] args)
        {
            var activities = new List<Activity>
            {
                new Running("03 Nov 2022", 30, 4.8),
                new Cycling("03 Nov 2022", 45, 20),
                new Swimming("03 Nov 2022", 60, 30)
            };

            foreach (var activity in activities)
            {
                Console.WriteLine(activity.GetSummary());
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
