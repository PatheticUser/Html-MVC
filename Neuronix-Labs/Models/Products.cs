using System.ComponentModel.DataAnnotations;

namespace MyApp.Models;

public class Product
{
    [Key] // Explicitly marking it as Primary Key
    public int Id { get; set; }  // Rename Id to ProductId
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public string ImagePath { get; set; }
}

