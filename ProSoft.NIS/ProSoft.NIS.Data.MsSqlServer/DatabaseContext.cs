using Microsoft.EntityFrameworkCore;
using ProSoft.NIS.Contracts.DataModels;
using ProSoft.NIS.Data.MsSqlServer.ModelConfigurations;

namespace ProSoft.NIS.Data.MsSqlServer;

/// <summary>
/// Class DatabaseContext. This class cannot be inherited.
/// Implements the <see cref="System.IDisposable" />
/// </summary>
/// <seealso cref="DbContext" />
public sealed class DatabaseContext : DbContext
{
	/// <summary>
	/// Initializes a new instance of the <see cref="DatabaseContext"/> class.
	/// </summary>
	public DatabaseContext()
	{
		
	}

	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		if (!optionsBuilder.IsConfigured)
		{
			optionsBuilder.UseSqlServer(Environment.GetEnvironmentVariable("PROSOFT_NIS_CONNECTIONSTRING"));
		}
		base.OnConfiguring(optionsBuilder);
	}

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		modelBuilder.Entity<Building>().ConfigureDatabaseEntity();
		modelBuilder.Entity<Cable>().ConfigureDatabaseEntity();
		modelBuilder.Entity<Cage>().ConfigureDatabaseEntity();
		modelBuilder.Entity<Campus>().ConfigureDatabaseEntity();
		modelBuilder.Entity<Floor>().ConfigureDatabaseEntity();
		modelBuilder.Entity<Hallway>().ConfigureDatabaseEntity();
		modelBuilder.Entity<Port>().ConfigureDatabaseEntity();
		modelBuilder.Entity<Rack>().ConfigureDatabaseEntity();
		modelBuilder.Entity<RackItem>().ConfigureDatabaseEntity();
		modelBuilder.Entity<Room>().ConfigureDatabaseEntity();
		modelBuilder.Entity<Switch>().ConfigureDatabaseEntity();
	}
}
