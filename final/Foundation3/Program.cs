using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "Anytown", "CA", "12345");
        Address address2 = new Address("456 Elm St", "Othertown", "NY", "67890");
        Address address3 = new Address("789 Oak St", "Sometown", "TX", "54321");

        Lecture lecture1 = new Lecture("Tech Talk", "A talk about the latest in tech.", "2024-10-01", address1, "10:00 AM", "Lecture", "Dr. Smith", 100);
        Reception reception1 = new Reception("winter gala", "A formal event to celebrate the winter season.", "April 26, 2026", address2, "7:00 PM", "event@gmail.com", "rsvp@wintergala.com");

        Outdoor Outdoor1 = new Outdoor("Picnic in the Park", "A fun day outdoors with food and games.", "2024-08-15", address3, "12:00 PM", "Outdoor", "Sunny with a high of 75°F");

        Console.WriteLine("This are our available events:");
        Console.WriteLine("\n *** Standard Details ***");
        Console.WriteLine(lecture1.StandardDetails());
        Console.WriteLine("-------------------------");
        Console.WriteLine(reception1.StandardDetails());
        Console.WriteLine("-------------------------");
        Console.WriteLine(Outdoor1.StandardDetails());
        Console.WriteLine("\n *** Full Details ***");
        Console.WriteLine(lecture1.FullDetails());
        Console.WriteLine("-------------------------");

        Console.WriteLine(reception1.FullDetails());
        Console.WriteLine("-------------------------");
        Console.WriteLine(Outdoor1.FullDetails());

        Console.WriteLine("\n *** Short Description ***");
        Console.WriteLine(lecture1.ShortDescription());
        Console.WriteLine("-------------------------");

        Console.WriteLine(reception1.ShortDescription());
        Console.WriteLine("-------------------------");
        Console.WriteLine(Outdoor1.ShortDescription());
        
        
    }
}