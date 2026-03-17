public class Prompts
{
    private List<string> _prompts = new List<string>();
    private Random _random = new Random();
    private List<string> _usedPrompts = new List<string>();

    public Prompts(List<string> prompts)
    {
        _prompts = prompts;
    }
    public List<string> GetPrompts()
    {
        return _prompts;
    }
    public string GetRandomPrompt()
    {
        if (_usedPrompts.Count == _prompts.Count)
        {
            _usedPrompts.Clear();
        }

        string prompt;
        do
        {
            int index = _random.Next(_prompts.Count);
            prompt = _prompts[index];
        } while (_usedPrompts.Contains(prompt));

        _usedPrompts.Add(prompt);
        return prompt;
    }
}