public class ListingActivity : Activity
{
    private string _listingPrompt = "";
    private string _responsePrompt = "";

    //public ListingActivity(string ActivityName, string startDescription, int activityDuration, string endingDescription, string breathingIn, string breathingOut)
        //: base(ActivityName, startDescription, activityDuration, endingDescription)
    //{
        //_breathingIn = breathingIn;
        //_breathingOut = breathingOut;
    //}
     public void ProvidePrompt()
        {
            Random rnd = new Random();
            List<string> prompts = new List<string>();
            prompts.Add("Who are people that you appreciate?");
            prompts.Add("What are personal strenghts of yours?");
            prompts.Add("Who are people that you have helped this week?");
            prompts.Add("When have you felt the Holy Ghost this month?");
                prompts.Add("Who are some of your personal heroes?");

            int index = rnd.Next(0,4);
            Console.WriteLine(prompts[index]);
            listingPrompt = prompts[index];
        
        }

        public void EnterResponse()
        {
            _responsePrompt = Console.ReadLine();
        }

  
}