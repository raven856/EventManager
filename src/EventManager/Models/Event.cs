﻿using System;

namespace EventManager.Models
{
    public class Event
    {
        public int id { get; set; }
        public string description { get; set; }
        public DateTime date { get; set; }
        public ApplicationUser artist { get; set; }
        public string genre { get; set; }
        public bool isCanceled { get; set; }
    }
}