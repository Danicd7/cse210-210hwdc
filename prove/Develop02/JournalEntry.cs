using System;

public class Journal

{

    public void Run()
    {
        Console.WriteLine("you choose: " + GetChoice());
    }
   

    private string GetChoice()
    {
        bool isChoiceValid = false;
        string choice = "";
        do
        {
            Console.WriteLine("\nPlease select one of the following choises");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");

            choice = Console.ReadLine().Trim();

            if (choice == "1" || choice == "2" || choice == "3" || choice == "4" )
            {
                isChoiceValid = true;
            }
            else
            {
                Console.WriteLine($"\"{choice}\"is not a valid option. Please choose 1 - 4.");
            }

            }while(!isChoiceValid);

            return choice;



    }
   
   
}