 using System;
 class Adress
{
    private string _street; 
    private string _city;
    private string _stateProvince;
    private string _country;
    private bool _US = true;

    public void DisplayAdress()
    {
        Console.WriteLine($"{_street}, {_city}, {_stateProvince}. {_country}")
    }

        public void UsAdress()
    {
        Convert.ToBoolean(_country);
        if (_US == true)
        {
            Console.WriteLine("US Adress, Shipping $5");
        }
        else
        {
            Console.WriteLine("Not US Adress, Shipping $35");
        }
    } 
}