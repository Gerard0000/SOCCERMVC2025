using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using SOCCERMVC2025.web.Data.Entities;

namespace SOCCERMVC2025.web.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }

    public DbSet<TeamEntity> Teams { get; set; }
}