/* using System;

public class Program
{
    public static void Main()
    {
        /* Console.WriteLine("Hello World!");

        Counter myCounter = new Counter();
        myCounter.Run(); */

        Message m1 = new Message();
        m1._message = "Send help!";
        m1._priority = 1;
        Console.WriteLine(m1.GetMessage());

        Message m2 = new Message();
        m2._message = "Please pick up some carrots at the store.";
        m2._priority = 1;
        Console.WriteLine(m2.GetMessage());


        /* Console.WriteLine("Mad Libs!");
        Console.WriteLine();

        Console.Write("Enter a verb. ");
        string verb = Console.ReadLine();

        Console.Write("Enter a noun. ");
        string noun = Console.ReadLine();

        Console.Write("Enter an adjective. ");
        string adjective = Console.ReadLine();
        Console.WriteLine();

        Console.WriteLine($"Every morning, I like to {verb} before starting my day.");
        Console.WriteLine($"On the table I found a mysterious {noun} covered in dust.");
        Console.WriteLine($"It was a surprisingly {adjective} experience for everyone involved."); */

