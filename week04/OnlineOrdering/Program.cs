using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");

        Address address = new Address(" ", " "," "," ");
        Customer customer = new Customer(address);
        customer.Direction();
    }
}