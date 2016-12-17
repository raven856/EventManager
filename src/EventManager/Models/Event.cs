using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EventManager.Models
{
    public class Event
    {
        [Key]
        public int EventId { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public DateTime date { get; set; }

        
        public string Id { get; set; }

        [ForeignKey("Id")]
        public ApplicationUser artist { get; set; }

        public string genre { get; set; }
        public bool isCanceled { get; set; }
        public List<AttendanceTag> AttendanceTags { get; set; }

    }
}
