using System;
public class Lecture : Event
{
    private string _speaker;
    private int _limitedCapacity = 0;

    public Lecture (string eventTitle, string description, string eventDate, string eventTime, string eventAdress, string eventType, string especificInfo, string speaker, int limitedCapacity) 
    : base (eventTitle, description,  eventDate,  eventTime, eventAdress, eventType, especificInfo)
    {
        _speaker = speaker;
        _limitedCapacity = limitedCapacity;

    }


    public string GetSpeaker()
    {
        return String.Format("The invited speaker will be {0}", _speaker);
    }
    public string FullCapacity()
    {
        return String.Format("The capacity for this place is of {0} people", _limitedCapacity);
    }
    //public void SetEspecificInfo(string especificInfo)
    //{
        //_especificInfo = especificInfo;
    //}

    //public string GetEspecificInfo()
    //{
        //return especificInfo;
    //}

    public string SpecificInfo()
    {
        _especificInfo = String.Format("Spreaker: {0}, Capacity: {1}",GetSpeaker(), FullCapacity());
        return _especificInfo;
    }

    public string DisplayLectureEventS()
    {
       return String.Format(Standard());
    }
    public string DisplayLectureEventF()
    {
       return String.Format(FullDetails());
    }
    public string DisplayLectureEventSh()
    {
       return String.Format(ShortDescription());
    }
}