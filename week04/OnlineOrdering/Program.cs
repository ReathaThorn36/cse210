using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Apple St", "New York", "NY", "USA");
        Customer customer1 = new Customer("Alice Johnson", address1);
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Book", "B001", 12.5, 2));
        order1.AddProduct(new Product("Pen", "P101", 1.5, 5));

        Address address2 = new Address("456 Banana Rd", "London", "England", "UK");
        Customer customer2 = new Customer("Bob Smith", address2);
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Notebook", "N202", 5.0, 3));
        order2.AddProduct(new Product("Bag", "BG55", 25.0, 1));

        Console.WriteLine("Order 1");
        Console.WriteLine("Packing Label:\n" + order1.GetPackingLabel());
        Console.WriteLine("Shipping Label:\n" + order1.GetShippingLabel());
        Console.WriteLine("Total Price: $" + order1.GetTotalCost());
        Console.WriteLine();

        Console.WriteLine("Order 2");
        Console.WriteLine("Packing Label:\n" + order2.GetPackingLabel());
        Console.WriteLine("Shipping Label:\n" + order2.GetShippingLabel());
        Console.WriteLine("Total Price: $" + order2.GetTotalCost());
    }
}
