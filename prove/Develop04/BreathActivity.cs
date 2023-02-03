public class BreathActivity : Activity
{
    private string _breathingIn;
    private string _breathingOut;

    /*public BreathActivity(string ActivityName, string startDescription, int activityDuration, string endingDescription, string breathingIn, string breathingOut)
        : base(ActivityName, startDescription, activityDuration, endingDescription)
    {
        _breathingIn = breathingIn;
        _breathingOut = breathingOut;
    }*/`
    public BreathActivity(string activityName, string startDescription)
    : base(activityName, startDescription, 30, "")// activityDuration, endingDescription)
    {

    }

    public void runActivity()
    {
        Console.WriteLine(string.Format("Welcome to the {0}", GetActivityName()));
        Console.WriteLine(DisplayStartMessage());
        
    }

    
   
}