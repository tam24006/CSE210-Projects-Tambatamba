using System.Globalization;

public class ReflectionExercise : Activity
{
    private Prompts _prompts;
    private List<string> _questions;
    private new int _duration;
    private new bool _isRunning;

    public ReflectionExercise(Prompts prompts, List<string> questions, string name, string welcome):
        base(name, welcome)
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
        PauseWithAnimation(10);
        Console.WriteLine();
    }

    private void PauseWithAnimation(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            System.Threading.Thread.Sleep(1000); 
        }
        Console.WriteLine();
    }

    public void Run()
    {
        
        DateTime futureTime = DateTime.Now.AddSeconds(_duration);

        int i = 0; 
        while (DateTime.Now < futureTime)
        {
            DisplayQuestion(i);
            i = (i + 1) % _questions.Count;
        }
        _isRunning = false;
        DisplayEndingPart();
    }
}
