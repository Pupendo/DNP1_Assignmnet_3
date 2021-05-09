using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace WebAPI.Models
{
    public class Job
    {
        [Key]
        public int JobId { get; set; }
        [Required, StringLength(100)]
        public string JobTitle { get; set; }
        [Required, Range(0,1000000)]
        public int Salary { get; set; }
    }
}