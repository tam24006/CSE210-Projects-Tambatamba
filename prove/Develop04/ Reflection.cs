using System.Globalization;

public class ReflectionActivity : Activity
{
    private Prompts _prompts;
    private List<string> _questions;
    public ReflectionActivity(Prompts prompts, List<string> questions, string name, string welcome)
        : base(name, welcome)
    {
        _prompts = prompts; 
        _questions = questions;
    }
    public void DisplayRandomprompts()
    {
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        Console.WriteLine($"---{_prompts.GetRandomPrompt()} ---");
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue.");

    }
    public void DisplayQuestion(int index)
    {
        Console.Write($"{_questions[index]}");
        pauseWithAnimation(10);
        Console.WriteLine();
    }
    public void Run()
    {
        DisplayBeginningPart();
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);

        DisplayRandomprompts();
        string answer = Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("you may start in :");
        pauseWithCountdown(5);
        Console.WriteLine();

        int i = 0;
        while (DateTime.Now < futureTime)
        {
            DisplayQuestion(i);
            i = (i + 1) % _questions.Count;
            if (i >= _questions.Count)
            {
                i = 0;
            }
        }
        _isRunning = false;
        DisplayEndingPart();
    }

}