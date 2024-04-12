using System.ComponentModel.DataAnnotations;
namespace KalabawFoods.FrontEnd.Data.Models;

public class Product
{
    public int Id { get; set; }
    
    [Required]
    [StringLength(20)]
    public string? Name { get; set; }
 
    [Required]
    [StringLength(200)]   
    public string? Description { get; set; }
 
    [Required]    
    public double Price { get; set; }

    [Required]
    public int Count { get; set; }

    [Required]
    public int? CategoryId { get; set; }

    public Category? Category { get; set;}
}