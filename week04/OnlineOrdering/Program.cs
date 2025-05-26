using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");

        Customer customer1 = new Customer("John Doe", new Address("121 Slacks Rd.", "Palmerston North", "Awapuni", "NZ"));
        Customer customer2 = new Customer("Jane Doe", new Address("345 Main St.", "New York City", "NY", "USA"));

        Order order1 = new Order(customer1);
        Order order2 = new Order(customer2);

        order1.AddProduct(new Product("Apple", 1001, 0.65, 7));
        order1.AddProduct(new Product("Banana", 1002, 0.75, 3));
        order2.AddProduct(new Product("Orange", 1003, 0.85, 4));
        order2.AddProduct(new Product("Pear", 1004, 0.95, 6));

        Console.WriteLine("Order 1:");
        Console.WriteLine($"Packing Label\n----------------\n{order1.GetPackingLabel()}");
        Console.WriteLine($"Shipping Label\n----------------\n{order1.GetShippingLabel()}\n----------------");
        Console.WriteLine($"Total Price: ${order1.GetPrice():F}");
        Console.WriteLine();
        Console.WriteLine("Order 2:");
        Console.WriteLine($"Packing Label\n----------------\n{order2.GetPackingLabel()}");
        Console.WriteLine($"Shipping Label\n----------------\n{order2.GetShippingLabel()}\n----------------");
        Console.WriteLine($"Total Price: ${order2.GetPrice():F}");
        Console.WriteLine();
    }
}