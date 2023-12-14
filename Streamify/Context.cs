using Microsoft.EntityFrameworkCore;
namespace Streamify;

public class Context : DbContext {
<<<<<<< Updated upstream
    public DbSet<Title> Titles { get; set; }
    public DbSet<Genre> Genres { get; set; }
    public DbSet<Person> Persons { get; set; }
=======
    public DbSet<Genres> Genres { get; set; }
    public DbSet<Person> Person { get; set; }
    public DbSet<Ratings> Ratings { get; set; }
    public DbSet<TitleCredits> TitleCredits { get; set; }
    public DbSet<TitleGenres> TitleGenres { get; set; }
    public DbSet<Titles> Titles { get; set; }
    public DbSet<Users> Users { get; set; }
    public DbSet<Watchlists> Watchlists { get; set; }
>>>>>>> Stashed changes

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