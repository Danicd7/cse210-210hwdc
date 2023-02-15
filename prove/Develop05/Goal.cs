using System;

class Goal
{
    private string _goalName, _goalDescription;
    private int _points = 0;
    private int _totalPoints = 0;
    public bool _complete;


    //public Goal (string _goalName, string _goalDescription, int _points)
    //{
        //goalName = _goalName;
        //goalDescription = _goalDescription;
        //points = _points;
    //}

    public void Goal()
    {

    }
    public void RecordEvent()
    {

    }
    public void IsComplete()
    {
                //foreach (bool b in new bool [] {false,true});
        while (_complete == true)
        {
            Console.WriteLine($"[x] {_goalName}");
        }
        while (_complete == false)
        {
            Console.WriteLine($"[] {_goalName}");
        }
    }
    public int AddPoints()
    {
        while (_complete == true);
        //adds _points
        return _totalPoints + _points;
    }
    public void GetGoalInfo()
    {
        Console.WriteLine(AddPoints());
    }
}