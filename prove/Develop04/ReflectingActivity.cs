public class ReflectingActivity : Activity
{
    private string _reflectingPrompt = "";
    private string _reflectingQuestion = "";

    //public ReflectingActivity(string prompt, string question, string ActivityName, string startDescription, int activityDuration, string endingDescription)
        //: base(ActivityName, startDescription, activityDuration, endingDescription)

  public void RunReflectingActivity()
  {
     Console.WriteLine("Reflecting Activity");
     DisplayPrompt();
     DisplayQuestion();
  }
  public void DisplayPrompt()
    {
        Random rnd = new Random();
        List<string> prompts = new List<string>();
        prompts.Add("Think of a time when you stood up for someone else");
        prompts.Add("Think of a time when you did something really difficult");
        prompts.Add("Think of a time when you helped someone in need");
        prompts.Add("Think of a time when you helped someone in need");

        int index = rnd.Next(0,3);
        Console.WriteLine(prompts[index]);
        _reflectingPrompt = prompts[index];
    }
    public void DisplayQuestion()
    {
        Random rnd = new Random();
        List<string> questions = new List<string>();
        questions.Add("Why was this experience meaningful to you?");
        questions.Add("Have you ever done aything like this before?");
        questions.Add("How did you get started?");
        questions.Add("How did you feel when it was complete?");
        questions.Add("What made this time different than other times when you were not as successful?");
        questions.Add("What is your favorite thing about this experience?");
        questions.Add("What could you learn from this experience that applies to other situations?");
        questions.Add("What did you learn abput yourself through this experience?");
        questions.Add("How can you keep this experience in mind in the future?");

        //while. until it reaches number of seconds specified for the duration
        int index = rnd.Next(0,3);
        Console.WriteLine(questions[index]);
        //pause
        //display spinner
        Console.WriteLine(questions[index]);
        _reflectingQuestion = questions[index];
    }
}