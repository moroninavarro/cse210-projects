using System;
public class Customer{
    private Address _address;
    private string _name;
   
    public Customer(string name, Address address){
        _address = address;
        _name = name;
    }

//The customer should have a method that can return whether they live 
//in the USA or not. (Hint this should call a method on the address to
// find this.)

   

    public bool Direction(){
        return _address.IsInUSA();
    }

    public string Display(){
    
    return _address.DisplayText();
    
}
public string DisplayName(){
    
    return _name;
    
}

}