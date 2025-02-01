using System;

public class Product{
    private string _name;
    private int _productId;

    private decimal _price;
    private int _quantity;

     public Product(decimal price, int quantity)
    {
       _price = price;
       _quantity = quantity;

    }


    public decimal CalculateTotalCost(){
        
        return _price * _quantity;
    }
}