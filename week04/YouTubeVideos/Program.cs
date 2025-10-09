using System;
using System.Collections.Generic;

public abstract class Video
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int LengthInSeconds { get; set; }
    public List<string> Comments { get; set; } = new List<string>();
    
    public abstract string GetCategoryDescription();

    public void DisplayVideoDetails()
    {
        Console.WriteLine("===========================================");
        Console.WriteLine($"🎬 Title: {Title}");
        Console.WriteLine($"👤 Author: {Author}");
        Console.WriteLine($"⏱️ Length: {LengthInSeconds} seconds");
        Console.WriteLine($"💬 Comments: {Comments.Count}");
        Console.WriteLine($"📚 Category: {GetCategoryDescription()}");
        Console.WriteLine("-------------------------------------------");
        Console.WriteLine("Comments:");
        foreach (string comment in Comments)
        {
            Console.WriteLine($"   - {comment}");
        }
        Console.WriteLine("===========================================\n");
    }
}

public class EducationalVideo : Video
{
    public override string GetCategoryDescription()
    {
        return "Educational - Designed to teach concepts or skills.";
    }
}

public class EntertainmentVideo : Video
{
    public override string GetCategoryDescription()
    {
        return "Entertainment - Created to amuse and engage the audience.";
    }
}

public class MusicVideo : Video
{
    public override string GetCategoryDescription()
    {
        return "Music - Focused on performance, sound, and rhythm.";
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("===== ABSTRACTION DEMONSTRATION WITH YOUTUBE VIDEOS =====\n");

        List<Video> videos = new List<Video>();

        EducationalVideo eduVideo = new EducationalVideo
        {
            Title = "Learn C# Basics in 15 Minutes",
            Author = "CodeSmart Academy",
            LengthInSeconds = 900
        };
        eduVideo.Comments.Add("This tutorial was so clear!");
        eduVideo.Comments.Add("I finally understand loops!");
        videos.Add(eduVideo);

        EntertainmentVideo funVideo = new EntertainmentVideo
        {
            Title = "Top 10 Funny Animal Moments",
            Author = "WildLaughs",
            LengthInSeconds = 600
        };
        funVideo.Comments.Add("That monkey clip cracked me up!");
        funVideo.Comments.Add("I can’t stop laughing 😂");
        videos.Add(funVideo);

        MusicVideo musicVideo = new MusicVideo
        {
            Title = "In the Light - Official Music Video",
            Author = "SoulBeats",
            LengthInSeconds = 240
        };
        musicVideo.Comments.Add("This song gives me chills.");
        musicVideo.Comments.Add("Amazing vocals and visuals!");
        videos.Add(musicVideo);

        foreach (Video video in videos)
        {
            video.DisplayVideoDetails();
        }

        Console.WriteLine("✅ End of Program — Abstraction Demonstrated Successfully!");
    }
}
