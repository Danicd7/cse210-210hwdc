public class Outdoor : Event 
{
    private int _weatherForecast;

    public Outdoor (string eventTitle, string description, string eventDate, string eventTime, string eventAdress, string eventType, string especificInfo, int weatherForecast) 
    : base (eventTitle, description,  eventDate,  eventTime, eventAdress, eventType, especificInfo)
    {
        _weatherForecast = weatherForecast;
    }
    public string Forecaster()
    {
        return string.Format("The wether will be Sunny: ", _weatherForecast);
    }
}