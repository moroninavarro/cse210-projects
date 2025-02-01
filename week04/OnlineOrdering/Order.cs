using System;
using System.Security.Cryptography.X509Certificates;

public class Order{
    
    private Address _address;
    
     public string Country;

     public Order(Address address){
        _address = address;
    }
    
    //Contains a list of products and a customer.
    public List<Product> Products;
    private Customer customer;
    
    public Order(Customer customer){
        this.customer = customer;
       // _address = customer.Address;
        Products = new List<Product>();
    }
   
    public void AddProduct(Product product)
    {
        Products.Add(product);
    }
    


//The total price is calculated
// as the sum of the total cost of each product plus a one-time shipping cost.
    public decimal CalculateTotalPrice(){
        
       decimal TotalCost = 0;
       foreach(var product in Products)
       {
        TotalCost += product.CalculateTotalCost();
       }
       decimal shippingCost = customer.Direction() ? 5:35;
       return TotalCost + shippingCost;
    }

    public string GetShippingLabel()
    {
        string shippingLabel = "\n";
        shippingLabel += $"Name of the Customer: {customer.DisplayName()} \n";
        shippingLabel += $"Address: {customer.Display()} \n";
        decimal shippingCost = customer.Direction() ? 5:35 ;
        shippingLabel += $"Shipping Cost: {shippingCost}";
        return shippingLabel;
    }

    public string GetPackingLabel()
    {
        string label = "";
        foreach (var product in Products)
        {
        label += $"Name of the product: {product.GetName()}\n";
        label += $"Product ID: {product.GetProductId()}\n\n";
        }
        return label;

    }





}