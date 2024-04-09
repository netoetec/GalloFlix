using GalloFlix.Models;
using Microsoft.EntityFrameworkCore;

namespace GalloFlix.Data;

public class AppDbContext : DbContext   
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {   
    }

    public DbSet<Genre> Genres { get; set; }
    
}