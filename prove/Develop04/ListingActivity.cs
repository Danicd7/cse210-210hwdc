public class ListingActivity : Activity
{
    private string _breathingIn;
    private string _breathingOut;

    public ListingActivity(string ActivityName, string startDescription, int activityDuration, string endingDescription, string breathingIn, string breathingOut)
        : base(ActivityName, startDescription, activityDuration, endingDescription)
    {
        _breathingIn = breathingIn;
        _breathingOut = breathingOut;
    }

  
}