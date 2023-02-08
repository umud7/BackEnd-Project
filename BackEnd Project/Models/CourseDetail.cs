using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BackEnd_Project.Models
{
    public class CourseDetail
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string About { get; set; }
        public string Apply { get; set; }
        public string Certification { get; set; }
        public string Reply { get; set; }

        public DateTime StartDate { get; set; }
        public string Duration { get; set; }
        public int ClassDuration { get; set; }
        public string SkillLevel { get; set; }
        public string Language { get; set; }
        public int StudentCount { get; set; }
        public string Assesments { get; set; }
        public int CourseFee { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }
    }
}
