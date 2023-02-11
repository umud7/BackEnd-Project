﻿namespace BackEnd_Project.Models
{
    public class CourseImage
    {

        public int Id { get; set; }
        public string ImageUrl { get; set; }
        public bool IsMain { get; set; }
        public int? CourseId { get; set; }
        public Course Course { get; set; }
    }
}
