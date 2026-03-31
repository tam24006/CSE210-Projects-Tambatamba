using System;

class Program
{
    static void Main(string[] args)
    {
        Customer c1 = new Customer("John Doe", new Address("123 Main St", "Anytown", "CA", "USA"));
        Customer c2 = new Customer("Jane Smith", new Address("456 Elm St", "Othertown", "NY", "Canada"));

        List<Product> products1 = new List<Product>()
        {
            new Product("Laptop", "Electronics", 10.0, 2),
            new Product("USB-C", "Electronics", 15.0, 1)
        };

        List<Product> products2 = new List<Product>()
        {
            new Product("keybroad", "Electronics", 20.0, 3),
            new Product("wireless Mouse", "Electronics", 5.0, 5)
        };

        Order order1 = new Order(c1, products1);
        Order order2 = new Order(c2, products2);

        List<Order> ordersList = new List<Order>()
        { order1, order2 };

        foreach (Order order in ordersList)
        {
            Console.WriteLine(order.PackingLabel());
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine($"\nTotal Cost: ${order.OrderTotal():0.00}\n");
            Console.WriteLine("--------------------------------------------------\n");
        }
    }
}