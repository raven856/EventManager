using EventManager.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EventManager.Models
{
    public class AttendanceTag
    {
        //[Key]
        //public int AttendanceTagId { get; set; }

        [Key]
        public string Id { get; set; }

        [ForeignKey("Id")]
        public ApplicationUser aUser { get; set; }

        [Key]
        public int EventId { get; set; }

        [ForeignKey("EventId")]
        public Event anEvent { get; set; }
    }
}