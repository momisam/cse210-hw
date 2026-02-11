using System;

class Program
{
    static void Main(string[] args)
    {
        // First Order (USA)
        Address address1 = new Address("123 Main St", "New York", "NY", "USA");
        Customer customer1 = new Customer("John Smith", address1);
        Order order1 = new Order(customer1);

        order1.AddProduct(new Product("Laptop", "P1001", 800, 1));
        order1.AddProduct(new Product("Mouse", "P2001", 25, 2));

        // Second Order (International)
        Address address2 = new Address("45 King Road", "London", "N/A", "UK");
        Customer customer2 = new Customer("Emily Brown", address2);
        Order order2 = new Order(customer2);

        order2.AddProduct(new Product("Phone", "P3001", 600, 1));
        order2.AddProduct(new Product("Headphones", "P4001", 100, 1));
        order2.AddProduct(new Product("Charger", "P5001", 20, 3));

        // Display Order 1
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost()}");
        Console.WriteLine("----------------------------");

        // Display Order 2
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost()}");
    }
}
