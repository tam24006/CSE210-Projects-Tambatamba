using System.Diagnostics;

public class BreathingAcivity : Activity
{
    private int _breathIn;
    private int _breathOut;
    public BreathingAcivity(int breathIn, int breathOut, string name, string description)
        : base(name, description)
    {
        _breathIn = breathIn;
        _breathOut = breathOut;
    }

    public void DisplayInstructions()
    {
        Console.WriteLine();
        Console.Write("Get ready to begin...");
        Console.WriteLine();
        Console.Write("Breath in...");
        pauseWithAnimation(_breathIn);
        Console.WriteLine();
        Console.Write("Breath out...");
        pauseWithAnimation(_breathOut);
        Console.WriteLine();
    }

    public void Run()
    {
        DisplayBeginningPart();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            DisplayInstructions();
        }
        _isRunning = false;
        DisplayEndingPart();
    }
}