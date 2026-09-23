using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

public class Video
{
    private string _title;
    private string _author;
    private int _lengthInSeconds;
    private List<Comment> _comment;

    public Video(string title, string author, int lengthInSeconds)
    {
        _title = title;
        _author = author;
        _lengthInSeconds = lengthInSeconds;
        _comment = new List<Comment>();
    }

    public void AddComment(Comment comment)
    {
        _comment.Add(comment);
    }

    public int GetCommentCount()
    {
        return _comment.Count;
    }

    public void DisplayVideoInfo()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_lengthInSeconds} second");
        Console.WriteLine($"Number of Comment: {GetCommentCount()}");
        Console.WriteLine("Comment:");

        foreach (Comment comment in _comment)
        {
            Console.WriteLine($"- {comment.GetCommentName()}: \"{comment.GetText()}\"");
        }
        Console.WriteLine(new string('-', 40));
    }
}
