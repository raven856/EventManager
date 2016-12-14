using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace EventManager.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public string bio { get; set; }
        public string name { get; set; }
        public List<FollowingTag> FollowingTags { get; set; }
        public List<FollowingTag> FolloweeTags { get; set; }
        //public ICollection<ApplicationUser> followers { get; set; }
        //public ICollection<ApplicationUser> following { get; set; }
        public List<AttendanceTag> AttendanceTags { get; set; }

    }
}
