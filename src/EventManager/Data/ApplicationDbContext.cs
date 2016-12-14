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

            //modelBuilder.Entity<PlaylistTag>()
            //.HasKey(t => new { t.AlbumId, t.PlaylistId });

            //modelBuilder.Entity<PlaylistTag>()
            //    .HasOne(pt => pt.aAlbum)
            //    .WithMany(p => p.PlaylistTags)
            //    .HasForeignKey(pt => pt.AlbumId);

            //modelBuilder.Entity<PlaylistTag>()
            //    .HasOne(pt => pt.aPlaylist)
            //    .WithMany(t => t.PlaylistTags)
            //    .HasForeignKey(pt => pt.PlaylistId);

        }

        public DbSet<Event> Events { get; set; }

        //public DbSet<> Artists { get; set; }
        //public DbSet<Genre> Genres { get; set; }
        //public DbSet<Playlist> Playlist { get; set; }
        //public DbSet<PlaylistTag> PlaylistTag { get; set; }

    }
}
