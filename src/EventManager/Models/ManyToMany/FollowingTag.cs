using EventManager.Models;

namespace EventManager.Models
{
    public class FollowingTag
    {        
        //only Regular users follow
        public string followerId { get; set; }
        public ApplicationUser follower { get; set; }
        
        //only Artists are followed
        public string followeeId { get; set; }
        public ApplicationUser followee { get; set; }
    }
}