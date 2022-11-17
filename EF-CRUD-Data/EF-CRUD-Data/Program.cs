//CRUD  = CREATE, READ, UPDATE and DELETE DATA
using EF_CRUD_Data.Models;
using Microsoft.EntityFrameworkCore;

Console.WriteLine("Hello, Entity Framework!");


// Query Data
// Reading all data
NorthwindContext context = new NorthwindContext();
var products = context.Products.ToList();
Console.WriteLine(products.Count);

// Reading a single entity
context = new NorthwindContext();
var oneProduct = context.Products.Single(p=>p.ProductId==1);
Console.WriteLine(oneProduct);

// Filtering the data
context = new NorthwindContext();
var manyProducts = context.Products.Where(p => p.QuantityPerUnit.ToUpper().Contains("bottle"));
Console.WriteLine(manyProducts.Count());
foreach (var product in manyProducts)
{
    Console.WriteLine(product.ProductName + " - " + product.QuantityPerUnit);
}

// Read all employees and print first and last name

// Read all employees who live in Graz



// Basic LINQ Query Operations
var allProducts = from p in context.Products select p;
var someProducts = from p in context.Products where p.UnitPrice > 50 select p;
foreach (var product in someProducts)
{
    Console.WriteLine(product.ProductName + " - " + product.UnitPrice);
}

var fewProducts = from p in context.Products where p.UnitPrice > 50 && p.ProductName.Contains("Apple") select p;
foreach (var product in fewProducts)
{
    Console.WriteLine(product.ProductName + " - " + product.UnitPrice);
}

// Ordering
Console.WriteLine("Order BY");
var someProductsOrderedByPrice = from p in context.Products where p.UnitPrice > 50 orderby p.UnitPrice ascending select p;
foreach (var product in someProductsOrderedByPrice)
{
    Console.WriteLine(product.ProductName + " - " + product.UnitPrice);
}

//Grouping
var orderDetails = from o in context.OrderDetails group o by o.OrderId;
foreach (var orderdetail in orderDetails)
{
    Console.WriteLine(" {0}, {1}",orderdetail.Key, orderdetail.Count());
    foreach (OrderDetail ord in orderdetail)
    {
        Console.WriteLine("    {0}", ord.Quantity);
    }
}


// Loading Related Entities
// Entity Framework supports three ways to load related data - eager loading, lazy loading and explicit loading.
//Eagerly Loading
// Load all the releated Items inadvanced
var allCategories = context.Categories.Include( p => p.Products);
foreach(var ca in allCategories)
{
    Console.WriteLine(ca.CategoryName + ": "  + ca.Products.Count());
    foreach (var c in ca.Products)
    {
        Console.WriteLine(c.ProductName);
    }
}

// Eagerly loading multiple levels
var allCategories2 = context.Categories.Include(p => p.Products.Select(o=>o.OrderDetails));
foreach (var ca in allCategories)
{
    foreach (var p in ca.Products)
    {
        Console.WriteLine(ca.CategoryName + " - " + ca.Products.Count + " " + p.OrderDetails.Count);
    }
}
