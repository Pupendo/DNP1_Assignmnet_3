using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI.Models {
public class Adult : Person {
    [Required]
    public Job JobTitle { get; set; }
}

}