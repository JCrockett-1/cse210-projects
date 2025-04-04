using System;

class Program
{
    static void Main(string[] args)
    {
        List <Video> videos = new List <Video>();

        Video video1 = new Video("Tutorial Part 1","TestAuthor1",180);
        List <Comment> comments1 = new List <Comment>();
        comments1.Add(new Comment("Commenter1","This is a comment."));
        comments1.Add(new Comment("Commenter2","This is a helpful video!"));
        comments1.Add(new Comment("Commenter3","Thanks for making this video!"));
        comments1.Add(new Comment("Commenter4","Great video!"));
        video1.AddCommentList(comments1);
        videos.Add(video1);

        Video video2 = new Video("Tutorial Part 2","TestAuthor1",2000);
        List <Comment> comments2 = new List <Comment>();
        comments2.Add(new Comment("Commenter5","Loved the video!"));
        comments2.Add(new Comment("Commenter6","Thanks for the great video."));
        comments2.Add(new Comment("Commenter7","Very helpful, thumbs up for you!"));
        comments2.Add(new Comment("Commenter8","Awesome stuff."));
        video2.AddCommentList(comments2);
        videos.Add(video2);

        Video video3 = new Video("Tutorial Part 3","TestAuthor1",320);
        List <Comment> comments3 = new List <Comment>();
        comments3.Add(new Comment("Commenter9","I didn't like the video."));
        comments3.Add(new Comment("Commenter10","Part 4 soon???"));
        comments3.Add(new Comment("Commenter11","What a great day!"));
        comments3.Add(new Comment("Commenter12","Who else likes oranges?"));
        video3.AddCommentList(comments3);
        videos.Add(video3);

        Video video4 = new Video("Tutorial Part 4","TestAuthor1",60);
        List <Comment> comments4 = new List <Comment>();
        comments4.Add(new Comment("Commenter13","Finally part 4!"));
        comments4.Add(new Comment("Commenter14","most helpful video award??"));
        comments4.Add(new Comment("Commenter15","I'm havign a good day :)"));
        comments4.Add(new Comment("Commenter16","I'm having a better day now thanks do this video!"));
        video4.AddCommentList(comments4);
        videos.Add(video4);

        foreach (Video video in videos)
        {
            video.DisplayInfo();
            Console.WriteLine();
        }


    }
}