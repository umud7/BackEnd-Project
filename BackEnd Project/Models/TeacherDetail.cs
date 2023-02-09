namespace BackEnd_Project.Models
{
    public class TeacherDetail
    {
        public int Id { get; set; }
        public string AboutMe { get; set; }
        public string Degree { get; set; }
        public string Hobby { get; set; }
        public string Experience { get; set; }
        public string Faculty { get; set; }
        public string MailMe { get; set; }
        public string PhoneNumber { get; set; }
        public string SkypeLink { get; set; }
        public Teacher Teacher { get; set; }
        public int TeacherId { get; set; }
        public TeacherSkill TeacherSkill { get; set; }
    }
}
