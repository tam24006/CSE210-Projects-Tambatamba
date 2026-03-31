
public class Program
{
    public static void Main(string[] args)
    {
        List<_comment> comments1 = new List<_comment>();
        comments1.Add(new _comment("Great video!", "Alice"));
        comments1.Add(new _comment("Very informative.", "Bob"));
        comments1.Add(new _comment("I learned a lot.", "Charlie"));

        Video video1 = new Video("C# Programming", "John Doe", 300, comments1);
        video1.DisplayInformation();

        List<_comment> comments2 = new List<_comment>();
        comments2.Add(new _comment("Awesome tutorial!", "Dave"));
        comments2.Add(new _comment("Thanks for sharing.", "Eve"));

        Video video2 = new Video("Python Programming", "Jane Smith", 450, comments2);
        video2.DisplayInformation();
    }
}