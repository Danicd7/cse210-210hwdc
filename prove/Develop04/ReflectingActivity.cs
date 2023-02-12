public class ReflectingActivity : Activity
{
    private string _prompt;
    private string _question;

    public ReflectingActivity(string prompt, string question, string ActivityName, string startDescription, int activityDuration, string endingDescription)
        : base(ActivityName, startDescription, activityDuration, endingDescription)

    {
        
    }
}