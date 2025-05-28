using System;

public class Video
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int LengthInSeconds { get; set; }
    public int Views { get; set; }
    public int Likes { get; set; }
    public int Dislikes { get; set; }

    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int lengthInSeconds, int views, int likes, int dislikes)
    {
        Title = title;
        Author = author;
        LengthInSeconds = lengthInSeconds;
        Views = views;
        Likes = likes;
        Dislikes = dislikes;
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public int GetNumberOfComments()
    {
        return _comments.Count;
    }

    public List<Comment> GetComments()
    {
        return _comments;
    }
}