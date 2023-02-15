using System;
public class RecordProcessing
{
    List<string> _goalsList = new List<string>();
    List<Goal> newGoals = new List<Goal>();
    public int _totalPoints = 0;

    public void CreateNewGoal(Goal newGoal)
    {
        Console.Write("Add New Goal:");
        newGoals.Add(newGoal);
    }
    // public void Save()
    // {
    //     string filename = "";
    //     using(StreamWriter save= new StreamWriter(filename))
    //     foreach (Goals item in list)
    //     {
    //         save.Write(${goal.})
    //     }
    // }
    // public void Load()
    // {

    // }

    public string AskFileName()
    {
        Console.Write("What is the name of your file?");
        return Directory.GetCurrentDirectory() + "\\Files\\"+ Console.ReadLine();
    }
    public void SaveFile()
    {
        if (newGoals.Count() == 0)
        {
            Console.WriteLine("No new goals to save.");
            return;
        }
    
        string filename = AskFileName();
            // using(StreamWriter save = new StreamWriter(filename))
            // foreach (JournalEntry item in list)
            // {
            //     save.Write($"{item._date}|{item._prompt}|{item._response}|");
            // }
        List<string>saveGoals = new List<string>();
        saveGoals.Add(_totalPoints.ToString());
        foreach (Goal goal in newGoals)
        {
            saveGoals.Add(goal.ToCSVRecord());
        }
        //SaveLoadCSV.SaveToCSV(saveGoals, filename);
        Console.WriteLine("Goals saved.");

    }    
    public void LoadFile()
    {
        string filename = AskFileName();
        string[] lines = System.IO.File.ReadAllLines(filename);
        using (StreamReader read = new StreamReader(filename))
        foreach(string item in lines)
        {
            JournalEntry fullEntry = new JournalEntry();
            list.Add(fullEntry);
            List <string> allInfo = item.Split("|").ToList();

            fullEntry._date = allInfo[0];
            fullEntry._prompt = allInfo[1];
            fullEntry._response = allInfo[2];
                
    public void DisplayGoals()
    {
        if (newGoals.Count()==0)
        {
            Console.WriteLine("No goals available. Please create new goal.");
        }
        foreach(Goals goal in newGoals)
        {
            Console.WriteLine(goal.ToString());
        }
    }
    public int CalculateTotalPoints()
    {
        return _totalPoints;
    }

    public void DisplayScore()
    {
        //total
        Console.WriteLine($"You have {CalculateTotalPoints()} points.");
    }
}