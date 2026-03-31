using System;

class Program
{
    static void Main(string[] args)
    {
        Running r1 = new Running("06/01/2024", 30, 5);
        Cycling c1 = new Cycling("06/02/2024", 60, 20);
        Swimming s1 = new Swimming("06/03/2024", 45, 40);

        List<Activity> activities = new List<Activity>() { r1, c1, s1 };

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}