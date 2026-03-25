using System.Transactions;

public class _comment
{
    public string _text;
    public string _comments;
    public _comment(string text, string comments)
    {
        _text = text;
        _comments = comments;
    }

    public void DisplayComment()
    {
        Console.WriteLine(${ _text} by { _comments});
        
    }

}

