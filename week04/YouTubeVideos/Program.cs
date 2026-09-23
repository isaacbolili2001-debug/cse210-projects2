using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");

        List<Video> videos = new List<Video>();

        Video video1 = new Video("C# Programming for Beginners", "CodeAcademy", 600);
        video1.AddComment(new Comment("Alice", "This tutorial saved my life! Very clear explanations."));
        video1.AddComment(new Comment("Bob", "Can you make a follow-up video on classes?"));
        video1.AddComment(new Comment("Charlie", "Great pacing. Thanks for sharing!"));
        videos.Add(video1);

        Video video2 = new Video("Top 10 Product Placements in Tech", "MediaInsights", 450);
        video2.AddComment(new Comment("Dave", "I totally missed number 4! Good catch."));
        video2.AddComment(new Comment("Eve", "Interesting analysis on consumer awareness."));
        video2.AddComment(new Comment("Frank", "Great editing and sound design too."));
        videos.Add(video2);

        Video video3 = new Video("Understanding Abstraction in OOP", "TechGuru", 820);
        video3.AddComment(new Comment("Grace", "Finally I understand abstraction. Thank you!"));
        video3.AddComment(new Comment("Heidi", "Clear and concise. Subscribed."));
        video3.AddComment(new Comment("Ivan", "Could you provide code examples on GitHub?"));
        videos.Add(video3);

        Video video4 = new Video("Building Scalable Software Architecture", "DevOps Weekly", 1200);
        video4.AddComment(new Comment("Judy", "Masterclass level content right here."));
        video4.AddComment(new Comment("Mallory", "A bit fast-paced, but worth re-watching."));
        video4.AddComment(new Comment("Niaj", "Loved the breakdown on dependency injection."));
        videos.Add(video4);

        foreach (Video video in videos)
        {
            video.DisplayVideoInfo();
        }
    }
}