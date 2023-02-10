using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BackEnd_Project.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please do not leave the box blank"),MaxLength(20)]
        public string Name { get; set; }
        [Display(Name="Description")]
        [Required(ErrorMessage = "Please do not leave the box blank"), MinLength(10,ErrorMessage = "Please add a value above 10")]
        public string Desc { get; set; }
        public List<CourseCategory> CourseCategory { get; set; }
    }
}
