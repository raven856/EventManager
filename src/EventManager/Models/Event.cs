using System;
using System.Collections.Generic;

namespace EventManager.Models
{
    public class Event
    {
        public string name { get; set; }
        public int id { get; set; }
        public string description { get; set; }
        public DateTime date { get; set; }
        public string artistId { get; set; }
        public ApplicationUser artist { get; set; }
        public string genre { get; set; }
        public bool isCanceled { get; set; }
        public List<AttendanceTag> AttendanceTags { get; set; }

    }
}
