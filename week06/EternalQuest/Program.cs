using System;
using System.Collections.Generic;

namespace EternalQuest
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! This is the EternalQuest Project.");

            GoalManager goalManager = new GoalManager();
            goalManager.Start();


        }

    }
}