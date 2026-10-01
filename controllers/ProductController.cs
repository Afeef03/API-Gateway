using Microsoft.AspNetCore.Mvc;
using productsApi.Models;

namespace productsApi.Controllers;

[ApiController]
[Route("/api/products")]
public class ProductsController : ControllerBase
{
    private readonly List<Product> products = new List<Product>
{
    new Product
    {
        ID = 1,
        Name = "Laptop",
        stock = 10,
        description = "15-inch business laptop",
        price = 75000
    },
    new Product
    {
        ID = 2,
        Name = "Keyboard",
        stock = 25,
        description = "Mechanical keyboard",
        price = 3500
    },
    new Product
    {
        ID = 3,
        Name = "Mouse",
        stock = 40,
        description = "Wireless mouse",
        price = 1500
    }
};
    [HttpGet]
    public IActionResult GetProducts()
    {
        return Ok(products);
    }

    [HttpGet("{id}")]
    public IActionResult GetProductById(int id)
    {
        Product? product = products.FirstOrDefault(product => product.ID == id);

        if (product == null)
        {
            return NotFound();
        }

        return Ok(product);
    }

    [HttpPost]
    public IActionResult CreateProduct(Product product)
    {
        product.ID = products.Count + 1;
        products.Add(product);

        return Ok(product);
    }
}