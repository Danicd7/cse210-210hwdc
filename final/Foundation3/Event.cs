public class Event
{
    protected string _eventTitle, _description, _eventDate, _eventTime, _eventAdress, _eventType, _especificInfo;

    public Event (string eventTitle, string description, string eventDate, string eventTime, string eventAdress, string eventType, string especificInfo)
    {
        _eventTitle = eventTitle;
        _description = description;
        _eventDate = eventDate;
        _eventTime = eventTime;
        _eventAdress = eventAdress;
        _eventType = eventType;
        _especificInfo = especificInfo;
    }

    
    /*public void SetEspecificInfo(string especificInfo)
    {
        _especificInfo = especificInfo;
    }

    public string GetEspecificInfo()
    {
        return _especificInfo;
    }*/

    public string Standard()
    {
        return String.Format("Event Title: {0}, Description: {1}, Date: {2}, Time: {3}, Adress: {4}.", _eventTitle, _description, _eventDate, _eventTime, _eventAdress);
    }
    public string FullDetails()
    {
        return String.Format("Type of Event: {0}, especific Information: {1} {2}", Standard(), _eventType, _especificInfo);
    }
    public string ShortDescription()
    {
        return String.Format("Short description: {0} {1} {2}", _eventType, _eventTitle, _eventDate);
    }

    
} 