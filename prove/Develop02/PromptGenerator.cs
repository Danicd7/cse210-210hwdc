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
                string prompt = "Positive Things";
            }
            if (PromptNumber == 2)
        
            { 
                string prompt = "Things to change";
            }
            if (PromptNumber == 2)
        
            { 
                string prompt = "Best moment of the day";
            }
            if (PromptNumber == 2)
        
            { 
                string prompt = "Did you have any issues today? Tell me. “Who remembers the history won’t repeat it";
            }
        }
    }
