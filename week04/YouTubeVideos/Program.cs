using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Intro to C#", "John Smith", 300);
        video1.AddComment(new Comment("Alice", "Great intro!"));
        video1.AddComment(new Comment("Bob", "Very helpful."));
        video1.AddComment(new Comment("Charlie", "Thanks for sharing!"));
        videos.Add(video1);

        Video video2 = new Video("OOP Concepts", "Jane Doe", 420);
        video2.AddComment(new Comment("David", "Loved the explanation."));
        video2.AddComment(new Comment("Emma", "Could you make more?"));
        video2.AddComment(new Comment("Frank", "OOP finally makes sense."));
        videos.Add(video2);

        Video video3 = new Video("LINQ Tutorial", "Tom Lee", 360);
        video3.AddComment(new Comment("Grace", "Super clear tutorial."));
        video3.AddComment(new Comment("Hannah", "You saved my assignment."));
        video3.AddComment(new Comment("Ian", "Brilliant!"));
        videos.Add(video3);

        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");

            foreach (var comment in video.GetComments())
            {
                Console.WriteLine($" - {comment.Name}: {comment.Text}");
            }
            Console.WriteLine();
        }
    }
}
