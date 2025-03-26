using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Epic Fails Compilation", "JohnDoe", 300);
        video1.AddComment(new Comment("Alice", "This was hilarious!"));
        video1.AddComment(new Comment("Bob", "I can't stop laughing."));
        video1.AddComment(new Comment("Charlie", "Best video ever!"));
        video1.AddComment(new Comment("Dana", "Epic indeed!"));
        videos.Add(video1);

        Video video2 = new Video("Cooking Pasta 101", "ChefMike", 600);
        video2.AddComment(new Comment("Emma", "Great recipe!"));
        video2.AddComment(new Comment("Frank", "Tried it and loved it."));
        video2.AddComment(new Comment("Grace", "Can you make one for pizza?"));
        video2.AddComment(new Comment("Henry", "Yum!"));
        videos.Add(video2);

        Video video3 = new Video("Travel Vlog: Japan", "TravelWithSam", 1200);
        video3.AddComment(new Comment("Ian", "I want to go there!"));
        video3.AddComment(new Comment("Julia", "Beautiful footage."));
        video3.AddComment(new Comment("Kevin", "What camera did you use?"));
        video3.AddComment(new Comment("Laura", "Awesome vlog!"));
        videos.Add(video3);

        Video video4 = new Video("Gaming Highlights", "ProGamer", 900);
        video4.AddComment(new Comment("Mike", "Insane skills!"));
        video4.AddComment(new Comment("Nina", "I wish I was this good."));
        video4.AddComment(new Comment("Oscar", "What game is this?"));
        video4.AddComment(new Comment("Paul", "Epic win!"));
        videos.Add(video4);

        foreach (Video video in videos)
        {
            video.DisplayInfo();
            Console.WriteLine($"Comment Count: {video.GetCommentCount()}");
            video.DisplayComments();
            Console.WriteLine();
        }
    }
}