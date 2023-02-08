using System.Collections.Generic;

namespace BackEnd_Project.Models
{
    public class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public CourseTag CourseTags { get; set; }
        public EventTag EventTag { get; set; }

    }
}
