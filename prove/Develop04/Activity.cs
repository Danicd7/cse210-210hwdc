public class Activity
{
    private string _name;
    private string _startDescription;
    private string _endingDescription;
    private int _activityDuration;

    public Activity(string ActivityName, string startDescription, int activityDuration, string endingDescription)
    {
        _name = ActivityName;
        _startDescription = startDescription;
        _activityDuration = activityDuration; 
        _endingDescription = endingDescription;
    }


    public string GetActivityName()
    {
        return _name;
    }
    public string DisplayStartMessage()
    {
        return _startDescription;
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
        switch (_activityDuration 4 %)
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

}