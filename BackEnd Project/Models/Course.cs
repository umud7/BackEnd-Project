using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackEnd_Project.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
        public CourseDetail CourseDetail { get; set; }
        public List<CourseImage> CourseImages { get; set; }

        public CourseTag CourseTags { get; set; }
        public List<CourseCategory> CourseCategory { get; set; }
        [NotMapped]
        public IFormFile [] Photos { get; set; }
    }
}
