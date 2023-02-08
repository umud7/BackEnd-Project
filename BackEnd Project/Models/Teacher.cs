namespace BackEnd_Project.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string ImageUrl { get; set; }
        public string Position { get; set; }
        public int SocialPageId { get; set; }
        public SocialPage SocialPage { get; set; }
        

    }
}
