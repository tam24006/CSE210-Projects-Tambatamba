using System;

class Program
{
    static void Main(string[] args)
    {
        bool running = true;
        List<string> reflectionPrompts = new List<string>()
        {
            "Think of a time when you felt happy for someone else.",
            "Think of a time when you did something really fun and exciting.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless.",
            "Think of a time when you overcame a difficult challenge.",
            "Think of a time when you made a positive impact on someone else's life.",
            "Think of a time when you achieved a personal goal or milestone.",
        };

        // Correct the variable name and ensure it matches the list defined above
        // Ensure the Prompts class constructor matches the expected argument type
        Prompts reflectionPromptsObject = new Prompts(reflectionPrompts);

        List<string> reflectionQuestions = new List<string>()
        {
            "what did you learn about yourself from this experience?",
            "what did you learn about others from this experience?",
            "what did you learn about the world from this experience?",
            "how can you apply what you learned from this experience to your life?",
            "what are you grateful for from this experience?",
            "how did this experience make you feel?",
            "what would you do differently if you could relive this experience?",
            "what are some positive outcomes that came from this experience?"
        };

        List<string> listingPrompts = new List<string>()
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
        Prompts listingPromptsObject = new Prompts(listingPrompts);
        BreathingAcivity b1 = new BreathingAcivity(4, 6, "Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
        ReflectionActivity r1 = new ReflectionActivity(reflectionPrompts, reflectionQuestions, "Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        ListingActivity l1 = new ListingActivity(listingPrompts, "Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");

        while (running)
        {
            Console.Write("Please select one of the following choices: \n1. Breathing Activity\n2. Reflection Activity\n3. Listing Activity\n4. Exit\n");
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                b1.Run();
            }
            else if (choice == "2")
            {
                r1.Run();
            }
            else if (choice == "3")
            {
                l1.Run();
            }
             else if (choice == "4")
            {
                running = false;
            }
             else
            {
                Console.WriteLine("Invalid choice. Please try again.\n");
            }
        }

    }
}