public class Customer
{
    private string _customerName = "";

    private Address _address;
    	
    public Customer(string customerName)//, Address address)
    {
        _customerName = customerName;
        //_address = address;
    }

    public void SetCustomerAddress(Address address)
    {
        _address = address;
    }

    public string GetCustomerName()
    {
        return _customerName;
    }
        
    public string GetCustomerAddress()
    {
        return _address.DisplayAdress();
    }
   
}