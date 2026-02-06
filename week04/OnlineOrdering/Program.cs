using System;

class Program
{
    static void Main(string[] args)
    {
        // Order 1 - USA
        Address address1 = new Address(
            "123 Main St",
            "Salt Lake City",
            "UT",
            "USA");

        Customer customer1 = new Customer("John Smith", address1);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "P100", 800, 1));
        order1.AddProduct(new Product("Mouse", "P200", 25, 2));

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalPrice()}\n");

        // Order 2 - Outside USA
        Address address2 = new Address(
            "Av. San Martín 456",
            "Mendoza",
            "Mendoza",
            "Argentina");

        Customer customer2 = new Customer("Sebastián Sosa", address2);

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Book", "B300", 15, 3));
        order2.AddProduct(new Product("Notebook", "N400", 5, 4));

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalPrice()}");
    }
}
