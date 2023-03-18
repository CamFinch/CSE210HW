using System;

class Program
{
    static void Main(string[] args)
    {
        
        Customer c1 = new Customer("Cameron Finch");
        Address a1 = new Address("538 S Second W", "Rexburg", "ID", "USA");
        Product p1 = new Product("apple", 345345, 3, 1);
        Product p2 = new Product("phone", 324, 3, 400);
        Order o1 = new Order();
        Console.WriteLine($"{o1.PackingLabel}");
        Console.WriteLine($"{o1.ShippingLabel}");

    }
}