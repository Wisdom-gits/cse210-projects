using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a list to store all the videos
        List<Video> videos = new List<Video>();

        // Create Video 1
        Video video1 = new Video("How to Cook Jollof Rice", "Chef Tunde", 600);
        video1.AddComment(new Comment("Amaka", "This looks delicious!"));
        video1.AddComment(new Comment("John", "I tried this recipe and loved it."));
        video1.AddComment(new Comment("Chika", "Can you make a version without meat?"));

        // Create Video 2
        Video video2 = new Video("Learn C# in 10 Minutes", "CodeMaster", 900);
        video2.AddComment(new Comment("Grace", "Very clear explanation!"));
        video2.AddComment(new Comment("Sam", "This really helped me understand classes."));
        video2.AddComment(new Comment("Ella", "Can you do one for LINQ next?"));

        // Create Video 3
        Video video3 = new Video("Top 10 Travel Destinations in Africa", "ExplorerTV", 720);
        video3.AddComment(new Comment("Tomiwa", "I want to visit Kenya now!"));
        video3.AddComment(new Comment("Michael", "Beautiful video editing."));
        video3.AddComment(new Comment("Lola", "Please include Nigeria next time!"));

        // Add videos to list
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        // Display information for each video
        foreach (Video v in videos)
        {
            Console.WriteLine($"Title: {v.Title}");
            Console.WriteLine($"Author: {v.Author}");
            Console.WriteLine($"Length (seconds): {v.Length}");
            Console.WriteLine($"Number of Comments: {v.GetCommentCount()}");
            Console.WriteLine("Comments:");
            foreach (Comment c in v.Comments)
            {
                Console.WriteLine($" - {c.Name}: {c.Text}");
            }
            Console.WriteLine(new string('-', 40));
        }
    }
}
