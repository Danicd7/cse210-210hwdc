public class BreathActivity : Activity
{
    private string _breathingIn = "";
    private string _breathingOut = "";

    /*public BreathActivity(string ActivityName, string startDescription, int activityDuration, string endingDescription, string breathingIn, string breathingOut)
        : base(ActivityName, startDescription, activityDuration, endingDescription)
    {
        _breathingIn = breathingIn;
        _breathingOut = breathingOut;
    }*/
    public void RunBreathActivity(string breathingIn, string breathingOut) : base (activityName, startDescription)// activityDuration, endingDescription
    {
        Console.WriteLine("Breathing Activity");
        Activity.startDescription("Breathing", "This activity will help you relax by walking through breathing in and out");
       
    }

     
    public void BreathingExercise(): base(activityDuration)
    {
        
        Console.WriteLine("Breathe In");

        Activity.CountDown(int activityDuration);
        Console.WriteLine("Breathe Out");

    }
   
}