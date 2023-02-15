using System;
public class Activity
{
    private string _activityName;
    private string _description;
    private string _startDescription;
    private string _endingDescription;
    private int _activityCounter;
    private int _activityDuration;

    public Activity(string activityName, string description, string startDescription, string endingDescription, int activityCounter, int activityDuration)
    {
        _activityName = activityName;
        _description = description;
        _startDescription = startDescription;
        _endingDescription = endingDescription;
        _activityCounter = activityCounter;
        _activityDuration = activityDuration; 
        
    }


    public string GetActivityName(string activityName, string description)
    {
        return _activityName;
    }
 
       
    public void DisplayStartMessage(string activityName, string description)
    {
        Console.WriteLine($"This activity is the {_activityName}. {_startDescription }");
        Console.WriteLine($"How many seconds would you like to do the {_activityName} for?");
        
    }

    public string DisplayEndingMessage()
    {
        return _endingDescription;
    }

    public void Timer()
    {
        for (var i = 0; i < 10; i++)
        {
            PauseSpining();
            Thread.Sleep(350);
        }
    }

    public void PauseSpining()
    {
        _activityDuration++;
        switch (_activityDuration % 4)
        {
            case 0:
                Console.Write("/");
                break;
            case 1:
                Console.Write("-");
                break;  
            case 2:
                Console.Write("\\");
                break;
            case 3:
                Console.Write("|");
                break;  
        }
        Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
    }

    public void CountDown(int activityDuration)
    {
        for (int i = 1; i <= activityDuration; i++)
        {
            Console.Write(string.Format("You may begin in {0}", i));
            Console.SetCursorPosition(0, Console.CursorTop);
            Thread.Sleep(1000);
        }
    }

}