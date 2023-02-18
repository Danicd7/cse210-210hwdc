public class Reception : Event 
{
    private string reservationEmail;

    public Reception (string eventTitle, string description, string eventDate, string eventTime, string eventAdress, string eventType, string especificInfo, string _reservationEmail)
    : base (eventTitle, description,  eventDate,  eventTime, eventAdress, eventType, especificInfo)
    {
        reservationEmail = _reservationEmail;
    }
    public string ReservationDone()
    {
        return String.Format("Do your reservation here by typing your email: ", reservationEmail);
        
    }
}