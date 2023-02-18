public class Product 
{
    private string _productName;
    private int _productId = 0;
    private int _quantity = 0;
    private double _price = 0.0;
    
    

    public Product(string productName, int productId, int quantity, double price)
    {
        _productName = productName;
        _productId = productId;
        _quantity = quantity;
        _price = price;
    }

    public double CalculatePrice()
    {
        return _quantity * _price;
    }
    public void DisplayProduct()
    {
        Console.WriteLine($"{_productId}, {_productName}, quanrity: {_quantity} price: {_price}");
    }
}