using Microsoft.EntityFrameworkCore;
namespace Streamify;

public class Context : DbContext {
    public DbSet<Title> Titles { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
        optionsBuilder.UseNpgsql("Host=localhost:5432;Database=flilms;Username=postgres;Password=myverysecretpassword");
    }
}