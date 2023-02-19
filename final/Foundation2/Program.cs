using System;

class Program
{
    static void Main(string[] args)
    {
        Order Order1 = new Order();
        Customer fisrtCustomer = new Customer("Daniel");
        
        
        Order1.SetCustomer(fisrtCustomer);
        Console.WriteLine(Order1.DispalyShipingLabel());

        Product firstProduct = new Product("Laptop", 3, 1, 1250);
        Product secondProduct = new Product("Horse", 1234, 1, 35000);
        Product therdProduct = new Product("Candy", 1, 35, 10);
        Order1.ProductList(firstProduct);
        Order1.ProductList(secondProduct);
        Order1.ProductList(therdProduct);
        Order1.DisplayList();
        Console.WriteLine(Order1.CalculateOrderCost());
       

        Address DanielAdress = new Address("C/ lavapies", "Madrid", "Madrid", "Spain");
        fisrtCustomer.SetCustomerAddress(DanielAdress);
        Console.WriteLine(DanielAdress.DisplayAdress());

        Console.WriteLine("*******************************************");

        Order Order2 = new Order();
        Customer secondCustomer = new Customer("Antonia");
        
        
        Order2.SetCustomer(secondCustomer);
        Console.WriteLine(Order2.DispalyShipingLabel());

        Product AntoniaProduct1 = new Product("Backpack", 3, 1, 35);
        Product AntoniaProduct2 = new Product("Red Car", 1234, 1, 40000);
        Product AntoniaProduct3 = new Product("Candy", 1, 35, 10);
        Order2.ProductList(AntoniaProduct1);
        Order2.ProductList(AntoniaProduct2);
        Order2.ProductList(AntoniaProduct3);
        Order2.DisplayList();
        Console.WriteLine(Order2.CalculateOrderCost());
       

        Address AntoniaAdress = new Address("C/ Los Rincones", "Badajoz", "Almendralejos", "Spain");
        fisrtCustomer.SetCustomerAddress(AntoniaAdress);
        Console.WriteLine(AntoniaAdress.DisplayAdress());

        Console.WriteLine("*******************************************");

        Order Order3 = new Order();
        Customer thirdCustomer = new Customer("Brown");
        
        
        Order3.SetCustomer(secondCustomer);
        Console.WriteLine(Order3.DispalyShipingLabel());

        Product BrownProduct1 = new Product("Window", 45, 1, 100);
        Product BrownProduct2 = new Product("House", 3234, 1, 400000);
        Product BrownProduct3 = new Product("Candy", 1, 35, 10);
        Order3.ProductList(BrownProduct1);
        Order3.ProductList(BrownProduct2);
        Order3.ProductList(BrownProduct3);
        Order3.DisplayList();
        Console.WriteLine(Order3.CalculateOrderCost());
       

        Address BrownAdress = new Address("C/ Calle Nipona", "Barcelona", "Hospitalet", "Spain");
        fisrtCustomer.SetCustomerAddress(BrownAdress);
        Console.WriteLine(BrownAdress.DisplayAdress());
    }
}