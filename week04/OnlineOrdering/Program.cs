using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("456 Maple Dr", "Denver", "CO", "USA");
        Customer customer1 = new Customer("Kaden Mills", address1);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Keyboard", "KB001", 49.99, 1));
        order1.AddProduct(new Product("Monitor", "MN102", 199.99, 2));

        Address address2 = new Address("88 Queen Street", "London", "London", "UK");
        Customer customer2 = new Customer("Charlotte Bell", address2);

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Headphones", "HD456", 89.99, 1));
        order2.AddProduct(new Product("Webcam", "WC789", 59.99, 2));
        order2.AddProduct(new Product("Microphone", "MC333", 120.00, 1));

        DisplayOrderDetails(order1);
        Console.WriteLine("---------------------------------");
        DisplayOrderDetails(order2);
    }

    static void DisplayOrderDetails(Order order)
    {
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order.GetTotalCost():F2}");
    }
}