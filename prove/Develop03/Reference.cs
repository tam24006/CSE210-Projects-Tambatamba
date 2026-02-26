using System.Net.NetworkInformation;
using System.Reflection.Metadata.Ecma335;

class Reference
{
    private string _book;
    private string _chapter;
    private int _startVerse;
    private int _endVerse;

    public Reference(string book, string chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }

    public string DisplayReference()
    {
        if (_startVerse == _endVerse)
        {
            return $"{_book} {_chapter}:{_startVerse}";
        }
        else if (_startVerse > _endVerse)
        {
            return "Invalid Input";
        }

        else
        {
            return $"{_book} {_chapter}:{_startVerse}-{_endVerse}";
        }
    }

    public string GetBoook()
    {
        return _book;
    }
    public string GetChapter()
    {
        return _chapter;
    }
    public int GetStartVerse()
    {
        return _startVerse;
    }
    public int GetEndVerse()
    {
        return _endVerse;
    }

    public void setbook(string book)
    {
        _book = book;
    }
    public void setchapter(string chapter)
    {
        _chapter = chapter;
    }
    public void setstartverse(int startVerse)
    {
        _startVerse = startVerse;
    }
    public void setendverse(int endVerse)
    {
        _endVerse = endVerse;
    }


}