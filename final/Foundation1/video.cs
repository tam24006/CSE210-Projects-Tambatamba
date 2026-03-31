
using System.Transactions;

public class Video 
{
    public string _title;
    public string _author;
    public int _length;
    public List<_comment> _comments;

    public Video(string title, string author, int length, List<_comment> comments)


    {
        _title = title;
        _author = author;
        _length = length;
        _comments = comments;
    }

    public int CommentNumber()
    {
        return _comments.Count();
    }
    public void DisplayInformation()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_length} seconds");
        Console.WriteLine($"Number of comments: {CommentNumber()}");
        Console.WriteLine("Comments:");
        foreach (_comment comment in _comments)
        {
            comment.DisplayComment();
        }
    }
    public void DisplayComments()
    {
        Console.WriteLine("Comments:");
        foreach (_comment comment in _comments)
        {
            comment.DisplayComment();
        }
    }
}