using Microsoft.EntityFrameworkCore;

public class AnimeDbContext : DbContext
{
    public AnimeDbContext(DbContextOptions<AnimeDbContext> options) : base(options) { }

    public DbSet<AnimeItem> AnimeItems { get; set; } = null!;
}
