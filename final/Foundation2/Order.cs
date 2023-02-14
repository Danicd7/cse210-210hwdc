using System;
class Order
{
    public Customer _customer;
    public List<Product> _products;
    public int _shipping = 0;
    public string _shipingLabel = "";
    public string _packingLabel = "";

    
    public double TotalCost()
    {
        double _totalCost = 0;
        foreach (Product product in _products)
        {
            _totalCost += product.CalculatePrice();
        }

        _totalCost += _shipping;

        return _totalCost;
    }
    public string GetShipingLabel()
    {
        return _shipingLabel;
    }
    public string GetPackingLabel()
    {
        return _packingLabel;
    }
}