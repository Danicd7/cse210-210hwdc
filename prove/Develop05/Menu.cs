using System;
public class Menu
{
    private int DisplayMenu()
    {
        Console.WriteLine($"You have {RecordKeeping.DisplayScore()} points");
        Console.WriteLine(@"Menu Options:
        1.Create New Goal
        2.List Goals
        3.Save Goals
        4.Load Goals
        5.Record Event
        6.Quit");
        Console.WriteLine("Select a choice from the menu:");

    }
    
    private int DisplayGoalMenu()
    {//if choose 1 then...
        Console.WriteLine(@"The types of Goals are:
        1.Simple Goal
        2.Eternal Goal
        3.Checklist Goal");
        Console.Write("Which type of goal would you like to create?");
    
    //Program....string
    
        Console.Write("What is the name of your goal?");
        Console.Write("");
    }
}
