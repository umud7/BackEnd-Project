namespace BackEnd_Project.Models
{
    public class Speaker
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string ImageUrl { get; set; }
        public EventSpeaker EventSpeaker { get; set; }
    }
}
