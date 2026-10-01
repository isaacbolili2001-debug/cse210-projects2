using System;
using System.Threading;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base()
    {
        _name = "Breathing Activity";
        _description = "This activity will help you relax by walking your breathing in and out slowly. Clear your mind and focus on your breathing.";

    }
    public void Run()
    {
        DisplayStartingMessage();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine("Breathe in...");
            ShowCountdown(4);
            Console.WriteLine("\nBreathe out...");
            ShowCountdown(6);
            Console.WriteLine();
        }
        DisplayEndingMessage();
    }

}