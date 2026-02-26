class Word
{
    private string _word;
    private bool _isHidden;

    public Word(string word)
    {
        _word = word;
        _isHidden = false;
    }

    public string GetWord()
    {
        return _word;
    }
    public bool GetIsHidden()
    {
        return _isHidden;
    }
    public void HideWord()
    {
        string w = "";
        for (int i = 0; i < _word.Length; i++)
        {
            w += "_";
        }
        _word = w;
        _isHidden = true;
    }

}