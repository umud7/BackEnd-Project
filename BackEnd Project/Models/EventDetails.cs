using System;

namespace BackEnd_Project.Models
{
    public class EventDetails
    {
        public int Id { get; set; }
        public DateTime? Month { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public string Title { get; set; }
        public Event Event { get; set; }
        public int EventId { get; set; }
        public EventTag EventTag { get; set; }
    }
}
