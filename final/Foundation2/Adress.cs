 using System;
 class Address
{
    private string _street; 
    private string _city;
    private string _stateProvince;
    private string _country;

    public string DisplayAdress()
    {
        return (string.Format("{0}\n{1}, {2}, {3}", _street, _city, _stateProvince, _country));
    }

    public void UsAdress()
    {
        if (_country == "ÜS")
        {
            Console.WriteLine("US Adress, Shipping $5");
        }
        else
        {
            Console.WriteLine("Not US Adress, Shipping $35");
        }
    } 
}