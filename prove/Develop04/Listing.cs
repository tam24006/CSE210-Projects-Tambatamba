public class ListingActivity : Activity
{
    private Prompts _prompts;
    private List<string> _userInput = new List<string>();
    public ListingActivity(Prompts prompts, string name, string description) : base(name, description)
    {
        _prompts = prompts;
    }
    public void DisplayRandomPrompts()
    {
        Console.WriteLine("List as many response you can to the following prompt: ");
        Console.WriteLine($"---{_prompts.GetRandomPrompt()} ---");
        Console.WriteLine();

    }
    
    public void Run()
    {
        DisplayBeginningPart();

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);

        DisplayRandomPrompts();
        Console.Write("Start listing your responses, press enter after each response: ");
        pauseWithAnimation(5);
        Console.WriteLine();

        while (DateTime.Now < futureTime)
        {
            Console.Write("> ");
            string input = Console.ReadLine();
            if (input.Trim() != "")
            {
                _userInput.Add(input);
            }
        }
        _isRunning = false;

        Console.WriteLine($"You listed {_userInput.Count} items!");
            DisplayEndingPart();
    }
}