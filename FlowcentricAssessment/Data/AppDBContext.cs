using FlowcentricAssessment.Models;
using Microsoft.EntityFrameworkCore;

namespace FlowcentricAssessment.Data
{
  public class AppDBContext : DbContext
  {
    public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
    {

    }

    public DbSet<ProductSettings> ProductSettings { get; set; }
    public DbSet<ClientSettings> ClientSettings { get; set; }
    public DbSet<CustomSettingsString> CustomSettingsString { get; set; }
    public DbSet<CustomSettingsInt> CustomSettingsInt { get; set; }
    public DbSet<CustomSettingsBool> CustomSettingsBool { get; set; }
    public DbSet<CustomSettings> CustomSettings { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
  
      base.OnModelCreating(modelBuilder);
    }
  }
}
