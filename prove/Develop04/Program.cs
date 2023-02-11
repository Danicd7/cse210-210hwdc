using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop05 World!");

        /*BreathActivity breathActivity = new BreathActivity("Breath Activity", "¨Start Description", 30, 
            "Ënding Description", "¨Breathing In", "¨Breathing Out");*/

        BreathActivity breath = new BreathActivity("Breathing Activity", "Start Description");
        breath.runActivity();
    }

    
}


