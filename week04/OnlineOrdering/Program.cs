using System;
// I used Meta AI to be able to do this assignment.
class Program
{
    static void Main(string[] args)
    {
       
        Product product1 = new Product(10.99m, 3, 1234, "Juice");
        Product product2 = new Product(5.99m, 3, 4321, "Apple");
        Product product3 = new Product(7.99m, 3, 5678, "Hamburger");

        Address address1 = new Address("Broadway", "New York", "NY","USA");
        Address address2 = new Address("Hollywood Boulevard", "The Angels", "California","USA");
        Address address3 = new Address("Avenida Revolucion", "Tijuana", "Baja California","Mexico");

        Customer customer1 = new Customer("John", address1);
        Customer customer2 = new Customer("Maria", address2);
        Customer customer3 = new Customer("James", address3);


        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        Order order2 = new Order(customer2);
        order2.AddProduct(product1);
        order2.AddProduct(product2);
        order2.AddProduct(product3); 

        Order order3 = new Order(customer3);
        order3.AddProduct(product1);
        order3.AddProduct(product2);
        order3.AddProduct(product3);

        Console.WriteLine("Order 1: ");
        Console.WriteLine("Packing label... \n" + order1.GetPackingLabel());
        Console.WriteLine("Shipping label... " + order1.GetShippingLabel());
        Console.WriteLine("Total Price: " + order1.CalculateTotalPrice());
        Console.WriteLine();

        Console.WriteLine("Order 2: ");
        Console.WriteLine("Packing label... \n" + order2.GetPackingLabel());
        Console.WriteLine("Shipping label... " + order2.GetShippingLabel());
        Console.WriteLine("Total Price: " + order2.CalculateTotalPrice());
        Console.WriteLine();

        Console.WriteLine("Order 3: ");
        Console.WriteLine("Packing label... \n" + order3.GetPackingLabel());
        Console.WriteLine("Shipping label... " + order3.GetShippingLabel());
        Console.WriteLine("Total Price: " + order3.CalculateTotalPrice());
        Console.WriteLine();
    }


}