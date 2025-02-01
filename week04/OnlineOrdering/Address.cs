using System;
using System.Security.Cryptography.X509Certificates;

public class Address{
    

//The address contains a string for the street address,
// the city, state/province, and country.
    private string _street;
    private string _city;
    private string _state;
    private string _country;

//The address should have a method that can return
// whether it is in the USA or not.

public Address(string street, string city, string state, string country){
    _street = street;
    _city = city;
    _state = state;
    _country = country;
}
 public bool IsInUSA(){
    return _country.ToUpper() =="USA"||
    _country.ToUpper() == "UNITED STATES";
 }


//The address should have a method to return a string
// all of its fields together in one string (with newline
// characters where appropriate)


public string DisplayText(){
    
    return $"Street: {_street} / City: {_city} / State: {_state} / Country: {_country}";
}
}