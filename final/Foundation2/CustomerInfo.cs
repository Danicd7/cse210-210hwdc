public class Customer
{
    private string _customerName = "";
    private bool _customerLivesUs;

    private Address _address = new Address();
    	
    public bool CXlisInUSA()
    {
        _customerLivesUs = _address.UsAdress();
        return _customerLivesUs;
    }    
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