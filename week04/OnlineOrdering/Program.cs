using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");

        // --- Order 1 (USA Customer) ---
        Address address1 = new Address("123 Maple St", "Springfield", "IL", "USA");
        Customer customer1 = new Customer("Alice Johnson", address1);
        Order order1 = new Order(customer1);

        order1.AddProduct(new Product("Wireless Mouse", "WM-01", 25.50, 2));
        order1.AddProduct(new Product("Mechanical Keyboard", "KB-99", 79.99, 1));

        // --- Order 2 (International Customer) ---
        Address address2 = new Address("45 Queen St W", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Bob Smith", address2);
        Order order2 = new Order(customer2);

        order2.AddProduct(new Product("USB-C Hub", "UC-12", 19.99, 3));
        order2.AddProduct(new Product("HDMI Cable", "HD-04", 12.00, 2));
        order2.AddProduct(new Product("Mouse Pad", "MP-55", 10.00, 1));

        // --- Display Order 1 Results ---
        Console.WriteLine("================ ORDER 1 ================");
        Console.WriteLine("--- SHIPPING LABEL ---");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine("\n--- PACKING LABEL ---");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine($"\nTotal Price: ${order1.CalculateTotalCost():F2}\n");

        // --- Display Order 2 Results ---
        Console.WriteLine("================ ORDER 2 ================");
        Console.WriteLine("--- SHIPPING LABEL ---");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine("\n--- PACKING LABEL ---");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine($"\nTotal Price: ${order2.CalculateTotalCost():F2}");

    }

}