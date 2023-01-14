using System;


public class PromptMessage
{
    static string chooseprompt()
    {
        string prompt = "";
        Random randomGenerator = new Random();
        int PromptNumber = randomGenerator.Next(1, 5);


        
        if (PromptNumber == 1)
            {
                string prompt = "Lower";
            }
            else
            {
                Console.WriteLine("You guesses it!");
            }
        }
    }
}