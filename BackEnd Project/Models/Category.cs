using System.Collections.Generic;

namespace BackEnd_Project.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<CourseCategory> CourseCategory { get; set; }
    }
}
