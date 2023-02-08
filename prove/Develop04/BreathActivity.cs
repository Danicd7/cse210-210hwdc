public class BreathActivity : Activity
{
    private string _breathingIn;
    private string _breathingOut;

    /*public BreathActivity(string ActivityName, string startDescription, int activityDuration, string endingDescription, string breathingIn, string breathingOut)
        : base(ActivityName, startDescription, activityDuration, endingDescription)
    {
        _breathingIn = breathingIn;
        _breathingOut = breathingOut;
    }*/
    public BreathActivity(string breathingIn, string breathingOut)
        : base(ActivityName, startDescription, endingDescription, activityDuration)// activityDuration, endingDescription)
    {
        _breathingIn = breathingIn;
        _breathingOut = breathingOut;
    }

    public void runActivity()
    {
        Console.WriteLine(string.Format("Welcome to the ", GetActivityName()));
        Console.WriteLine(string.Format("This activity will help you relax by walking your through breathing in",
        "and out slowly. Clear your mind and focus on your breathing.", DisplayStartMessage()));
        Console.WriteLine();

        
    }
   
}