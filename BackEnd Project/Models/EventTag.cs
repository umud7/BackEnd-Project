namespace BackEnd_Project.Models
{
    public class EventTag
    {
        public int Id { get; set; }
        public int EventId { get; set; }
        public Event Event { get; set; }
        public int TagId { get; set; }
        public Tag Tag { get; set; }
    }
}
