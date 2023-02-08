namespace BackEnd_Project.Models
{
    public class EventSpeaker
    {
        public int Id { get; set; }
        public int EventId { get; set; }
        public Event Event { get; set; }
        public int EventSpeakerId { get; set; }
        public Speaker Speaker { get; set; }

    }
}
