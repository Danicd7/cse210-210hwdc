class Product 
{
    private int _quantity = 0;
    private double _price = 0.0;
    private int _productId = 0;
    private string _name = "";

    public double CalculatePrice()
    {
        return _quantity * _price;
    }
    public void DisplayProduct()
    {
        Console.WriteLine($"{_productId}-{_name}");
    }
}