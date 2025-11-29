using System;

class Program
{
    static void Main(string[] args)
    {

        Address a1 = new Address("123 Main St", "Lima", "Lima", "Peru");
        Customer c1 = new Customer("Jared Delgado", a1);

        Order o1 = new Order(c1);
        o1.AddProduct(new Product("Laptop", "LP100", 1200, 1));
        o1.AddProduct(new Product("Mouse", "MS200", 25, 2));


        Address a2 = new Address("780 Elm Street", "Phoenix", "Arizona", "USA");
        Customer c2 = new Customer("Sarah Connor", a2);

        Order o2 = new Order(c2);
        o2.AddProduct(new Product("Headphones", "HP300", 50, 1));
        o2.AddProduct(new Product("Keyboard", "KB400", 75, 1));


        Console.WriteLine(o1.GetPackingLabel());
        Console.WriteLine(o1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${o1.GetTotalPrice()}\n");


        Console.WriteLine(o2.GetPackingLabel());
        Console.WriteLine(o2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${o2.GetTotalPrice()}");
    }
}
