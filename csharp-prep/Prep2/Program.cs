using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        String answear = Console.ReadLine();
        int percent = int.Parse(answear);

        String letter = "";

        if (percent >= 90)
        {
            letter = "A";
        }
        else if (percent >= 80)
        {
            letter = "C";
        }
        else if (percent >= 60)
        {
        letter = "D";
        }
        else 
        {
            letter = "F";
        }

        Console.WriteLine($"your grade is {letter}");

        if (percent >= 70)
        {
            Console.WriteLine("you passed!");
        }
        else 
        {
        Console.WriteLine("Better luck next time!");
        }
    }
}