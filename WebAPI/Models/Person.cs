using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models {
public class Person {
    [Key]
    public int Id { get; set; }
    [Required, StringLength(50)]
    public string FirstName { get; set; }
    
    [Required, StringLength(50)]
    public string LastName { get; set; }
    
    [Required, StringLength(50)]
    public string HairColor { get; set; }
    
    [Required, StringLength(50)]
    public string EyeColor { get; set; }
    
    [Required, Range(0,99)]
    public int Age { get; set; }
    [Required,Range(0.0,500.0)]
    public float Weight { get; set; }
    [Required, Range(0,300)]
    public int Height { get; set; }
    [Required]
    public string Sex { get; set; }
}


}