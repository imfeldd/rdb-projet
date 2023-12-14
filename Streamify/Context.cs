using Microsoft.EntityFrameworkCore;
namespace Streamify;

public class Context : DbContext {
    public DbSet<Title> Titles { get; set; }
    public DbSet<Genre> Genres { get; set; }
    public DbSet<Person> Persons { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
        optionsBuilder.UseNpgsql("Host=localhost:5432;Database=netflix;Username=postgres;Password=pass");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder) {
        modelBuilder.Entity<Title>()
            .HasMany(e => e.Genres)
            .WithMany(e => e.Titles)
            .UsingEntity<TitleGenre>(
                r => r.HasOne<Genre>().WithMany(e => e.TitleGenres),
                l => l.HasOne<Title>().WithMany(e => e.TitleGenres)
            );

        modelBuilder.Entity<TitleCredit>()
            .Property(e => e.Role)
            .HasConversion(
                v => v.ToString(),
                v => (RoleType)Enum.Parse(typeof(RoleType), v));
    }
}