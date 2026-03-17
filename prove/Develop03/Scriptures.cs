using System.Diagnostics.Contracts;

class Scriptures
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();
    Random _random = new Random();

    public Scriptures(Reference reference, string scripture)
    {
        _reference = reference;
        string[] words = scripture.Split(' ');
        foreach (string word in words)
        {
            Word w = new Word(word);
            _words.Add(w);
        }
    }

    public void DisplayScripture()
    {
        string scripture = _reference.DisplayReference() + " ";
        foreach (Word word in _words)
        {
            scripture += word.GetWord() + " ";
        }
        Console.WriteLine($"{_reference.DisplayReference()} {scripture}");
    }

    public void HideRandomWord()
    { 
        for (int j = 0; j < 3; j++) 
        {
            int i = _random.Next(_words.Count);
            Word randomWord = _words[i];
            if (!randomWord.GetIsHidden())
            {
                randomWord.HideWord();
            }
        }
    }

    public bool AllWordsHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.GetIsHidden())
            {
                return false;
            }
        }
        return true;
    }
}
