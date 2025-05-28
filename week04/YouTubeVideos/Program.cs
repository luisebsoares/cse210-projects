using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Exploring the Mountains", "Luis's Adventures", 480, 162520, 17420, 98);
        video1.AddComment(new Comment("Haley", "This was so peaceful to watch!"));
        video1.AddComment(new Comment("Jake", "Great drone shots."));
        video1.AddComment(new Comment("Maya", "Loved the scenery!"));

        Video video2 = new Video("C# Beginner Tutorial", "Code Academy", 930, 52068, 268, 11);
        video2.AddComment(new Comment("John", "This really helped me understand classes."));
        video2.AddComment(new Comment("Sara", "Clear and simple explanation."));
        video2.AddComment(new Comment("DevDude", "Subscribed!"));

        Video video3 = new Video("30-Minute HIIT Workout", "FitnessPro", 1830, 89065, 6809, 47);
        video3.AddComment(new Comment("Alex", "I died at minute 20 😂"));
        video3.AddComment(new Comment("Jess", "Such a good burn, thanks!"));
        video3.AddComment(new Comment("CoachMike", "Keep pushing!"));

        Video video4 = new Video("Top 10 Movies of 2024", "MovieReviewHQ", 600, 31004, 1670, 108);
        video4.AddComment(new Comment("Tony", "Can’t believe #1 made the list."));
        video4.AddComment(new Comment("Emily", "I disagree with #5."));
        video4.AddComment(new Comment("Sam", "Loved this video!"));

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        videos.Add(video4);

        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.LengthInSeconds} seconds");
            Console.WriteLine($"Views: {video.Views}");
            Console.WriteLine($"Likes: {video.Likes}");
            Console.WriteLine($"Dislikes: {video.Dislikes}");
            Console.WriteLine($"Comments: {video.GetNumberOfComments()}"); ;

            foreach (var comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.CommenterName}: {comment.Text}");
            }

            Console.WriteLine();
        }
    }
}