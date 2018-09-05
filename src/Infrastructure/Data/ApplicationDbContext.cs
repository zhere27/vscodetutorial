using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ApplicationCore.Entities;

namespace Infrastructure.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
        }

        public DbSet<Channel> Channels { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Channel>(ConfigureChannel);
        }

        private void ConfigureChannel(EntityTypeBuilder<Channel> builder)
        {
            var navigation = builder.Metadata.FindNavigation(nameof(Channel.Branches));

            navigation.SetPropertyAccessMode(PropertyAccessMode.Field);
        }
    }
}