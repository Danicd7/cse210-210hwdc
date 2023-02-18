 using System;
public class Address
{
    private string _street; 
    private string _city;
    private string _stateProvince;
    private string _country;

    public Address() {}

    public Address(string street, string city, string stateProvince, string country)
    {
        _street = street;
        _city = city;
        _stateProvince = stateProvince;
        _country = country;
    }
    

    public bool UsAdress()
    {
        if (_country == "US")
        {
            //Console.WriteLine("US Adress, Shipping");
            return true;
        }
        else
        {
            //Console.WriteLine("Not US Adress, Shipping");
            return false;
        }

        
    } 

    public string DisplayAdress()
    {
        return String.Format("stree:{0}, city: {1}, State/Province: {2}, Country: {3}", _street, _city, _stateProvince, _country);

    }
}