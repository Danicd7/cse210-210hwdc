using System;
public class Order
{
    private Customer _customer;
    private List<Product> _products = new List<Product>();
    private int _shipping = 0;
    private string _shipingLabel = "";
    private string _packingLabel = "";

    public void ProductList(Product newProduct)
    {
        _products.Add(newProduct);
    }

    public void SetCustomer(Customer customer)
    {
        _customer = customer;
    }
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

    public void GetShipinCost()
    {
        bool USshipping = _customer.CXlisInUSA();
        if (USshipping == true)
        {
            _shipping = 5;
        }
        else 
        {
            _shipping = 35;
        }
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