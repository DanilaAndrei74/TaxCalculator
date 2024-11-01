using Microsoft.EntityFrameworkCore;
using System.Xml;
using CommifyInterview.Entities;

namespace CommifyInterview.DataAccess;

public class DatabaseContext : DbContext
{
    public DatabaseContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
    }

    public DbSet<TaxBand> TaxBands { get; set; }
    
}