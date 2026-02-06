using System;
using System.Collections.Generic;

class Video
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Duration { get; set; } // seconds

    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int duration)
    {
        Title = title;
        Author = author;
        Duration = duration;
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
