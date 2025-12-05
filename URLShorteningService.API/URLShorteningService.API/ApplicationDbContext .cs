using Microsoft.EntityFrameworkCore;
using URLShorteningService.API.Model.Entities;

namespace URLShorteningService.API
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Model.Entities.Url> Urls { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Url>(entity =>
            {
                entity.HasKey(u => u.Id);

                entity.HasIndex(u => u.ShortCode)
                      .IsUnique(); // enforces unique short codes

                entity.Property(u => u.OriginalUrl)
                      .IsRequired()
                      .HasMaxLength(2048);

                entity.Property(u => u.ShortCode)
                      .IsRequired()
                      .HasMaxLength(16);

                entity.Property(u => u.CreatedAt)
                      .HasDefaultValueSql("GETUTCDATE()");
            });
        }
    }
}
