using System;

public class Product{
    private string _name;
    private int _productId;
    private decimal _price;
    private int _quantity;

     public Product(decimal price, int quantity, int productId, string name)
    {
        _price = price;
        _quantity = quantity;
        _productId = productId;
        _name = name;
    }


    public decimal CalculateTotalCost(){
        
        return _price * _quantity;
    }

    public string GetName(){
        return _name;
    }

    public int GetProductId(){
        return _productId;
    }
}