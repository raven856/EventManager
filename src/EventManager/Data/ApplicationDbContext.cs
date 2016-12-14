using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace EventManager.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);

            ////////modelBuilder.Entity<ApplicationUser>()
            ////////    .HasMany(x => x.followers)
            ////////    .WithMany(x => x.following)
            ////////    .Map(x => x.ToTable("Followers")
            ////////    .MapLeftKey("UserId")
            ////////    .MapRightKey("FollowerId"));

            modelBuilder.Entity<FollowingTag>()
            .HasKey(t => new { t.followerId, t.followeeId });

            modelBuilder.Entity<FollowingTag>()
                .HasOne(ft => ft.follower)
                .WithMany(u => u.FollowingTags)
                .HasForeignKey(ft => ft.followerId).IsRequired();

            modelBuilder.Entity<FollowingTag>()
                .HasOne(ft => ft.followee)
                .WithMany(u => u.FolloweeTags)
                .HasForeignKey(ft => ft.followeeId);


            modelBuilder.Entity<AttendanceTag>()
            .HasKey(t => new { t.UserId, t.EventId });

            modelBuilder.Entity<AttendanceTag>()
                .HasOne(at => at.aUser)
                .WithMany(p => p.AttendanceTags)
                .HasForeignKey(at => at.UserId);

            modelBuilder.Entity<AttendanceTag>()
                .HasOne(at => at.anEvent)
                .WithMany(t => t.AttendanceTags)
                .HasForeignKey(at => at.EventId);
        }

        public DbSet<Event> Events { get; set; }
        public DbSet<FollowingTag> FollowingTags { get; set; }
        public DbSet<AttendanceTag> AttendanceTags { get; set; }
    }
}