class Activity
{
    private string _date;
    private double _lengthActivity = 0.0;
    private int _speed = 0;
    private double _pace = 0.0;

    public Activity (string date, double lengthActivity, int speed, double pace)
    {
        _date = date;
        _lengthActivity = lengthActivity;
        _speed = speed;
        _pace = pace;
    }

    public void GetDistance()
    {

    }
    public void GetSpeed()
    {
        _speed
    }
    public void GetPace()
    {
        _pace = 60 / _speed;
    }
    public void GetSummary()
    {
        
    }
}