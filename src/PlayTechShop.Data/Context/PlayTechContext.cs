using Microsoft.EntityFrameworkCore;
using PlayTechShop.Data.Mappings;
using PlayTechShop.Domain.Entities;

namespace PlayTechShop.Data.Context;
public class PlayTechContext : DbContext
{
    public PlayTechContext(DbContextOptions<PlayTechContext> options) : base(options) { }

    /// <summary>
    /// Representação das tabelas
    /// </summary>
    
    public DbSet<State> State { get; set; }
    public DbSet<City> City { get; set; }
    public DbSet<Client> Client { get; set; }
    public DbSet<Company> Company { get; set; }
    public DbSet<Employee> Employee { get; set; }
    public DbSet<Inventory> Stoke { get; set; }
    public DbSet<Wage> Wage { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfigurationsFromAssembly(typeof(CityMap).Assembly);
    }
}