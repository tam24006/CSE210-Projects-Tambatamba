public class Activity
{
    protected string _name;
    protected int _duration;
    protected string _description;
    protected bool _isRunning;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void DisplayBeginningPart()
    {
        Console.WriteLine($"Welcome to the {_name} Activity.");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
        Console.Clear();
    }

    public void DisplayEndingPart()
    {
        Console.WriteLine();
        Console.WriteLine($"you have completed the {_name} Activity for {_duration} seconds.");
    }

    public void pauseWithAnimation(int seconds) 
    {
        List<string> animatation = new List<string>() { "|", "/", "-", "\\" };
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(animatation[i % 4]);
            Thread.Sleep(250);
            Console.Write("\b \b");
        }
    }

    public void pauseWithCountdown(int seconds) 
    {
        for (int i = seconds; i >= 0; i--) 
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}