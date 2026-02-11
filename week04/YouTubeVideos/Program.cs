using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create videos
        Video video1 = new Video("C# Basics Tutorial", "CodeMaster", 600);
        Video video2 = new Video("Object-Oriented Programming Explained", "DevSimplified", 850);
        Video video3 = new Video("Top 10 Coding Tips", "TechWorld", 720);

        // Add comments to video1
        video1.AddComment(new Comment("Alice", "This helped me understand C#!"));
        video1.AddComment(new Comment("Bob", "Great explanation."));
        video1.AddComment(new Comment("Charlie", "Very clear and easy to follow."));

        // Add comments to video2
        video2.AddComment(new Comment("David", "OOP makes more sense now."));
        video2.AddComment(new Comment("Ella", "Loved the real-life examples."));
        video2.AddComment(new Comment("Frank", "Can you make more videos like this?"));

        // Add comments to video3
        video3.AddComment(new Comment("Grace", "Tip #4 was amazing."));
        video3.AddComment(new Comment("Henry", "Thanks for sharing!"));
        video3.AddComment(new Comment("Ivy", "Very informative."));

        // Put videos into a list
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Display information
        foreach (Video video in videos)
        {
            video.DisplayVideoInfo();
            Console.WriteLine("-----------------------------------");
        }
    }
}
