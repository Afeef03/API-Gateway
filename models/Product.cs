namespace productsApi.Models;

public class Product
{
    public int ID {get;set;}
    public string? Name {get;set;}
    public int stock {get;set;}
    public string? description {get;set;}
    public double price {get;set;}

}