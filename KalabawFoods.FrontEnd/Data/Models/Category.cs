using System.ComponentModel.DataAnnotations;
namespace KalabawFoods.FrontEnd.Data.Models;

public class Category
{
    public int Id { get; set; }
    
    [Required]
    [StringLength(20)]
    public string? Name { get; set; }

    public List<Product> Products { get; set; } = new(); 
}