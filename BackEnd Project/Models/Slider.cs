using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BackEnd_Project.Models
{
    public class Slider
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; }
        public string Title { get; set; }
        public string SecondTitle { get; set; }
        [Required, MinLength(20)]
        public string Desc { get; set; }

        [NotMapped]
        [Required]
        public IFormFile Photo { get; set; }
    }
}
