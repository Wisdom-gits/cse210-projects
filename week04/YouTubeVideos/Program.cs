using System;
using System.Collections.Generic;

class Comment
{
    private string _name;
    private string _text;

    public Comment(string name, string text)
    {
        _name = name;
        _text = text;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetText()
    {
        return _text;
    }
}

class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public int GetNumberOfComments()
    {
        return _comments.Count;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length (seconds): {_length}");
        Console.WriteLine($"Number of Comments: {GetNumberOfComments()}");
        Console.WriteLine("Comments:");

        foreach (Comment comment in _comments)
        {
            Console.WriteLine($" - {comment.GetName()}: {comment.GetText()}");
        }

        Console.WriteLine(new string('-', 40));
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create list of videos
        List<Video> videos = new List<Video>();

        // Create first video
        Video video1 = new Video("How to Make Pancakes", "Chef Amaka", 300);
        video1.AddComment(new Comment("John", "I tried this recipe and loved it!"));
        video1.AddComment(new Comment("Grace", "So easy to follow, thanks!"));
        video1.AddComment(new Comment("Liam", "Please make a chocolate version next."));

        // Create second video
        Video video2 = new Video("Learn C# in 10 Minutes", "CodeMaster", 600);
        video2.AddComment(new Comment("Ella", "Super helpful for beginners."));
        video2.AddComment(new Comment("Victor", "Please make one for LINQ!"));
        video2.AddComment(new Comment("Tolu", "I finally understand classes."));

        // Create third video
        Video video3 = new Video("Top 5 Travel Destinations in Africa", "ExplorerTV", 720);
        video3.AddComment(new Comment("Michael", "Kenya is definitely my favorite!"));
        video3.AddComment(new Comment("Sarah", "Can you include Cape Verde next time?"));
        video3.AddComment(new Comment("Chika", "Beautiful places!"));

        // Add videos to the list
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        // Display info for each video
        foreach (Video video in videos)
        {
            video.DisplayInfo();
        }
    }
}
