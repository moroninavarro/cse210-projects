using System;
public class Customer{
    private Address _address;
    private string _name;
   
    public Customer(Address address){
        _address = address;
    }

//llamar la clase que tengo en el Address y ponerla aqui abajo.
//The customer should have a method that can return whether they live 
//in the USA or not. (Hint this should call a method on the address to
// find this.)

   

    public bool Direction(){
        return _address.IsInUSA();
    }
}