using EventManager.Models;

namespace EventManager.Models
{
    public class AttendanceTag
    {
        public string UserId { get; set; }
        public ApplicationUser aUser { get; set; }

        public int EventId { get; set; }
        public Event anEvent { get; set; }
    }
}