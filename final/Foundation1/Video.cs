using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Transactions;
using System.Xml;

public class Video
{
private string _title;
private string _author;
private int _duration;
private List<Comment> _comments;

public Video(string title, string author, int duration)
{
    _title = title;
    _author = author;
    _duration = duration;
    _comments = new List<Comment>();
}

public void AddComment(Comment comment)
{
    _comments.Add(comment);
}

public void AddCommentList(List<Comment> comments)
{
    _comments.AddRange(comments);
}

public int GetCommentCount()
{
    return _comments.Count();
}

public void DisplayInfo()
{
    Console.WriteLine($"Title: {_title}\nAuthor: {_author}\nLength: {_duration} seconds");
}

public void DisplayComments()
{
    foreach (Comment comment in _comments)
    {
        comment.Display();
    }
}

}