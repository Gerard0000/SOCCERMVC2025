using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using SOCCERMVC2025.web.Data.Entities;

namespace SOCCERMVC2025.web.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }

    public DbSet<TournamentEntity> Tournaments { get; set; }
    public DbSet<GroupEntity> Groups { get; set; }
    public DbSet<GroupDetailEntity> GroupDetails { get; set; }
    public DbSet<MatchEntity> Matches { get; set; }
    public DbSet<TeamEntity> Teams { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<TeamEntity>().HasIndex(t => t.Name).IsUnique();
    }
}