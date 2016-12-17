using EventManager.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EventManager.Models
{
    public class FollowingTag
    {
        //only Regular users follow
        [Key]
        public string followerId { get; set; }

        [ForeignKey("followerId")]
        public ApplicationUser follower { get; set; }

        //only Artists are followed
        [Key]
        public string followeeId { get; set; }

        [ForeignKey("followeeId")]
        public ApplicationUser followee { get; set; }
    }
}