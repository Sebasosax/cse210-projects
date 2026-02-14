 // EXCEEDS CORE REQUIREMENTS:
// Added a leveling system. The player levels up every 1000 points.
// This adds extra gamification beyond the core requirements.
using System;

class Program
{
    static void Main(string[] args)
    {


        GoalManager manager = new GoalManager();
        manager.Start();
    }
}
