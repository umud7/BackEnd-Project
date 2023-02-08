using System.Collections.Generic;

namespace BackEnd_Project.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
        public CourseDetail CourseDetail { get; set; }
        public CourseTag CourseTags { get; set; }
    }
}
